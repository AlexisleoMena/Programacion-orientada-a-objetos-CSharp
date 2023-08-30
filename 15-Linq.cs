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

        // Obtener personas únicas por edad
        var edadesUnicas = personas.Select(p => p.Edad).Distinct();
        Console.WriteLine("\nEdades únicas:");
        foreach (var edad in edadesUnicas)
        {
            Console.WriteLine($"Edad única: {edad}");
        }

        // Proyectar solo los nombres de las personas
        var nombresDePersonas = personas.Select(p => p.Nombre);
        Console.WriteLine("\nNombres de personas:");
        foreach (var nombre in nombresDePersonas)
        {
            Console.WriteLine($"Nombre: {nombre}");
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

        // Mostrar personas de la segunda a la cuarta
        var personasSkipTake = personas.Skip(1).Take(3);
        Console.WriteLine("\nPersonas desde la segunda hasta la cuarta:");
        foreach (var persona in personasSkipTake)
        {
            Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }

        // Verificar si hay alguna persona con edad mayor a 40
        bool hayPersonasMayoresA40 = personas.Any(p => p.Edad > 40);
        Console.WriteLine($"\n¿Hay personas mayores a 40? {hayPersonasMayoresA40}");

        // Verificar si todas las personas tienen edad mayor a 20
        bool todasPersonasMayoresA20 = personas.All(p => p.Edad > 20);
        Console.WriteLine($"\n¿Todas las personas tienen más de 20 años? {todasPersonasMayoresA20}");


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
