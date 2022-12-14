using BaroPortal.Entities.Concrete.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IUserDal
    {
        User GetUserByIdentity(string identity);
        User Insert(User user);
        User userForForgotPassword(string identityNumber, byte[] passwordHash, byte[] passwordSalt);
    
        User Get(Func<User, bool>? filter = null);
    }
}
