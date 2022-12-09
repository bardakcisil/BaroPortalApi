using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Seeds
{
    public static class CourtSeed
    {
        public static readonly List<Court> court = new List<Court>()
    {

             new   Court() { Id =1, TypeId = 1, Name = "İcra Mahkemeleri", CreateDate=DateTime.Now },
            new    Court() { Id = 2, TypeId = 2, Name = "Sulh Hukuk Mahkemeleri", CreateDate = DateTime.Now },
             new   Court() { Id = 3, TypeId = 3, Name = "Sulh Ceza/İnfaz Hakimlikleri", CreateDate = DateTime.Now },
             new   Court() { Id = 4, TypeId = 4, Name = "Asliye Mahkemeleri", CreateDate = DateTime.Now },
             new   Court() { Id = 5, TypeId = 5, Name = "Tüketici Mahkemeleri", CreateDate = DateTime.Now },
             new   Court() { Id = 6, TypeId = 6, Name = "Fikri ve Sınai Haklar Mahkemeleri", CreateDate = DateTime.Now },
             new   Court() { Id = 7, TypeId = 7, Name = "İdare ve Vergi Mahkemeleri-Duruşmalı", CreateDate = DateTime.Now },
             new   Court() { Id = 8, TypeId = 8, Name = "İdare ve Vergi Mahkemeleri-Duruşmasız", CreateDate = DateTime.Now }

    };
    }
  
}
