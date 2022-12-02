using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class Download
    {
        public string? fileType { get; set; }
        public byte[]? archiveData { get; set; }
        public string? archiveName { get; set; }
    }
}
