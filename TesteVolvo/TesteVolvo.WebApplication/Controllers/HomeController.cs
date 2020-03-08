using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using TesteVolvo.Domain;
using TesteVolvo.Domain.Interfaces;
using TesteVolvo.WebApplication.Models;

namespace TesteVolvo.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor 
        IService<Caminhao> service;
        public HomeController(IService<Caminhao> service)
        {
            this.service = service;
        }
        #endregion

        #region GET
        public IActionResult Index()
        {
            var result = service.SelectAll();

            return View(result);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            List<SelectListItem> lstModelo = new List<SelectListItem>();

            ViewBagCreate();

            return View(new Caminhao());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = service.Select(id);

            ViewBagCreate();

            return View(model);
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Insert(Caminhao model)
        {
            if (ModelState.IsValid)
            {
                service.Post<Caminhao>(model);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Update(Caminhao model)
        {
            if (ModelState.IsValid)
            {
                service.Put<Caminhao>(model);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Excluir(int id)
        {
            service.Delete(id);

            return RedirectToAction("Index");
        }
        #endregion

        public void ViewBagCreate()
        {
            List<SelectListItem> lstModelo = new List<SelectListItem>();

            SelectListItem item1 = new SelectListItem
            {
                Text = Modelo.FH.ToString(),
                Value = "1"
            };

            SelectListItem item2 = new SelectListItem
            {
                Text = Modelo.FM.ToString(),
                Value = "2"
            };

            lstModelo.Add(item1);
            lstModelo.Add(item2);

            ViewBag.ListModelo = lstModelo;

            List<SelectListItem> lstAnoModelo = new List<SelectListItem>();

            SelectListItem ano1 = new SelectListItem
            {
                Text = DateTime.Now.Year.ToString(),
                Value = DateTime.Now.Year.ToString()
            };

            SelectListItem ano2 = new SelectListItem
            {
                Text = DateTime.Now.AddYears(1).Year.ToString(),
                Value = DateTime.Now.AddYears(1).Year.ToString()
            };

            lstAnoModelo.Add(ano1);
            lstAnoModelo.Add(ano2);

            List<SelectListItem> anoFabricacao = new List<SelectListItem>();

            SelectListItem anoFab = new SelectListItem
            {
                Text = DateTime.Now.Year.ToString(),
                Value = DateTime.Now.Year.ToString()
            };

            anoFabricacao.Add(anoFab);

            ViewBag.ListAno = lstAnoModelo;

            ViewBag.AnoFabricacao = anoFabricacao;
        }

    }
}
