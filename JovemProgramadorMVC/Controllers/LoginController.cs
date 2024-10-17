using Azure.Core;
using Azure.Messaging;
using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JovemProgramadorMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buscar(Usuario usuario)
        {
            var verificar = _usuarioRepositorio.BuscarUsuario(usuario);
            if (verificar)
            {
                return RedirectToAction("index", "Home");
            }
            else
            {
                return RedirectToAction("index");
            }

        }

    }
}
