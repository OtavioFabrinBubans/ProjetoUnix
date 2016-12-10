using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Repositorio;
using UnixsGeradordeProvas.Aplicativo;
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

        public ActionResult CadastroDisciplina()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SalvarDificuldade(DificuldadeModel model)
        {
            var aplicativo = new DificuldadeAplicativo();
            Dificuldade dificuldade = new Dificuldade()
            {
                Id = model.Id.HasValue ? model.Id.Value : 0,
                Descricao = model.Descricao
              };
            aplicativo.Salvar(dificuldade);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult SalvarDisciplina(DisciplinaModel model)
        {
            var aplicativo = new DisciplinaAplicativo();
            Disciplina disciplina = new Disciplina()
            {
                Id = model.Id.HasValue ? model.Id.Value : 0,
                Nome = model.Nome
            };
            aplicativo.Salvar(disciplina);

            return RedirectToAction("Index");

        }


    }
}