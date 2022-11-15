using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IUserService
    {
        ResponseDto Login(UserForLogin userForLogin);
        bool Register(UserForRegister userForRegister);
    }
}
