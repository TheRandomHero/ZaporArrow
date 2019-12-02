using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZaporArrow.Entities;

namespace ZaporArrow.Services
{
    public interface IZaporArrowRepository
    {
        IEnumerable<Arrow> GetAllArrowsWithImages();
        Arrow GetArrow(Guid id);
        void AddArrow(Arrow arrow);
        void AddImage(Image image);
        void AddImageToArrow(Guid arrowId, Image image);
        void DeleteArrow(Arrow arrow);
    }
}
