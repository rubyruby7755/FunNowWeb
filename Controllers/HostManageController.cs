﻿using Microsoft.AspNetCore.Mvc;
using PrjFunNowWeb.Models;
using PrjFunNowWeb.ViewModels;

namespace PrjFunNowWeb.Controllers
{
    public class HostManageController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FunNowContext _context;

        public HostManageController(ILogger<HomeController> logger, FunNowContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Home()
        {
            return View();
        }


    }
}
