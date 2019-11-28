using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZaporArrow.Services;

namespace ZaporArrow.Controllers.Api
{
    public class GalleryController : Controller
    {
        private readonly IZaporArrowRepository _repository;

        public GalleryController(IZaporArrowRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("api/gallery")]
        public JsonResult Get()
        {
            var result = _repository.GetAllArrows();
            return Json(result);
        }
    }
}
