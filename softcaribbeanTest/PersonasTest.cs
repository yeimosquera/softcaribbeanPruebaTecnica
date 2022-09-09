using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using softcaribbeanPruebaTecnica.Controllers;
using softcaribbeanPruebaTecnica.Data.Repositories;
using softcaribbeanPruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softcaribbeanTest
{
    [TestClass]
    public class PersonasTest
    {
        private Mock<IPersonaRepository> _personasRepositoryMock;
        private Fixture _fixture;

        public PersonasTest()
        {
            _fixture = new Fixture();
            _personasRepositoryMock = new Mock<IPersonaRepository>();

        }
      
        [TestMethod]//Validar que la funcion de PersonasController:ObtenerPersonas no tenga ninga calse de execiones de las respectivas validaciones
        public async Task ObtenerPersonas_ReturnError()
        {
            _personasRepositoryMock.Setup(repo => repo.GetAllPersonas()).Throws(new Exception());
            var _controller = new PersonasController(_personasRepositoryMock.Object);
            var result = await _controller.ObtenerPersonas();
            var obj = result as ObjectResult;
            Assert.AreEqual(400, obj.StatusCode);
        }

        [TestMethod]//Validar que la funcion de PersonasController:CrearPersona no tenga ninga calse de execiones de las respectivas validaciones
        public async Task CrearPersona_ReturnError()
        {
            var persona = _fixture.Create<Persona>();
            _personasRepositoryMock.Setup(repo => repo.InsertPersonas(It.IsAny<Persona>())).Throws(new Exception());
            var _controller = new PersonasController(_personasRepositoryMock.Object);
            var result = await _controller.CrearPersona(persona);
            var obj = result as ObjectResult;
            Assert.AreEqual(400, obj.StatusCode);
        }

        /* [TestMethod]
       public async Task ObtenerPersonas_ReturnOK()
       { 
            var personasList = _fixture.CreateMany<Persona>(3).ToList();
           _personasRepositoryMock.Setup(repo => repo.GetAllPersonas()).Returns(personasList);
           var _controller = new PersonasController(_personasRepositoryMock.Object);
           var result = await _controller.ObtenerPersonas();
           var obj = result as ObjectResult;
           Assert.AreEqual(200, obj.StatusCode);
       }*/


        /*[TestMethod]
        public async Task Post_CrearPersonaReturnOK()
        {
            var persona = _fixture.Create<Persona>();
             _personasRepositoryMock.Setup( repo => repo.InsertPersonas(It.IsAny<Persona>())).Returns(persona);
            var _controller = new PersonasController(_personasRepositoryMock.Object);
            var result = await _controller.CrearPersona(persona);
            var obj  = result as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);

        }*/


    }
}
