using introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Jackson",
                Tipo = "Dev pleno"
            };

            
            //ViewData
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            
            //ViewBag
            var pessoa2 = new Pessoa()
            {
                PessoaId = 2,
                Nome = "Jonas",
                Tipo = "Fisio"
            };

            ViewBag.Id = pessoa2.PessoaId;
            ViewBag.Nome = pessoa2.Nome;
            ViewBag.Tipo = pessoa2.Tipo;
            
            //View Tipada
            return View(pessoa);
        }

        /*
           public String Teste()
           {
               return "Teste Jackson";
               //https://localhost:44330/Home/Teste
           }
        */

        public ActionResult Contatos()
        {
            return View();
        }
    }
}