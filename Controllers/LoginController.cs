using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Contexts;
using Bibliotec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bibliotec_mvc.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();

        [Route("[Logar]")]
        public IActionResult Logar(IFormCollection form)
        {

            string emailinformado = form["Email"];
            string senhainformado = form["Senha"];

            Usuario usuarioBuscado = context.Usuario.FirstOrDefault(usuario => usuario.Email == emailinformado && usuario.Senha == senhainformado)!;

            // List<Usuario> listaUsuario = context.Usuario.ToList();
            // foreach(Usuario usuario_ in listaUsuario){
            //     if (usuario_.Email == emailinformado && usuario_.Senha == senhainformado){
            //     } else {

            //     }

            // }
            if (usuarioBuscado == null)
            {
                Console.WriteLine($"dados invalidos!");
                return LocalRedirect("~/Login");
            }
            else
            {
                Console.WriteLine($"Bem vindo mlk!");
                return LocalRedirect("~/Livro");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}