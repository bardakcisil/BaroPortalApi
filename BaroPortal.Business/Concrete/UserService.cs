using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Login;
using BaroPortal.Entities.Dto.Login;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class UserService : IUserService
    {


        private readonly IUserDal _userDal;
        private readonly IConfiguration _configuration;
      



        public UserService(IUserDal userDal, IConfiguration configuration)
        {
            _userDal = userDal;
            _configuration = configuration;
        }


        public ResponseDto Login(UserForLogin userforlogin)
        {
            ResponseDto response = new ResponseDto();
            var user = _userDal.GetUserByIdentity(userforlogin.IdentityNumber);

            if (user is null)
            {
               response.HasError = true;
               response.Message = "Wrong";
                return response;

            }

            else if (!VerifyPasswordHash(userforlogin.Password, user.PasswordHash, user.PasswordSalt))
            {
                response.HasError = true;
                response.Message = "User Not Found";
                return response;
            }
            else
            {

                //We create Token here
                response.Token = CreateToken(user);
                response.HasError = false;
                response.Message = "User Found";
                response.firstName = user.FirstName;
                response.lastName = user.LastName;
                response.IdentityNumber = user.IdentityNumber;
                response.PhoneNumber=user.PhoneNumber;
                response.Email=user.Email;
                return response;
            }

        }
        public bool Register(UserForRegister userForRegister)
        {
            var user = _userDal.GetUserByIdentity(userForRegister.IdentityNumber);

            if (user is not null)
            {
                return false;
            }

            else

            {
                //RandomPassword = GeneratePassword();
                //Console.WriteLine(RandomPassword);


                CreatePasswordHash(userForRegister.Password, out byte[] passwordHash, out byte[] passwordSalt);
                string dataToSave = Convert.ToBase64String(passwordHash);
                Console.WriteLine(dataToSave);

                user = new User()
                {
                    UserName = userForRegister.UserName,
                    FirstName = userForRegister.FirstName,
                    LastName = userForRegister.LastName,
                    Email = userForRegister.Email,
                    IdentityNumber = userForRegister.IdentityNumber,
                    PhoneNumber = userForRegister.PhoneNumber,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt
                };

                user.CreateDate = DateTime.Now; 

            }
            var result = _userDal.Insert(user);
            return true;
        }

       
     

        public ResponseDto ForgotMyPassword(ForgotMyPasswordDto forgotMyPasswordDto)
        {
            ResponseDto response = new ResponseDto();
            string NewRandomPassword = GeneratePassword();
            var user = _userDal.GetUserByIdentity(forgotMyPasswordDto.IdentityNumber);



           


            if (user is null || user.Email != forgotMyPasswordDto.Email || user.IdentityNumber != forgotMyPasswordDto.IdentityNumber)
            {
                response.HasError = true;
                response.Message = "Bilgilerinizi kontrol ediniz"; //mantıksız
                return response;

            }

            else
            {


                CreatePasswordHash(NewRandomPassword, out byte[] passwordHash, out byte[] passwordSalt);
                var userToResetPassword = _userDal.userForForgotPassword(forgotMyPasswordDto.IdentityNumber, passwordHash, passwordSalt);


                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("baroportal@yandex.com");
                message.To.Add(userToResetPassword.Email);
                message.Subject = "Merhaba Sayın " + userToResetPassword.FirstName + " " + userToResetPassword.LastName;
                message.Body = "Yeni uygulama şifreniz: " + NewRandomPassword;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Encryption
                client.Credentials = new System.Net.NetworkCredential("baroportal@yandex.com", "nntdrirfvaajoynl");
                client.Send(message);



                //We create Token here

                response.HasError = false;
                response.Message = "Şifre Sıfırlama İşlemi Başarılı";
                return response;
            }


        }


        public string GeneratePassword()
        {
            string PasswordLength = "8";
            string NewPassword = "";

            string allowedChars = "";
            allowedChars = "1,2,3,4,5,6,7,8,9,0";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";//özelkarakter
            allowedChars += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";


            char[] sep = {
            ','
        };
            string[] arr = allowedChars.Split(sep);


            string IDString = "";
            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < Convert.ToInt32(PasswordLength); i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                IDString += temp;
                NewPassword = IDString;

            }

            return NewPassword;
        }



            // Hashing functions 
            public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())

            {

                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));


            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }



        ///Token Function

        private string CreateToken(User user)
        {

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var _claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Name, user.UserName),

                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var token = new JwtSecurityToken(claims: _claims,
                                             expires: DateTime.Now.AddDays(2),
                                             signingCredentials: cred);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

    }
}
