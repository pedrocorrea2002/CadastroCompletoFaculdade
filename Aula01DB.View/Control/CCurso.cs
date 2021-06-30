﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;
using Aula01DB.Model.Repositories;

namespace Aula01DB.View.Control
{
    class CCurso : IDisposable
    {
        private bool disposedValue;

        private RepositoryCurso _Repository;

        public List<Curso> TodosCursos()
        {
            return _Repository.SelecionarTodosCursos();
        }

        public void Incluir(Curso oCurso)
        {
            _Repository.IncluirCurso(oCurso);
        }

        public void Alterar(Curso oCurso)
        {
            _Repository.AlterarCurso(oCurso);
        }

        public void Excluir(Curso oCurso)
        {
            _Repository.ExcluirCurso(oCurso);
        }

        public CCurso()
        {
            _Repository = new RepositoryCurso();
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
