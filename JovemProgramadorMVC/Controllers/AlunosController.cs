using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunosRepositorio alunosRepositorio;
        public AlunosController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunosRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            _alunoRepositorio.InserAluno(
            return View();
        }


    }

}
