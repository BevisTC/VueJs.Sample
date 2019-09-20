using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VueJs.Sample.Web.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult DoAction([FromBody] RegisteViewModel model)
        {
            
            return Json("data");
        }




    }

    public class RegisteViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Agree { get; set; }

        public int Gender { get; set; }
    }
}