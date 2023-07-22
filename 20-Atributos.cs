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
        Console.WriteLine("Este m�todo solo se ejecutar� en modo DEBUG.");
    }

    [Conditional("RELEASE")]
    static void MetodoCondicionalRelease()
    {
        Console.WriteLine("Este m�todo solo se ejecutar� en modo RELEASE.");
    }

    public static void imprimir()
    {
        Persona persona = new Persona { Nombre = "Mar�a", Edad = 30 };

        Console.WriteLine("Nombre: " + persona.Nombre); // Imprime: "Nombre: Mar�a"
        Console.WriteLine("Edad: " + persona.Edad); // Imprime: "Edad: 30"

        persona.MetodoObsoleto(); // Imprime: "Este es un m�todo obsoleto."

        MetodoCondicional(); // Imprime solo en modo DEBUG
        MetodoCondicionalRelease(); // Imprime solo en modo RELEASE

        MessageBox(0, "Mensaje de prueba", "T�tulo", 0); // Llama a la funci�n de la API de Windows
    }

    [Serializable]
    class Persona
    {
        [DefaultValue("Juan")]
        public string? Nombre { get; set; }

        public int Edad { get; set; }

        [Obsolete("Este m�todo est� obsoleto. Utilice otro m�todo en su lugar.")]
        public void MetodoObsoleto()
        {
            Console.WriteLine("Este es un m�todo obsoleto.");
        }
    }
}
