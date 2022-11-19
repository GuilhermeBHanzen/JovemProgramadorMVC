using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly IConfiguration _configurarion;
        public AlunosController(IAlunoRepositorio alunoRepositorio, IConfiguration configuration)
        {
            _alunoRepositorio = alunoRepositorio;
            _configurarion = configuration;
        }

        public IActionResult Index()
        {
            var alunos = _alunoRepositorio.BuscarAlunos();
            return View(alunos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult InserirAluno(AlunoModel alunos)
        {
            _alunoRepositorio.InserirAluno(alunos);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var aluno = _alunoRepositorio.BuscarId(id);
            return View(aluno);
        }

        
        
        


    }

}
