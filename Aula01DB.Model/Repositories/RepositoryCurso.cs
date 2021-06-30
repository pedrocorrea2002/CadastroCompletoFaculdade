using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01DB.Model.Repositories
{
    public class RepositoryCurso : IDisposable
    {
        private bool disposedValue;

        private FaculdadeContext odb;

        public FaculdadeContext MyContext
        {
            get
            { return odb; }
        }


        public DateTime DataHora()
        {
            return (from p in odb.VwPegahora select p).FirstOrDefault().Datahora;
        }


        public RepositoryCurso()
        {
            odb = new FaculdadeContext();
        }

        public void IncluirCurso(Curso oCurso)
        {
            odb.Curso.Add(oCurso);
            odb.SaveChanges();
        }

        public Curso Selecionar(int CodigoCurso)
        {
            return (from p in odb.Curso where p.CodigoCurso == CodigoCurso select p).FirstOrDefault();
        }

        public List<Curso> SelecionarTodosCursos()
        {
            return (from p in odb.Curso select p).ToList();
        }

        public List<Curso> SelecionarParteNomeCurso(string parteNome)
        {
            return (from p in odb.Curso where p.Nome.Contains(parteNome) select p).ToList();
        }

        public List<Curso> CursoIniciadoPor(string parteNome)
        {
            return (from p in odb.Curso where p.Nome.StartsWith(parteNome) select p).ToList();
        }

        public List<Curso> CursoTerminadoEm(string parteNome)
        {
            return (from p in odb.Curso where p.Nome.EndsWith(parteNome) select p).ToList();
        }

        public void AlterarCurso(Curso oCurso, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oCurso);
            }

            odb.Entry(oCurso).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirCurso(Curso oCurso, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oCurso);
            }

            odb.Entry(oCurso).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
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
