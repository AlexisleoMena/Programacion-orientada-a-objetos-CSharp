class Clases_abstractas
{
    public static void imprimir()
    {

        Automovil automovil = new Automovil("Toyota", "Corolla", 3);
        automovil.Puertas = 4;
        automovil.MostrarInformacion();

        // Al darle el tipo Vehiculo a una instancia de Automovil, es posible tratar esa instancia como un Vehiculo, y a la vez es posible seguir accediendo a propiedades y métodos específicos de Automovil cuando sea necesario.
        Vehiculo vehiculo1 = new Automovil("Toyota", "Hilux", 3);
        ((Automovil)vehiculo1).Puertas = 2; // Casteo para acceder a la propiedad Puertas.
        vehiculo1.MostrarInformacion();


        Vehiculo vehiculo2 = new Motocicleta("Honda", "CBR600RR", "NaN");
        ((Motocicleta)vehiculo2).Tipo = "Deportiva";
        vehiculo2.MostrarInformacion();

        Vehiculo[] vehiculos = { new Automovil("Toyota", "Etios", 3), new Motocicleta("Yamaha", "YBR", "Deportiva")};
        vehiculos[0].MostrarInformacion();
        vehiculos[1].MostrarInformacion();

        ((Automovil)vehiculos[0]).Puertas = 4;

    }

    abstract class Vehiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void MostrarInformacion(); // Método abstracto: No posee implementación, pero las clases que hereden de su clase contenedora deberán implementarlo.
    }

    class Automovil : Vehiculo
    {
        public int Puertas { get; set; }

        public Automovil(string marca, string modelo, int puertas) : base(marca, modelo)
        {
            Puertas = puertas;
        }

        public override void MostrarInformacion() // "override" indica que el método va a proporcionar la implementación del método MostrarInformacion en la clase base.
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Puertas: {Puertas}");
        }
    }

    class Motocicleta : Vehiculo
    {
        public string? Tipo { get; set; }

        public Motocicleta(string marca, string modelo, string tipo) : base(marca, modelo)
        {
            Tipo = tipo;
        }   

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Tipo: {Tipo}");
        }
    }
}

