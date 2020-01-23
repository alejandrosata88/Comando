using Comando.Entidad;
using Comando.Servicio.Interfaz;

namespace Comando.Servicio
{
    public class Invocador
    {
        private IComando _iCaminar;

        public void EjecutarAccion(IComando _IComando)
        {
            _iCaminar = _IComando;
        }

        public string RealizarAcciones(Personaje _Personaje)
        {
            string cMensaje = string.Empty;
            if (this._iCaminar is IComando)
            {
                cMensaje+=this._iCaminar.RealizarAccion(_Personaje);
            }

            cMensaje +=("\nSeleccione su acción\n1)Caminar\n2)Saltar\n3)Golpear\n4)Disparar");
            if(_Personaje.lGranada)
                cMensaje += ("\n5)Disparar Granadas");
            else
                cMensaje += ("\n5)Conseguir Granadas");
            if (_Personaje.lPlasma)
                cMensaje += ("\n6)Disparar pistola de plasma");
            else
                cMensaje += ("\n6)Conseguir pistola de plasma");
            cMensaje += "\n";
            return cMensaje;
        }
    }
}
