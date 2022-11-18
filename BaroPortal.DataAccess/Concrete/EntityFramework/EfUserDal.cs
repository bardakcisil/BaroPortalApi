using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:IUserDal {
        public User GetUserByIdentity(string identityNumber)
        {
            using var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.IdentityNumber == identityNumber);
            return user;
        }

        public User Insert(User user)
        {
            using var context = new AppDbContext();
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
        public User userForForgotPassword(string identityNumber, byte[] passwordHash, byte[] passwordSalt)
        {

            using var context = new AppDbContext();
            var user = GetUserByIdentity(identityNumber);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;  //here password Hash was written :)

            context.Update(user);
            context.SaveChanges();

            return user;



        }
    }

   


}
