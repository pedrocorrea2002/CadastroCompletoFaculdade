using NUnit.Framework;
using Aula01DB.Model;
using System;
using System.Linq;
using Aula01DB.Model.Repositories;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Aula01DB.TesteAluno
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncluiAlunoRepository()
        {

            RepositoryAluno _Repository = new RepositoryAluno();

            Aluno oAluno = new Aluno();
            oAluno.Matricula = "2015003";
            oAluno.Nome = "João Ricardo";

            _Repository.IncluirAluno(oAluno);

            _Repository.Dispose();
        }

        [Test]
        public void AtualizarAlunoRepository()
        {
            RepositoryAluno _Repository = new RepositoryAluno();

            Aluno oAluno = new Aluno();
            oAluno.Matricula = "2015003";
            oAluno.Nome = "Godofredo da Silva";

            _Repository.AlterarAluno(oAluno, true);
            _Repository.Dispose();

            Assert.Pass();
        }

        [Test]
        public void ExcluirAlunoRepository()
        {
            RepositoryAluno _Repository = new RepositoryAluno();

            Aluno oAluno = new Aluno();
            oAluno.Matricula = "2015003";

            _Repository.ExcluirAluno(oAluno, true);
            _Repository.Dispose();

            Assert.Pass();
        }
    }
}