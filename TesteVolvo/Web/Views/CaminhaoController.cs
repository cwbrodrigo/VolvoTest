using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TesteVolvo.Web.Views
{
    public class CaminhaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}