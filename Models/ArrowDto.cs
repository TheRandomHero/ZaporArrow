using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZaporArrow.Entities;

namespace ZaporArrow.Models
{
    public class ArrowDto
    {
        public Guid ArrowId { get; set; }

        public double Length { get; set; }

        public string Description { get; set; }

        public string ProfilPicture { get; set; }

        public ICollection<Image> Images { get; set; }

    }
}
