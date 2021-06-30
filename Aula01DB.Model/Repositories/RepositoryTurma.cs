using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01DB.Model.Repositories
{
    public class RepositoryTurma : IDisposable
    {
        private bool disposedValue;

        private FaculdadeContext odb;
        private bool recebeuContexto = false;

        public RepositoryTurma(FaculdadeContext _odb)
        {
            odb = _odb;
            recebeuContexto = true;
        }

        public RepositoryTurma()
        {
            odb = new FaculdadeContext();
        }

        public Turma IncluirTurma(Turma oTurma)
        {
            odb.Turma.Add(oTurma);
            try
            {
                odb.SaveChanges();
            }
            catch(Exception ex)
            {
                odb.Turma.Remove(oTurma);
                throw ex;
            }

            return oTurma;
        }

        public void IncluirAlunoTurma(TurmaAluno oTurmaAluno)
        {
            try
            {
                odb.TurmaAluno.Add(oTurmaAluno);
                odb.SaveChanges();
            }
            catch(Exception ex)
            {
                odb.TurmaAluno.Remove(oTurmaAluno);
                throw ex;
            }
        }

        public void RemoverAlunoTurma(TurmaAluno oTurmaAluno)
        {
            try
            {
                odb.Entry(oTurmaAluno).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                odb.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Turma Selecionar(int CodigoTurma)
        {
            return (from p in odb.Turma where p.CodigoTurma == CodigoTurma select p).FirstOrDefault();
        }

        public List<Turma> SelecionarTodos()
        {
            return (from p in odb.Turma select p).ToList();
        }

        //public List<Turma> SelecionarParteNome(string parteNome)
        //{
        //    return (from p in odb.Turma where p.Nome.Contains(parteNome) select p).ToList();
        //}

        //public List<Turma> IniciadoPor(string parteNome)
        //{
        //    return (from p in odb.Turma where p.Nome.StartsWith(parteNome) select p).ToList();
        //}

        //public List<Turma> TerminadoEm(string parteNome)
        //{
        //    return (from p in odb.Turma where p.Nome.EndsWith(parteNome) select p).ToList();
        //}

        public void AlterarTurma(Turma oTurma, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oTurma);
            }

            odb.Entry(oTurma).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirTurma(Turma oTurma, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oTurma);
            }

            odb.Entry(oTurma).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
        }

        public List<VwTurmaAluno> SelecionarAlunosTurma(int CodigoTurma)
        {
            return (from p in odb.VwTurmaAluno where p.CodigoTurma == CodigoTurma select p).ToList();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (!recebeuContexto) odb.Dispose();
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
