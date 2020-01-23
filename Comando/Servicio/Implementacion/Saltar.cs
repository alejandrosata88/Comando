using Comando.Entidad;
using Comando.Servicio.Interfaz;

namespace Comando.Servicio.Implementacion
{
    class Saltar : IComando
    {
        public string RealizarAccion(Personaje _Personaje)
        {
            return string.Format("\n{0} salta con poder de {1}...\n", _Personaje.cNombre, _Personaje.iFuerza);
        }
    }
}
