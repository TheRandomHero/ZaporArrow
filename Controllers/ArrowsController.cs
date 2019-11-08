using System;
using Microsoft.AspNetCore.Mvc;
using ZaporArrow.Models;
using ZaporArrow.Services;
using AutoMapper;

namespace ZaporArrow.Controllers
{
    public class ArrowsController : Controller
    {
        private readonly IZaporArrowRepository _zaporArrowRepository;
        private readonly IMapper _mapper;

        public ArrowsController(IZaporArrowRepository arrowRepository, IMapper mapper)
        {
            _zaporArrowRepository = arrowRepository ??
                throw new ArgumentException(nameof(arrowRepository));
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Gallery()
        {

            var getAllArrows = _zaporArrowRepository.GetAllArrows();

            return View(getAllArrows);
        }

        [HttpGet("{Id:guid}")]
        public IActionResult ArrowDetails([FromRoute]Guid Id)
        {
            var arrowFromRepo = _zaporArrowRepository.GetArrow(Id);

            var mappedArrow = _mapper.Map<ArrowDto>(arrowFromRepo);


            return View(_mapper.Map<ArrowDto>(arrowFromRepo));
        }
    }
}