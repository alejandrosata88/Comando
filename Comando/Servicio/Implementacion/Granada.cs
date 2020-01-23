using Comando.Entidad;
using Comando.Servicio.Interfaz;

namespace Comando.Servicio.Implementacion
{
    class Granada : IComando
    {
        public string RealizarAccion(Personaje _Personaje)
        {
            string cMensaje = string.Empty;
            if (_Personaje.lGranada)
                cMensaje=string.Format("\n{0} lanza granada con fuerza de {1}...\n", _Personaje.cNombre, _Personaje.iFuerza);
            else
                cMensaje = string.Format("\n{0} obtiene granada...\n", _Personaje.cNombre);
            _Personaje.lGranada = !_Personaje.lGranada;
            return cMensaje;
        }
    }
}
