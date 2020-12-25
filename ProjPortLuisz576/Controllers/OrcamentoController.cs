using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Etapa_3.Models;
using Microsoft.AspNetCore.Http;

namespace Etapa_3.Controllers
{

    public class OrcamentoController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private Database database = new Database();

        public OrcamentoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(int lang = 0)
        {
            ViewBag.error = false;
            ViewBag.logged = IsLogged();
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrcamentoPedido orcamentoPedido=null){
            if(database.PNewOrcamento(orcamentoPedido))
                return View("OrcamentoEnviado");
            ViewBag.error = true;
            ViewBag.logged = IsLogged();
            return View();
        }

        public IActionResult OrcamentosEnviados(){
            if(IsLogged())
                return View(database.PGetOrcamentos(false));
            return RedirectToAction("LogOff", "Home");
        }

        public IActionResult TodosOrcamentos(){
            if(IsLogged())
                return View(database.PGetOrcamentos(true));
            return RedirectToAction("LogOff", "Home");
        }

        [HttpGet]
        public IActionResult OrcamentoView(int id=-1){
            if(IsLogged()){
                OrcamentoPedido orcamento = database.PGetOrcamento(id);
                if(orcamento != null)
                    return View(orcamento);
                else
                    return Redirect("Orcamento");
            }
            return RedirectToAction("LogOff", "Home");
        }

         [HttpGet]
        public IActionResult OrcamentoLido(int id=-1){
            if(IsLogged()){
                database.PReadedOrcamento(id);
                return RedirectToAction("OrcamentoView", new { @id = id });
            }
            return RedirectToAction("Index", "Home");
        }
        
        private bool IsLogged(){ return database.Login(HttpContext.Session.GetString("_Login"), HttpContext.Session.GetString("_Senha")); }

    }

}