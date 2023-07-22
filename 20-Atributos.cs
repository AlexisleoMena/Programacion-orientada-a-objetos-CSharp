using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Atributos
{
    [DllImport("user32.dll")]
    private static extern int MessageBox(int hWnd, string text, string caption, uint type);

    [Conditional("DEBUG")]
    static void MetodoCondicional()
    {
        Console.WriteLine("Este método solo se ejecutará en modo DEBUG.");
    }

    [Conditional("RELEASE")]
    static void MetodoCondicionalRelease()
    {
        Console.WriteLine("Este método solo se ejecutará en modo RELEASE.");
    }

    public static void imprimir()
    {
        Persona persona = new Persona { Nombre = "María", Edad = 30 };

        Console.WriteLine("Nombre: " + persona.Nombre); // Imprime: "Nombre: María"
        Console.WriteLine("Edad: " + persona.Edad); // Imprime: "Edad: 30"

        persona.MetodoObsoleto(); // Imprime: "Este es un método obsoleto."

        MetodoCondicional(); // Imprime solo en modo DEBUG
        MetodoCondicionalRelease(); // Imprime solo en modo RELEASE

        MessageBox(0, "Mensaje de prueba", "Título", 0); // Llama a la función de la API de Windows
    }

    [Serializable]
    class Persona
    {
        [DefaultValue("Juan")]
        public string? Nombre { get; set; }

        public int Edad { get; set; }

        [Obsolete("Este método está obsoleto. Utilice otro método en su lugar.")]
        public void MetodoObsoleto()
        {
            Console.WriteLine("Este es un método obsoleto.");
        }
    }
}
