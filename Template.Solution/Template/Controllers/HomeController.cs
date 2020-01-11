using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Template.Models;

namespace Template.Controllers
{
  public class HomeController : Controller
  {
   [Route("/")]
   public ActionResult Index()
   {
     return View();
   }
  }
}