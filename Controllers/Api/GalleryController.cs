using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ZaporArrow.Models;
using ZaporArrow.Services;

namespace ZaporArrow.Controllers.Api
{
    [ApiController]
    [Route("api/gallery")]
    public class GalleryController : Controller
    {
        private readonly IZaporArrowRepository _zaporArrowRepository;
        private readonly IMapper _mapper;

        public GalleryController(IZaporArrowRepository repository, IMapper mapper)
        {
            _zaporArrowRepository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var result = _zaporArrowRepository.GetAllArrowsWithImages();
            return Json(result);
        }

        [HttpGet("{Id:guid}")]
        public JsonResult ArrowDetais([FromRoute]Guid Id)
        {
            var arrowFromRepo = _zaporArrowRepository.GetArrow(Id);

            var mappedArrow = _mapper.Map<ArrowDto>(arrowFromRepo);


            return Json(mappedArrow);
        }
    }
}
