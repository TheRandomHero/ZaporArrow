using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ZaporArrow.Entities
{
    public class Arrow
    {
        [Key]
        public Guid ArrowId { get; set; }

        public int Length { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<Image> Images { get; set; } =
            new List<Image>();
    }
}
