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

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private Database database = new Database();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(int lang = 0)
        {
            ViewBag.text_about_me = "<span class='more-size'>>></span> Meu nome é <span class='color-green'>Luiz Ricardo F. Alves</span>, moro no estado de São Paulo, sou aspirante a <span class='color-green'>programador</span>. Possuo conhecimento com <span class='color-pink'>C#, Java(Android nativo), Dart(Flutter), Web(Html, Css, JavaScript, Jquery...)</span>, estou atualmente aprendendo <span class='color-pink'>Node.js e ASP.NET Core MVC<span id='detail_code'></span></span>";
            if(lang == 1)
                ViewBag.text_about_me = "<span class='more-size'>>></span> My name is <span class='color-green'>Luiz Ricardo F. Alves</span>, I live in state of São Paulo, I will be a <span class='color-green'>programmer</span>. I have knowledge with <span class='color-pink'>C#, Java(native Android), Dart(Flutter), Web(Html, Css, JavaScript, Jquery...)</span>, I'm currently learning <span class='color-pink'>Node.js and ASP.NET Core MVC<span id='detail_code'></span></span>";
            return View(database.PGetProjetos());
        }

        public IActionResult NovoProjeto(){
            if(IsLogged())
                return View();
            return Redirect("LogOff");
        }

        [HttpPost]
        public IActionResult NovoProjeto(Projeto p){
            if(IsLogged())
                database.PNewProjeto(p);
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult RemoveProjeto(int id){
            if(IsLogged())
                database.PRemoveProjeto(id);
            return Redirect("Index");
        }

        public IActionResult Portfolio(){
            ViewBag.logged = IsLogged();
            return View(database.PGetProjetos());
        }

        public IActionResult Curriculo(){
            ViewBag.logged = IsLogged();
            return View(database.PGetItemsCurriculo());
        }

        public IActionResult NovoItemCurriculo(){
            if(IsLogged())
                return View();
            return Redirect("Index");
        }
        
        [HttpPost]
        public IActionResult NovoItemCurriculo(ItemCurriculo item){
            if(IsLogged())
                database.PNewCurriculoItem(item);
            return Redirect("Curriculo");
        }

        [HttpGet]
        public IActionResult RemoverItemCurriculo(int id){
            if(IsLogged())
                database.PRemoveCurriculoItem(id);
            return Redirect("Curriculo");
        }

        [HttpGet]
        public IActionResult Blog(int page = 1){
            ViewBag.logged = IsLogged();
            ViewBag.nextPage = 0;
            if(database.PHasNextPage(page))
                ViewBag.nextPage = page + 1;
            ViewBag.previousPage = page - 1;
            return View(database.PGetPageBlog(page));
        }

        public IActionResult NovoPostBlog(){
            if(IsLogged())
                return View();
            return Redirect("Blog");
        }

        [HttpPost]
        public IActionResult NovoPostBlog(BlogItem b){
            if(IsLogged())
                database.PNewBlogItem(b);
            return Redirect("Blog");
        }

        [HttpGet]
        public IActionResult EditarBlogPost(int id){
            if(IsLogged())
                return View(database.PGetBlogItem(id));
            return Redirect("Blog");
        }

        [HttpPost]
        public IActionResult EditarBlogPost(BlogItem b){
            if(IsLogged())
                database.PUpdateItemBlog(b);
            return Redirect("Blog");
        }

        [HttpGet]
        public IActionResult RemovePostBlog(int id){
            if(IsLogged())
                database.PRemoveItemBlog(id);
            return Redirect("Blog");
        }

        [HttpGet]
        public IActionResult RemoverProjeto(int id){
            if(IsLogged())
                database.PRemoveProjeto(id);
            return Redirect("Portfolio");
        }
        
        public IActionResult Login(){
            if(IsLogged())
                return Redirect("Index");
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user=null){
            putLogin(user);
            if(IsLogged())
                return Redirect("Index");
            return View();
        }

        public IActionResult LogOff(){
            remLogin();
            return Redirect("Index");
        }

        private void putLogin(User user){
            HttpContext.Session.SetString("_Login", user.login);
            HttpContext.Session.SetString("_Senha", user.senha);
        }
        private void remLogin(){
            HttpContext.Session.Remove("_Login");
            HttpContext.Session.Remove("_Senha");
        }
        private bool IsLogged(){ return database.Login(HttpContext.Session.GetString("_Login"), HttpContext.Session.GetString("_Senha")); }

    }

}