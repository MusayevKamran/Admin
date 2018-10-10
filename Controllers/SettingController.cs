using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial.Controllers
{
    public class SettingController : Controller
    {
        [Route("admin/setting")]
        public IActionResult Index()
        {
            return View();
        }
    }
}