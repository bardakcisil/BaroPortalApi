using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Calculation
{
    public class SMMH
    {
        public string? Tur { get; set; }
        public double? Stopaj { get; set; }
        public double? Kdv { get; set; }
        public double? Tevkifat { get; set; }
        public double? Fon { get; set; }    
       public double? BrutTutar { get; set; }
        public double? NetTutar { get; set; }
        public double? NetKdv { get; set; }
        public double? KDVliTutar { get; set; } 
        public double? Amount { get; set; }
    }
}
