
class Herencia
{
    public static void imprimir()
    {
        Coche miCoche = new Coche("Toyota", "Corolla", 2022, 4);
        miCoche.Arrancar();
        miCoche.Acelerar();
        Console.WriteLine($"Coche: {miCoche.Marca} {miCoche.Modelo} - A�o: {miCoche.Anio} - Puertas: {miCoche.Puertas}");

        Console.WriteLine();

        Moto miMoto = new Moto("Honda", "CBR", 2021, true);
        miMoto.Arrancar();
        miMoto.Girar();
        Console.WriteLine($"Moto: {miMoto.Marca} {miMoto.Modelo} - A�o: {miMoto.Anio} - Manillar: {miMoto.Manillar}");
    }

    class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public void Arrancar()
        {
            Console.WriteLine("El veh�culo est� arrancando...");
        }
    }

    class Coche : Vehiculo
    {
        public int Puertas { get; set; }

        // Por convenci�n, los argumentos de la clase padre van al principio. "base" permite inicializar las propiedades de la clase padre, ya que estas no son accesibles directamente.
        public Coche(string marca, string modelo, int anio, int puertas) : base(marca, modelo, anio)
        {
            Puertas = puertas;
        }

        public void Acelerar()
        {
            Console.WriteLine("El coche est� acelerando...");
        }
    }

    class Moto : Vehiculo
    {
        public bool Manillar { get; set; }

        public Moto(string marca, string modelo, int anio, bool manillar) : base(marca, modelo, anio)
        {
            Manillar = manillar;
        }

        public void Girar()
        {
            Console.WriteLine("La moto est� girando...");
        }
    }
}

