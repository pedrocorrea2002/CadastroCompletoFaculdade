using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;
using Aula01DB.Model.Repositories;

namespace Aula01DB.View.Control
{
    class CTurmaAluno : IDisposable
    {
        private bool disposedValue;

        private RepositoryTurmaAluno _Repository;

        public List<TurmaAluno> TodosTurmaAlunos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Incluir(TurmaAluno oTurmaAluno)
        {
            _Repository.IncluirTurmaAluno(oTurmaAluno);
        }

        public void Alterar(TurmaAluno oTurmaAluno)
        {
            _Repository.AlterarTurmaAluno(oTurmaAluno);
        }

        public void Excluir(TurmaAluno oTurmaAluno)
        {
            _Repository.ExcluirTurmaAluno(oTurmaAluno);
        }

        public CTurmaAluno()
        {
            _Repository = new RepositoryTurmaAluno();
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
