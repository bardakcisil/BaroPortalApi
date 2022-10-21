using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class UserForLogin
    {
        public string IdentityNumber { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
