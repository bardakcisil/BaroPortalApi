using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Announcements
{
    public class DownloadFile
    {
        public IFormFile? Pdf { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
    }
}
