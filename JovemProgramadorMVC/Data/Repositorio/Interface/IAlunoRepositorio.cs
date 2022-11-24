using JovemProgramadorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        void InserirAluno(AlunoModel alunos);
        void EditarAluno(AlunoModel aluno);
        List<AlunoModel> BuscarAlunos();
        AlunoModel BuscarId(int id);
        void ExcluirAluno(AlunoModel aluno);

    }
}
