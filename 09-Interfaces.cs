class Interfaces
{
    public static void imprimir()
    {
        Auto miAuto = new Auto();
        miAuto.Encender();
        miAuto.Reproducir();

        miAuto.Apagar();
        miAuto.Detener();
    }

    interface IVehiculo
    {
        void Encender();
        void Apagar();
    }

    interface IRadio
    {
        void Reproducir();
        void Detener();
    }

    class Auto : IVehiculo, IRadio // La herencia m�ltiple de clases (es decir, heredar de m�ltiples clases base) no es permitida en C#, pero la herencia m�ltiple de interfaces si.
    {
        public void Encender()
        {
            Console.WriteLine("El auto est� encendido.");
        }

        public void Apagar()
        {
            Console.WriteLine("El auto est� apagado.");
        }

        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo la radio.");
        }

        public void Detener()
        {
            Console.WriteLine("Radio detenida.");
        }
    }
}

