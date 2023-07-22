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

    class Auto : IVehiculo, IRadio // La herencia múltiple de clases (es decir, heredar de múltiples clases base) no es permitida en C#, pero la herencia múltiple de interfaces si.
    {
        public void Encender()
        {
            Console.WriteLine("El auto está encendido.");
        }

        public void Apagar()
        {
            Console.WriteLine("El auto está apagado.");
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

