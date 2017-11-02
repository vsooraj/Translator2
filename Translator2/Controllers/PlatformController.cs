using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Translator2.Models;

namespace Translator2.Controllers
{
    public class PlatformController : Controller
    {
        private readonly IPlatformRepository _platformRepository;

        public PlatformController(IPlatformRepository platformRepository)
        {
            _platformRepository = platformRepository;
        }
        public ViewResult Index()
        {
            ViewBag.Title = "Mi Translator";
            return View(_platformRepository.Platforms);
        }
    }
}