using Comando.Servicio;
using Comando.Servicio.Implementacion;
using Comando.Entidad;
using System;

namespace Comando.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            Personaje Personaje = new Personaje();
            string cValorIngreso = string.Empty,cValorAccion=string.Empty,cMensaje=string.Empty;
            int iValor = 0;
            Invocador Invocador = new Invocador();
            
            Console.WriteLine("Seleccione el nombre de su personaje");
            cValorIngreso = Console.ReadLine();
            Personaje.cNombre = cValorIngreso;

            Console.WriteLine("\nSeleccione su personaje\n1)Gerrero clase Baja\n2)Guerrero clase media\n3)Guerrero clase alta");
            cValorIngreso = Console.ReadLine();        
            switch (cValorIngreso)
            {
                case "1":
                    iValor = 10;
                    break;
                case "2":
                    iValor = 20;
                    break;
                case "3":
                    iValor = 30;
                    break;
                default:
                    iValor = 1;
                    break;
            }
            Personaje.iFuerza = iValor;

            Console.WriteLine("\nSeleccione su acción\n1)Caminar\n2)Saltar\n3)Golpear\n4)Disparar\n5)Conseguir Granadas\n6)Conseguir pistola de plasma");
            while (cValorIngreso!="x")
            {
                cValorAccion = Console.ReadLine();
                switch(cValorAccion)
                {
                    case ("1"):
                        Invocador.EjecutarAccion(new Caminar());
                        break;
                    case ("2"):
                        Invocador.EjecutarAccion(new Saltar());
                        break;
                    case ("3"):
                        Invocador.EjecutarAccion(new Golpear());
                        break;
                    case ("4"):
                        Invocador.EjecutarAccion(new Disparar());
                        break;
                    case ("5"):
                        {
                            Invocador.EjecutarAccion(new Granada());
                            //Personaje.lGranada = !Personaje.lGranada;
                        }
                        break;
                    case ("6"):
                        {
                            Invocador.EjecutarAccion(new Plasma());
                            //Personaje.lPlasma = !Personaje.lPlasma;
                        }
                        break;
                    default:
                            break;
                }
                cMensaje=Invocador.RealizarAcciones(Personaje);
                Console.WriteLine(cMensaje);
            }
        }
    }
}
