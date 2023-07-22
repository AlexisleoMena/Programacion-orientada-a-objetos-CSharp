using System;
using System.IO;
using System.Text;

class Entrada_y_salida_de_archivos_binarios
{
    public static void imprimir()
    {
        // Obtener la ruta completa del archivo binario
        string rutaArchivoBinario = "C:\\Users\\alexisleo\\Escritorio\\Programacion-orientada-a-objetos-CSharp\\mi_archivo.bin";

        // Verificar si el archivo binario existe
        if (!File.Exists(rutaArchivoBinario))
        {
            // Crear el archivo binario si no existe
            using (FileStream archivoBinario = new FileStream(rutaArchivoBinario, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritorBinario = new BinaryWriter(archivoBinario))
                {
                    escritorBinario.Write("Hola, archivo binario!");
                    escritorBinario.Write(42);
                }
            }
        }

        // Leer contenido binario del archivo
        byte[] contenidoBinario;
        using (FileStream archivoBinario = new FileStream(rutaArchivoBinario, FileMode.Open, FileAccess.Read))
        {
            using (BinaryReader lectorBinario = new BinaryReader(archivoBinario))
            {
                contenidoBinario = lectorBinario.ReadBytes((int)archivoBinario.Length);
            }
        }

        // Mostrar el contenido binario del archivo antes del reemplazo
        Console.WriteLine("Contenido binario del archivo antes del reemplazo:");
        Console.WriteLine(Encoding.ASCII.GetString(contenidoBinario));

        // Búsqueda y edición de información en el archivo binario
        byte[] palabraBuscada = Encoding.ASCII.GetBytes("archivo");
        byte[] palabraReemplazo = Encoding.ASCII.GetBytes("cambio");

        for (int i = 0; i < contenidoBinario.Length - palabraBuscada.Length; i++)
        {
            bool encontrado = true;
            for (int j = 0; j < palabraBuscada.Length; j++)
            {
                if (contenidoBinario[i + j] != palabraBuscada[j])
                {
                    encontrado = false;
                    break;
                }
            }

            if (encontrado)
            {
                Array.Copy(palabraReemplazo, 0, contenidoBinario, i, palabraReemplazo.Length);
                break;
            }
        }

        // Sobreescribir el archivo binario con el contenido modificado
        using (FileStream archivoBinario = new FileStream(rutaArchivoBinario, FileMode.Create, FileAccess.Write))
        {
            using (BinaryWriter escritorBinario = new BinaryWriter(archivoBinario))
            {
                escritorBinario.Write(contenidoBinario);
            }
        }

        // Leer contenido binario del archivo después del reemplazo
        byte[] contenidoBinarioModificado;
        using (FileStream archivoBinario = new FileStream(rutaArchivoBinario, FileMode.Open, FileAccess.Read))
        {
            using (BinaryReader lectorBinario = new BinaryReader(archivoBinario))
            {
                contenidoBinarioModificado = lectorBinario.ReadBytes((int)archivoBinario.Length);
            }
        }

        // Mostrar el contenido binario del archivo después del reemplazo
        Console.WriteLine("Contenido binario del archivo después del reemplazo:");
        Console.WriteLine(Encoding.ASCII.GetString(contenidoBinarioModificado));
    }
}
