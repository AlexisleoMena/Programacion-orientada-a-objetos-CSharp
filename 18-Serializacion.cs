using Newtonsoft.Json;
using System.IO;
using System.Text;

class Serializacion
{
    public static void imprimir()
    {
        // Ruta del archivo
        string rutaArchivo = "C:\\Users\\alexisleo\\Escritorio\\Programacion-orientada-a-objetos-CSharp\\persona.json";

        // Serialización de un objeto Persona a JSON
        Persona persona = new Persona { Nombre = "Alexisleo", Edad = 30 };
        string json = JsonConvert.SerializeObject(persona);

        // Crear el archivo (si no existe) y escribir en él
        using (FileStream fs = File.Create(rutaArchivo))
        {
            byte[] info = new UTF8Encoding(true).GetBytes(json);
            fs.Write(info, 0, info.Length);
        }

        // Deserialización del archivo JSON a un objeto Persona
        string jsonDeserializado;
        using (StreamReader archivo = new StreamReader(rutaArchivo))
        {
            jsonDeserializado = archivo.ReadToEnd();
        }

        Persona personaDeserializada = JsonConvert.DeserializeObject<Persona>(jsonDeserializado);

        // Imprimir la información de la persona deserializada
        Console.WriteLine($"Nombre: {personaDeserializada.Nombre}, Edad: {personaDeserializada.Edad}");
    }

    class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
    }
}
