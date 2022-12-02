using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class UploadDto:AddDto
    {
        public IFormFile PdfFile { get; set; } = null!;
    }
}
