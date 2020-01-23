namespace Comando.Entidad
{
    public class Personaje
    {
        public Personaje()
        {
            lPlasma = false;
            lGranada = false;
        }
        public string cNombre { get; set; }

        public int iFuerza { get; set; }

        public bool lGranada { get; set; }

        public bool lPlasma { get; set; }
    }
}
