using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppPersonDemo.Models;
using WebAppPersonDemo.Services;

namespace WebAppPersonDemoTest
{
    [TestClass]
    public class ServicioPersonaTest //ctor de mi clase de pruebas unitarias
    {
        private ServicioPersona _servicio; //indico que mi atributo es de tipo ServicioPersona

        [TestInitialize]
        public void Inicializar()
        {
            _servicio = new ServicioPersona(); //Inyencion de dependencias???
        }

        [TestMethod]
        public void EsValido_PersonaConNombreVacioEsInvalido() //nombre del metodo _ nombre de lo que quiero probar
        {
            //Arrancar
            var persona = new Persona() { Nombre = String.Empty }; //para probar al objeto Persona, debo forzar lo que quiero probar

            //Actuar
            var resultado = _servicio.EsValido(persona);

            //Asegurar
            Assert.IsFalse(resultado); //Probar y asegurar que en efecto lo que quiero probar es verdadero, es decir q es invalido el nombre vacio        }
        }

        [TestMethod]
        public void EsValido_PersonaConEdadMayorQue200EsInvalido()
        {
            //Arrancar
            var persona = new Persona() { Nombre = "Alexandra", Edad = 201 };

            //Actuar
            var resultado = _servicio.EsValido(persona);

            //Asegurar
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsValido_PersonaConEdadMenorQueCeroEsInvalido()
        {
            //Arrancar
            var persona = new Persona() { Nombre = "Felipe", Edad = -3 };

            //Actuar
            var resultado = _servicio.EsValido(persona); //Ejecuto el metodo y le paso el objeto instanciado para en el siguiente paso probar si da falso

            //Asegurar
            Assert.IsFalse(resultado); //aca indico la expectativa, que es que sea falso que persona con edad -3 es valido... Parece una reduccion al absurdo.
        }

    }
}

