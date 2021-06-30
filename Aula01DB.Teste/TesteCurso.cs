using NUnit.Framework;
using Aula01DB.Model;
using System;
using System.Linq;
using Aula01DB.Model.Repositories;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Aula01DB.TesteCurso
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncluiCursoRepository()
        {

            RepositoryCurso _Repository = new RepositoryCurso();

            Curso oCurso = new Curso();
            oCurso.Nome = "Tecnologia da Informação";

            _Repository.IncluirCurso(oCurso);

            _Repository.Dispose();
        }

        [Test]
        public void AtualizarCursoRepository()
        {
            RepositoryCurso _Repository = new RepositoryCurso();

            Curso oCurso = new Curso();
            oCurso.CodigoCurso = 2;
            oCurso.Nome = "Sistema de Informações";

            _Repository.AlterarCurso(oCurso, true);
            _Repository.Dispose();

            Assert.Pass();
        }

        [Test]
        public void ExcluirCursoRepository()
        {
            RepositoryCurso _Repository = new RepositoryCurso();

            Curso oCurso = new Curso();
            oCurso.CodigoCurso = 2;

            _Repository.ExcluirCurso(oCurso, true);
            _Repository.Dispose();

            Assert.Pass();
        }
    }
}