using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Calculation
{
    public class IFH
    {
        public DateTime? Start { get; set; } 
        public DateTime? End { get; set; }
        public String? TotDay { get; set; } 
        public double? Amount { get; set; }  
        public double? InterestPercent { get; set; }    
    }
}
