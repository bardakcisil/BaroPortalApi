using BaroPortal.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Educations
{
    public class Education : BaseEntity
    {
        public string Title { get; set; } = null!;
        public byte[] PdfFile { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string FileSize { get; set; } = null!;
    }
}
