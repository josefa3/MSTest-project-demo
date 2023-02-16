using WebAppPersonDemo.Models;

namespace WebAppPersonDemo.Services
{
    public class ServicioPersona
    {
        public List<string> Errores { get; set; }
        
        public bool EsValido(Persona persona)
        {
            Errores = new List<string>();

            var valido = true;

            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                Errores.Add("el nombre de la persona tiene que ser un valor requerido");
                //valido = false;
            }
            
            if(persona.Edad > 200)
            {
                //valido = false;
                Errores.Add("La Edad de la persona no puede ser mayor que 200");
            }

            if(persona.Edad < 0)
            {
                Errores.Add("La edad de la persona no puede ser menor de cero");

                //despues del primer Test para mostrar cuando tiene un error como aparece en la ventada de test
                //valido = false;
            }

            //return valido;
            return !Errores.Any();
        }
    }
}
