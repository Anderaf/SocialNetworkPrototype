﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialNetworkPrototype.Models.Users;
using SocialNetworkPrototype.ViewModels;
using SocialNetworkPrototype.ViewModels.Account;
using System.Diagnostics;

namespace SocialNetworkPrototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager,
            SignInManager<User> signInManager, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        /*[Route("")]*/
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("MyPage", "AccountManager");
            }
            else
            {
                return View(new MainViewModel());
            }
        }

        [Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
