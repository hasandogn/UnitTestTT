using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestTT.Data;
using UnitTestTT.Repository.Interfaces;

namespace UnitTestTT.Controllers
{
    public class WebUserController : Controller
    {
        private readonly IWebUserRepository _webUserRepository;

        public WebUserController(IWebUserRepository webUserRepository)
        {
            _webUserRepository = webUserRepository;
        }

        public IActionResult Index()
        {
            // 1. yöntem dbdeki verilerle uğraşma moq data ile çalış böylece stratup dosya vs ile uğraşmana gerek kalmayacak

            List<WebUser> webUsers = _webUserRepository.GetWebUsers();
            return View(webUsers);
        }
    }
}
