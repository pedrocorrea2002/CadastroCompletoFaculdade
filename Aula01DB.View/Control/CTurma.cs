using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;
using Aula01DB.Model.Repositories;

namespace Aula01DB.View.Control
{
    public class CTurma : IDisposable
    {
        private bool disposedValue;

        private RepositoryCurso _RepositoryCurso;
        private RepositoryAluno _RepositoryAluno;
        private RepositoryTurma _RepositoryTurma;


        public CTurma()
        {
            _RepositoryCurso = new RepositoryCurso();

            _RepositoryAluno = new RepositoryAluno(_RepositoryCurso.MyContext);
            _RepositoryTurma = new RepositoryTurma(_RepositoryCurso.MyContext);
        }


        private RepositoryTurma _Repository;

        //public List<Turma> TodosTurmas()
        //{
        //    return _Repository.SelecionarTodos();
        //}


        public List<Curso> SelecionarTodosCursos()
        {
            return _RepositoryCurso.SelecionarTodosCursos();
        }

        public List<Aluno> SelecionarTodosAlunos()
        {
            return _RepositoryAluno.SelecionarTodosAlunos();
        }

        public List<VwTurmaAluno> SelecionarAlunosTurma(int CodigoTurma)
        {
            return _RepositoryTurma.SelecionarAlunosTurma(CodigoTurma);
        }

        public DateTime DataHora()
        {
            return _RepositoryCurso.DataHora();
        }

        public Turma IncluirTurma(Turma oTurma)
        {
            return _RepositoryTurma.IncluirTurma(oTurma);
        }

        public void IncluirAlunoTurma(TurmaAluno oTurmaAluno)
        {
            _RepositoryTurma.IncluirAlunoTurma(oTurmaAluno);
        }

        public void RemoverAlunoTurma(TurmaAluno oTurmaAluno)
        {
            _RepositoryTurma.RemoverAlunoTurma(oTurmaAluno);
        }


        public void Alterar(Turma oTurma)
        {
            _Repository.AlterarTurma(oTurma);
        }

        public void Excluir(Turma oTurma)
        {
            _Repository.ExcluirTurma(oTurma);
        }

        public Turma SelecionarTurma(int CodigoTurma)
        {
            return _RepositoryTurma.Selecionar(CodigoTurma);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _RepositoryCurso.Dispose();
                    _Repository.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~CControl()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
