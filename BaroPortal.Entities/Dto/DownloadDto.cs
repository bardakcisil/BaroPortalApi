using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class DownloadDto: GetDto
    {
        public IFormFile PdfFile { get; set; } = null!;
    }
}
