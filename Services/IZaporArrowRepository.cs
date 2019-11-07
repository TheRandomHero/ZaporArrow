using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZaporArrow.Entities;

namespace ZaporArrow.Services
{
    public interface IZaporArrowRepository
    {
        IEnumerable<Arrow> GetAllArrows();
        Arrow GetArrow(Guid id);
        void AddArrow(Arrow arrow);
        void AddImage(Image image);
        void DeleteArrow(Arrow arrow);
    }
}
