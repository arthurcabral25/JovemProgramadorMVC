﻿using JovemProgramadorMVC.Data.Repositorio;
using JovemProgramadorMVC.Data.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
    }
}
