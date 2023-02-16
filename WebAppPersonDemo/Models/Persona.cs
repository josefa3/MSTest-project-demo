namespace WebAppPersonDemo.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public bool Validar() //Aparecio!!!
        {
            //hay que escribir lo que hace el metodo
            if(Edad < 18)
            {
                return false;
            }
            return true;
        }
    }
}
