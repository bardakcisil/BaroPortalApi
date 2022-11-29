using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Core.Entities
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(false, message)
        {

        }
        public SuccessResult() : base(false)
        {

        }
    }
}
