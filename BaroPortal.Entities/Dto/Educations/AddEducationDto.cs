﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Educations
{
    public class AddEducationDto
    {
        public string Title { get; set; }
        public IFormFile PdfFile { get; set; } = null!;

    }
}
