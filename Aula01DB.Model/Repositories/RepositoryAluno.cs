using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01DB.Model.Repositories
{
    public class RepositoryAluno : IDisposable
    {
        private bool disposedValue;

        private FaculdadeContext odb;
        private bool recebeuContexto = false;

        public RepositoryAluno(FaculdadeContext _odb)
        {
            odb = _odb;
            recebeuContexto = true;
        }

        public RepositoryAluno()
        {
            odb = new FaculdadeContext();
        }

        public void IncluirAluno(Aluno oAluno)
        {
            odb.Aluno.Add(oAluno);
            odb.SaveChanges();
        }

        public Aluno SelecionarAluno(string Matricula)
        {
            return (from p in odb.Aluno where p.Matricula == Matricula select p).FirstOrDefault();
        }

        public List<Aluno> SelecionarTodosAlunos()
        {
            return (from p in odb.Aluno select p).ToList();
        }

        public List<Aluno> SelecionarParteNomeAluno(string parteNome)
        {
            return (from p in odb.Aluno where p.Nome.Contains(parteNome) select p).ToList();
        }

        public List<Aluno> AlunoIniciadoPor(string parteNome)
        {
            return (from p in odb.Aluno where p.Nome.StartsWith(parteNome) select p).ToList();
        }

        public List<Aluno> AlunoTerminadoEm(string parteNome)
        {
            return (from p in odb.Aluno where p.Nome.EndsWith(parteNome) select p).ToList();
        }

        public void AlterarAluno(Aluno oAluno, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oAluno);
            }

            odb.Entry(oAluno).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirAluno(Aluno oAluno, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oAluno);
            }

            odb.Entry(oAluno).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
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
