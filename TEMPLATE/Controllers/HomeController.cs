using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GENERICTEMPLATEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.Models
using System;

namespace GENERICTEMPLATEXXXXXXXXXXXXXXXXXXXXXXXXXXXX.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
          public ActionResult Index()
          {

            return View();

          }
          [HttpPost("/")]
          public ActionResult Result()
          {

            return View();
          }


    }
}
