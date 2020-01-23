using Comando.Entidad;
using Comando.Servicio.Interfaz;
using System;

namespace Comando.Servicio.Implementacion
{
    class Golpear : IComando
    {
        public string RealizarAccion(Personaje _Personaje)
        {
            return string.Format("\n{0} golpea con poder de {1}...\n", _Personaje.cNombre, _Personaje.iFuerza);
        }
    }
}
