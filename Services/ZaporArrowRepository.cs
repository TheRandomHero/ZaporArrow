using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZaporArrow.DbContexts;
using ZaporArrow.Entities;

namespace ZaporArrow.Services
{
    public class ZaporArrowRepository : IZaporArrowRepository
    {
        private readonly ZaporArrowContext _zaporArrowContext;

        public ZaporArrowRepository(ZaporArrowContext context)
        {
            _zaporArrowContext = context ?? 
                throw new ArgumentNullException(nameof(context));
        }
        public void AddImage(Image image)
        {
            _zaporArrowContext.Images.Add(image);
            _zaporArrowContext.SaveChanges();
        }
        public void AddArrow(Arrow arrow)
        {
            _zaporArrowContext.Arrows.Add(arrow);
            _zaporArrowContext.SaveChanges();
        }

        public void DeleteArrow(Arrow arrow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arrow> GetAllArrows()
        {
            var allArrows = _zaporArrowContext.Arrows.ToList<Arrow>();
            foreach(var arrow in allArrows)
            {
                arrow.Images = _zaporArrowContext.Images.Where(x => x.ArrowId == arrow.ArrowId).ToList();
            }

            return allArrows;
        }

        public Arrow GetArrow(Guid arrowId)
        {
            if(arrowId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(arrowId));
            }

            var arrowFromDb = _zaporArrowContext.Arrows.FirstOrDefault(a => a.ArrowId == arrowId);
            arrowFromDb.Images = _zaporArrowContext.Images.Where(x => x.ArrowId == arrowId).ToList();

            return arrowFromDb;
        }
    }
}
