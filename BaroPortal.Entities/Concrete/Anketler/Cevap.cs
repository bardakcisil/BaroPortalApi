using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Anketler
{
    public class Cevap : BaseEntity
    {
        public int? AnswerId;
        public string? AnswerName;
        public IList<Soru>? Question { get; set; }
    }
}
