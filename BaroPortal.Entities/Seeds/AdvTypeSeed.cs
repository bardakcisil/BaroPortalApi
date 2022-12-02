using BaroPortal.Entities.Concrete.Advertisement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Seeds
{
    public static class AdvTypeSeed {
        public static readonly List<AdvType> advertType = new List<AdvType>()
    {

             new   AdvType() { Id =1, TypeId = 1, Name = "İş Arıyorum", CreateDate=DateTime.Now },
            new    AdvType() { Id = 2, TypeId = 2, Name = "Avukat Arıyorum", CreateDate = DateTime.Now },
             new   AdvType() { Id = 3, TypeId = 3, Name = "Katip/Sekreter Arıyorum", CreateDate = DateTime.Now },
             new   AdvType() { Id = 4, TypeId = 4, Name = "Staj Yeri Arıyorum", CreateDate = DateTime.Now },
             new   AdvType() { Id = 5, TypeId = 5, Name = "Ortak Arıyorum", CreateDate = DateTime.Now },
             new   AdvType() { Id = 6, TypeId = 6, Name = "Stajyer Av. Arıyorum", CreateDate = DateTime.Now },
             new   AdvType() { Id = 7, TypeId = 7, Name = "Diğer", CreateDate = DateTime.Now }

    };
    }
}
