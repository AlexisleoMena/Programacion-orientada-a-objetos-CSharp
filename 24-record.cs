class Record
{
    public static void imprimir()
    {
        Persona persona = new Persona("Alexisleo", 25);
        Console.WriteLine(persona.Saludar());

        Libro libro = new Libro { Titulo = "C# en Acci�n", Autor = "John Doe" };
        Console.WriteLine($"T�tulo: {libro.Titulo}, Autor: {libro.Autor}");

    }
    public record Persona(string Nombre, int Edad)
    {
        public string Saludar() => $"Hola, mi nombre es {Nombre} y tengo {Edad} a�os.";
    }

    public record Libro
    {
        public string Titulo { get; init; } // Propiedad inicial: solo se puede establecer al crear el objeto
        public string Autor { get; init; } // Propiedad inicial: solo se puede establecer al crear el objeto
    }
}
