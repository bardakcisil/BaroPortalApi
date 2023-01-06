using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Login
{
    public class ResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public string Token { get; set; } = null!;

        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string IdentityNumber { get; set; } = null!;

    }
}