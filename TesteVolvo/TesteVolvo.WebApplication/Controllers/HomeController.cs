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

            List<SelectListItem> lstAno = new List<SelectListItem>();

            SelectListItem ano1 = new SelectListItem
            {
                Text = "2020",
                Value = "2020"
            };

            SelectListItem ano2 = new SelectListItem
            {
                Text = "2021",
                Value = "2021"
            };

            lstAno.Add(ano1);
            lstAno.Add(ano2);

            ViewBag.ListAno = lstAno;

            return View(new Caminhao());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = service.Select(id);

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

            List<SelectListItem> lstAno = new List<SelectListItem>();

            SelectListItem ano1 = new SelectListItem
            {
                Text = "2020",
                Value = "2020"
            };

            SelectListItem ano2 = new SelectListItem
            {
                Text = "2021",
                Value = "2021"
            };

            lstAno.Add(ano1);
            lstAno.Add(ano2);

            ViewBag.ListAno = lstAno;

            return View(model);
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Insert(Caminhao model)
        {
            if (ModelState.IsValid)
            {

                model.AnoFabricacao = "2020";

                service.Post<Caminhao>(model);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Update(Caminhao model)
        {
            if (ModelState.IsValid)
            {

                model.AnoFabricacao = "2020";

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

    }
}
