using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZaporArrow.Services;
using ZaporArrow.ViewModels;
using ZaporArrow.Models;

namespace ZaporArrow.Controllers.Api
{
    [ApiController]
    [Route("api/gallery/{arrowId}/images")]
    public class ImageController : Controller
    {
        private readonly IZaporArrowRepository _zaporArrowRepository;
        private readonly IMapper _mapper;

        public ImageController(IZaporArrowRepository zaporArrowRepository, IMapper mapper)
        {
            _zaporArrowRepository = zaporArrowRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public JsonResult GetImages([FromRoute] Guid arrowId)
        {
            try
            {
                var result = _zaporArrowRepository.GetArrow(arrowId);
                
                if (result == null)
                {
                    return Json(null);
                }
                return Json(_mapper.Map<IEnumerable<ImageDto>>(result.Images));
            }
            catch(Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Error occured findig Arrow"); 
            }
            
        }
    }
}