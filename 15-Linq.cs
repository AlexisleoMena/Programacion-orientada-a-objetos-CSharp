class Linq
{
    public static void imprimir()
    {
        // Crear una lista de personas
        List<Persona> personas = new List<Persona>
        {
            new Persona(1, "Juan", 30),
            new Persona(2, "María", 25),
            new Persona(3, "Pedro", 40),
            new Persona(4, "Ana", 28),
            new Persona(5, "Lucía", 35)
        };

        // Mostrar todas las personas en la lista
        Console.WriteLine("Lista de personas:");
        foreach (var persona in personas)
        {
            Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }

        // Obtener la cantidad total de personas en la lista
        int cantidadPersonas = personas.Count();
        Console.WriteLine($"\nCantidad total de personas: {cantidadPersonas}");

        // Obtener la edad promedio de las personas en la lista
        double edadPromedio = personas.Average(p => p.Edad);
        Console.WriteLine($"Edad promedio de las personas: {edadPromedio}");

        // Obtener la persona más joven
        var personaMasJoven = personas.OrderBy(p => p.Edad).First();
        Console.WriteLine(
            $"\nPersona más joven: ID: {personaMasJoven.Id}, Nombre: {personaMasJoven.Nombre}, Edad: {personaMasJoven.Edad}"
        );

        // Obtener la persona más vieja
        var personaMasVieja = personas.OrderByDescending(p => p.Edad).First();
        Console.WriteLine(
            $"\nPersona más vieja: ID: {personaMasVieja.Id}, Nombre: {personaMasVieja.Nombre}, Edad: {personaMasVieja.Edad}"
        );

        // Filtrar personas mayores de 30 años
        var personasMayoresDeTreinta = personas.Where(p => p.Edad > 30).ToList();
        Console.WriteLine("\nPersonas mayores de 30 años:");
        foreach (var persona in personasMayoresDeTreinta)
        {
            Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }

        // Buscar una persona específica por nombre
        string nombreBuscar = "María";
        var personaEncontrada = personas.FirstOrDefault(p => p.Nombre == nombreBuscar);
        if (personaEncontrada != null)
        {
            Console.WriteLine(
                $"\nPersona encontrada - ID: {personaEncontrada.Id}, Nombre: {personaEncontrada.Nombre}, Edad: {personaEncontrada.Edad}"
            );
        }
        else
        {
            Console.WriteLine($"\nNo se encontró una persona con el nombre {nombreBuscar}");
        }
    }

    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(int id, string nombre, int edad)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
        }
    }
}
