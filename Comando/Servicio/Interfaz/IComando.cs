using Comando.Entidad;

namespace Comando.Servicio.Interfaz
{
    public interface IComando
    {
        string RealizarAccion(Personaje _Personaje);
    }
}
