using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01DB.Model.Repositories
{
    public class RepositoryTurmaAluno : IDisposable
    {
        private bool disposedValue;

        private FaculdadeContext odb;

        public RepositoryTurmaAluno()
        {
            odb = new FaculdadeContext();
        }

        public void IncluirTurmaAluno(TurmaAluno oTurmaAluno)
        {
            odb.TurmaAluno.Add(oTurmaAluno);
            odb.SaveChanges();
        }

        public TurmaAluno Selecionar(int CodigoTurma)
        {
            return (from p in odb.TurmaAluno where p.CodigoTurma == CodigoTurma select p).FirstOrDefault();
        }

        public List<TurmaAluno> SelecionarTodos()
        {
            return (from p in odb.TurmaAluno select p).ToList();
        }

        //public List<TurmaAluno> SelecionarParteNome(string parteNome)
        //{
        //    return (from p in odb.TurmaAluno where p.Nome.Contains(parteNome) select p).ToList();
        //}

        //public List<TurmaAluno> IniciadoPor(string parteNome)
        //{
        //    return (from p in odb.TurmaAluno where p.Nome.StartsWith(parteNome) select p).ToList();
        //}

        //public List<TurmaAluno> TerminadoEm(string parteNome)
        //{
        //    return (from p in odb.TurmaAluno where p.Nome.EndsWith(parteNome) select p).ToList();
        //}

        public void AlterarTurmaAluno(TurmaAluno oTurmaAluno, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oTurmaAluno);
            }

            odb.Entry(oTurmaAluno).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirTurmaAluno(TurmaAluno oTurmaAluno, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oTurmaAluno);
            }

            odb.Entry(oTurmaAluno).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RepositorioEmpregado()
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
