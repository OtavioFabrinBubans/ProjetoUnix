using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Repositorio;
using UnixsGeradorDeProvas.Models;

namespace UnixsGeradorDeProvas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroDificuldade()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Salvar(DificuldadeModel model)
        {

            var repositorio = new DificuldadeRepositorio();
            Dificuldade dificuldade = new Dificuldade()
            {
                Id = model.Id,
                Descricao = model.Descricao
            };
            repositorio.Salvar(dificuldade);

            return RedirectToAction("Index");

        }


    }
}