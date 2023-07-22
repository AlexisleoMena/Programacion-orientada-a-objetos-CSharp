using System;
using System.IO;

class Entrada_y_salida_de_textos
{
    public static void imprimir()
    {
        // Salida de texto en la consola
        Console.WriteLine("Hola, mundo!");

        // Obtener la ruta completa del archivo
        string rutaArchivo = "C:\\Users\\alexisleo\\Escritorio\\Programacion-orientada-a-objetos-CSharp\\mi_archivo.txt";

        // Verificar si el archivo existe
        if (!File.Exists(rutaArchivo))
        {
            // Crear el archivo si no existe
            using (StreamWriter archivo = File.CreateText(rutaArchivo))
            {
                archivo.WriteLine("Hola, archivo!");
                archivo.WriteLine("Esto es un ejemplo");
                archivo.WriteLine("de escritura en archivo");
            }
        }

        // Leer contenido del archivo
        string contenido = File.ReadAllText(rutaArchivo);

        // Mostrar el contenido del archivo antes del reemplazo
        Console.WriteLine("Contenido del archivo antes del reemplazo:");
        Console.WriteLine(contenido);

        // Búsqueda y edición de una palabra
        string palabraBuscada = "Hola";
        string palabraReemplazo = "Hi";

        // Realizar el reemplazo
        contenido = contenido.Replace(palabraBuscada, palabraReemplazo);

        // Sobreescribir el archivo con el contenido modificado
        File.WriteAllText(rutaArchivo, contenido);

        // Mostrar el contenido del archivo después del reemplazo
        Console.WriteLine("Contenido del archivo después del reemplazo:");
        Console.WriteLine(contenido);
    }
}
