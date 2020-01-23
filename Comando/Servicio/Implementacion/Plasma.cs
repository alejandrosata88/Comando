using Comando.Entidad;
using Comando.Servicio.Interfaz;

namespace Comando.Servicio.Implementacion
{
    class Plasma : IComando
    {
        public string RealizarAccion(Personaje _Personaje)
        {
            string cMensaje = string.Empty;
            if (_Personaje.lPlasma)
                cMensaje = string.Format("\n{0} dispara plasma con fuerza de {1}...\n", _Personaje.cNombre, _Personaje.iFuerza);
            else
                cMensaje = string.Format("\n{0} obtiene plasma...\n", _Personaje.cNombre);
            _Personaje.lPlasma = !_Personaje.lPlasma;
            return cMensaje;
        }
    }
}
