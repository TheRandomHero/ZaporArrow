using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZaporArrow.ViewModels
{
    public class ArrowViewModel
    {
        public double Length { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public IFormFile Photo { get; set; } 
    }
}
