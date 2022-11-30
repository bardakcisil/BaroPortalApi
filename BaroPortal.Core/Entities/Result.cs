﻿using BaroPortal.Core.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Core.Entities
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)//tek paremetreli constructurunu(s18) da calistir demek this ise resultun kendisi
        {
            Message = message;
            //Success = success;  bunu yazma 2 kere calisiyo cunkubi 18de bi14de
        }

        //overloading
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; } //get read only oldugundan constructor ile set edilebilir
    }
}
