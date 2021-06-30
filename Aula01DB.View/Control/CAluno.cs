using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;
using Aula01DB.Model.Repositories;

namespace Aula01DB.View.Control
{
    class CAluno : IDisposable
    {
        private bool disposedValue;

        private RepositoryAluno _Repository;

        public List<Aluno> TodosAlunos()
        {
            return _Repository.SelecionarTodosAlunos();
        }

        public void Incluir(Aluno oAluno)
        {
            _Repository.IncluirAluno(oAluno);
        }

        public void Alterar(Aluno oAluno)
        {
            _Repository.AlterarAluno(oAluno);
        }

        public void Excluir(Aluno oAluno)
        {
            _Repository.ExcluirAluno(oAluno);
        }

        public Aluno SelecionarAluno(string Matricula)
        {
            return _Repository.SelecionarAluno(Matricula);
        }

        public CAluno()
        {
            _Repository = new RepositoryAluno();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
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