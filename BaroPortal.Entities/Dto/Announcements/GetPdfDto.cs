using BaroPortal.Entities.Concrete.Duyurular;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Announcements
{
    public class GetPdfDto
    {
       
        //public void? Pdf { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public byte[] PdfFile { get; set; } = null!;//static void SaveByteArrayToFileWithStaticMethod(byte[] data, string filePath)=> File.WriteAllBytes(filePath, data);
        public string FilePath { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string FileSize { get; set; } = null!;


    }
}
