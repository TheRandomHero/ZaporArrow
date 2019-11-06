using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZaporArrow.Entities
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public Guid ArrowId { get; set; }
        public double Size { get; set; }
        public string ImageSource { get; set; }
    }
}
