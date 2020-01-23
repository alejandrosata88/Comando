using Comando.Entidad;
using Comando.Servicio.Interfaz;

namespace Comando.Servicio.Implementacion
{
    class Caminar : IComando
    {
        public string RealizarAccion(Personaje _Personaje)
        {
            return string.Format("\n{0} camina con velociad de {1}...\n", _Personaje.cNombre, _Personaje.iFuerza);
        }
    }
}
