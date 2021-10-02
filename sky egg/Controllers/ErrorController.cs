using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    ViewBag.errorMsg = "we could not found de path";
                    break;
            }
            return View("NotFound");
        }
    }
}
