using Revisao.Models;
using Revisao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revisao.Controllers
{
    public class EmpresaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();
        [HttpGet]
        public ActionResult Listar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _unit.EmpresaRepository.Salvar(empresa);
                _unit.Save();
                return RedirectToAction("Cadastrar");
            }
            else
            {
                return View(empresa);
            }
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}