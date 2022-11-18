using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class ForgotMyPasswordDto
    {
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
