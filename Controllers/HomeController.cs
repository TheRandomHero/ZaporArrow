using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZaporArrow.Entities;
using ZaporArrow.Models;
using ZaporArrow.Services;
using ZaporArrow.ViewModels;

namespace ZaporArrow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IZaporArrowRepository _zaporArrowRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(ILogger<HomeController> logger, IZaporArrowRepository arrowRepository,
                                IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _zaporArrowRepository = arrowRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ArrowViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if(model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Arrow newArrow = new Arrow
                {
                    ArrowId = Guid.NewGuid(),
                    Length = model.Length,
                    Description = model.Description,
                    Images = new List<Image>(),

                };

                Image newImage = new Image
                {
                    ImageId = Guid.NewGuid(),
                    ArrowId = newArrow.ArrowId,
                    Size = model.Photo.Length,
                    ImageSource = "/images/" + uniqueFileName,

                };

                _zaporArrowRepository.AddArrow(newArrow);
                _zaporArrowRepository.AddImage(newImage);

                return Redirect($"/{newArrow.ArrowId}");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
