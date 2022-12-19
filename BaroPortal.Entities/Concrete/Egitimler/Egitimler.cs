using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Egitimler
{
    public class Egitimler :BaseEntity
    {
        public string Title { get; set; } = null!;
        public string? FileName { get; set; }   
        public byte[]? FileByte { get; set; }
        public string? FilePath { get; set; }
        public string? FileExtension { get; set; }
    }
}
