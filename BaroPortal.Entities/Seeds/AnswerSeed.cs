﻿using BaroPortal.Entities.Concrete.Anketler;
using BaroPortal.Entities.Concrete.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Seeds
{
    public static class AnswerSeed
    {
        public static readonly List<Cevap> answer = new List<Cevap>()
    {

             new   Cevap() { Id =1, AnswerId = 1, AnswerName = "Strongly Disagree", CreateDate=DateTime.Now },
            new    Cevap() { Id = 2, AnswerId = 2, AnswerName = "Disagree", CreateDate = DateTime.Now },
             new   Cevap() { Id = 3, AnswerId = 3, AnswerName = "Neutral", CreateDate = DateTime.Now },
             new   Cevap() { Id = 4, AnswerId = 4, AnswerName = "Agree", CreateDate = DateTime.Now },
             new   Cevap() { Id = 5, AnswerId = 5, AnswerName = "Strongly Agree", CreateDate = DateTime.Now },
 

    };
    }
}
