using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppPersonDemo.Services;
using WebAppPersonDemo.Models;
using WebAppPersonDemo.Controllers;
using Moq; 

namespace WebAppPersonDemoTest
{
    [TestClass]
    public class HomeTest
    {
        [TestMethod]
        public void CrearPersona_ObjetoPersonaAsignaMensaje()
        {
            //Arrancar
            Persona persona = new Persona();

            var mockServicioPersona = new Mock<IServicioPersona>(); //al trabajar con los  Moq tengo que implementar todos los metodos de la interfaz
            mockServicioPersona.Setup(sp => sp.EsValido(persona)).Returns(false); //para usar el metodo EsValido
            mockServicioPersona.Setup(e => e.Errores).Returns(new List<string>() { "Error" });

            HomeController homeController = new HomeController(mockServicioPersona.Object);

            //Actuar
            var result = homeController.CrearPersona(persona);

            //Asegurar
            Assert.IsNotNull(result);
        }
    }
}
