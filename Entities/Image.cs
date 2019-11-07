using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZaporArrow.Entities
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }

        [ForeignKey("ArrowId")]
        public Guid ArrowId { get; set; }

        public double Size { get; set; }

        [Required]
        public string ImageSource { get; set; }
    }
}
