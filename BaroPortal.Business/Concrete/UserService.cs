using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
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
        private string RandomPassword;

        public UserService(IUserDal userDal, IConfiguration configuration)
        {
            _userDal = userDal;
            _configuration = configuration;
        }





        public string Login(UserForLogin userforlogin)
        {
            var user = _userDal.GetUserByIdentity(userforlogin.IdentityNumber);

            if (user is null)
            {
                return ("User Not found");
            }

            else if (!VerifyPasswordHash(userforlogin.Password, user.PasswordHash, user.PasswordSalt))
            {
                return ("Wrong Password!");
            }
            else
            {

                //We create Token here
                string token = CreateToken(user);
                return token;
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
                RandomPassword = GeneratePassword();
                Console.WriteLine(RandomPassword);


                CreatePasswordHash(RandomPassword, out byte[] passwordHash, out byte[] passwordSalt);
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

            }

            var result = _userDal.Insert(user);

            SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
            MailMessage message = new MailMessage();
            message.From = new MailAddress("karartek@yandex.com");
            message.To.Add(userForRegister.Email);
            message.Subject = "Merhaba " + userForRegister.FirstName;
            message.Body = "Karartek uygulama şifreniz: " + RandomPassword;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true; // Encryption
            client.Credentials = new System.Net.NetworkCredential("karartek@yandex.com", "plbobupzzvaxxgpw");

            client.Send(message);
            if (result != null)
            {
                return true;

            }
            return false;
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
