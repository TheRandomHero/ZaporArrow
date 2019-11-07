using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ZaporArrow.Models;
using ZaporArrow.Services;

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

        [HttpGet("{arrowId:guid}")]
        public IActionResult ArrowDetails(Guid arrowId)
        {
            var arrowFromRepo = _zaporArrowRepository.GetArrow(arrowId);

            return View(arrowFromRepo);
        }
    }
}