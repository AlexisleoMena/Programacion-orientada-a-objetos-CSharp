class Partial
{
    public static void imprimir()
    {
        Persona persona = new Persona { Nombre = "Juan", Edad = 30 };
        Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
    }

    public partial class Persona
    {
        public string? Nombre { get; set; }
    }
    public partial class Persona
    {
        public int Edad { get; set; }
    }
}
