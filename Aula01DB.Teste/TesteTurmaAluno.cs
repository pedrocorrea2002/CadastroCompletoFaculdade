using NUnit.Framework;
using Aula01DB.Model;
using System;
using System.Linq;
using Aula01DB.Model.Repositories;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Aula01DB.TesteTurmaAluno
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncluiTurmaAlunoRepository()
        {

            RepositoryTurmaAluno _Repository = new RepositoryTurmaAluno();

            TurmaAluno oTurmaAluno = new TurmaAluno();
            oTurmaAluno.CodigoTurma = 1;
            oTurmaAluno.MatriculaAluno = "Tecnologia da Informação";
            oTurmaAluno.DataEntrada = DateTime.Parse("28-02-2021");

            _Repository.IncluirTurmaAluno(oTurmaAluno);

            _Repository.Dispose();
        }

        [Test]
        public void AtualizarTurmaAlunoRepository()
        {
            RepositoryTurmaAluno _Repository = new RepositoryTurmaAluno();

            TurmaAluno oTurmaAluno = new TurmaAluno();
            oTurmaAluno.CodigoTurma = 1;
            oTurmaAluno.MatriculaAluno = "2015000";

            _Repository.AlterarTurmaAluno(oTurmaAluno, true);
            _Repository.Dispose();

            Assert.Pass();
        }

        [Test]
        public void ExcluirTurmaAlunoRepository()
        {
            RepositoryTurmaAluno _Repository = new RepositoryTurmaAluno();

            TurmaAluno oTurmaAluno = new TurmaAluno();
            oTurmaAluno.MatriculaAluno = "20182000";

            _Repository.ExcluirTurmaAluno(oTurmaAluno, true);
            _Repository.Dispose();

            Assert.Pass();
        }
    }
}