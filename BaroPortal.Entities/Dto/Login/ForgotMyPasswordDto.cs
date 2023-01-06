using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Login
{
    public class ForgotMyPasswordDto
    {
        public string IdentityNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
