using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services_;
using TesteVolvo.Domain;
using TesteVolvo.Domain.Interfaces;

namespace TesteVolvo.Web.Controllers
{
    public class DefaultController : Controller
    {
        private IService<Caminhao> service = new Service<Caminhao>();
        public IActionResult Index()
        {
            return View();
        }
    }
}