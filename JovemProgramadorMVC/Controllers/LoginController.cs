using JovemProgramadorMVC.Data.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public LoginController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
