using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZaporArrow.Services;

namespace ZaporArrow.Controllers
{
    public class ArrowsController : Controller
    {
        private readonly IZaporArrowRepository _zaporArrowRepository;

        public ArrowsController(IZaporArrowRepository arrowRepository)
        {
            _zaporArrowRepository = arrowRepository ??
                throw new ArgumentException(nameof(arrowRepository));
        }

        [HttpGet]
        public IActionResult Gallery()
        {

            var getAllArrows = _zaporArrowRepository.GetAllArrows();

            return View(getAllArrows);
        }
    }
}