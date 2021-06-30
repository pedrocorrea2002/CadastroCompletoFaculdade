using NUnit.Framework;
using Aula01DB.Model;
using System;
using System.Linq;
using Aula01DB.Model.Repositories;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Aula01DB.TesteTurma
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncluiTurmaRepository()
        {

            RepositoryTurma _Repository = new RepositoryTurma();

            Turma oTurma = new Turma();
            oTurma.CodigoCurso = 11;
            oTurma.Ano = 2018;

            _Repository.IncluirTurma(oTurma);

            _Repository.Dispose();
        }

        [Test]
        public void AtualizarTurmaRepository()
        {
            RepositoryTurma _Repository = new RepositoryTurma();

            Turma oTurma = new Turma();
            oTurma.CodigoTurma = 1;
            oTurma.CodigoCurso = 11;
            oTurma.Semestre = 2;
            oTurma.Ano = 2021;

            _Repository.AlterarTurma(oTurma, true);
            _Repository.Dispose();

            Assert.Pass();
        }

        [Test]
        public void ExcluirTurmaRepository()
        {
            RepositoryTurma _Repository = new RepositoryTurma();

            Turma oTurma = new Turma();
            oTurma.CodigoTurma = 1;

            _Repository.ExcluirTurma(oTurma, true);
            _Repository.Dispose();

            Assert.Pass();
        }
    }
}