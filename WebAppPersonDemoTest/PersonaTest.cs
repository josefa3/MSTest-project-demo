using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppPersonDemo.Services;
using WebAppPersonDemo.Models;

namespace WebAppPersonDemoTest
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void ValidarModelo_EdadEsMayorQue18_RetornarVerdadero()
        {
            //Arrancar
            var persona = new Persona();
            persona.Edad = 19;

            //Actuar
            bool resultado = persona.Validar(); //aca da error porq dicho metodo no existe aun en la clase Persona. Click al bombillito para que genere el metodo validar automaticamente en Persona

            //Asegurar
            Assert.IsTrue(resultado);
        }
    }
}
