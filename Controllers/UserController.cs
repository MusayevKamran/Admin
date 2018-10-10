using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial.Controllers
{
    public class UserController : Controller
    {
        [Route("admin/user")]
        public IActionResult Index()
        {
            return View();
        }
    }
}