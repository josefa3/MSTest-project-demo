using WebAppPersonDemo.Models;

namespace WebAppPersonDemo.Services
{
    public interface IServicioPersona
    {
        bool EsValido(Persona persona);
        List<string> Errores { get; set; }
    }
}
