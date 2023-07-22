using System.Reflection;

class Reflection
{
    public static void imprimir()
    {
        Persona persona = new Persona { Nombre = "Alexisleo", Edad = 30 }; // Inicializador de objeto 

        // Obtener el tipo de la clase Persona
        Type tipo = typeof(Persona);

        // Obtener propiedades p�blicas de la clase Persona
        PropertyInfo[] propiedades = tipo.GetProperties();
        foreach (PropertyInfo propiedad in propiedades)
        {
            Console.WriteLine(propiedad.Name); // Imprime: "Nombre", "Edad"
        }

        // Obtener m�todos p�blicos de la clase Persona
        MethodInfo[] metodos = tipo.GetMethods();
        foreach (MethodInfo metodo in metodos)
        {
            Console.WriteLine(metodo.Name); // Imprime: "Saludar", "ToString", "Equals", "GetHashCode", "GetType"
        }

        // Invocar el m�todo Saludar utilizando reflexi�n
        MethodInfo metodoSaludar = tipo.GetMethod("Saludar");
        metodoSaludar.Invoke(persona, null); // Imprime: "Hola, mi nombre es Alexisleo y tengo 30 a�os."
    }

    class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} a�os.");
        }
    }
}
