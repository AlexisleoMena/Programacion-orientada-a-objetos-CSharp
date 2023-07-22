class Indexadores
{
    public static void imprimir()
    {
        Diccionario diccionario = new Diccionario();

        diccionario["hola"] = "Saludo amistoso";
        diccionario["adios"] = "Despedida";
        diccionario["gato"] = "Animal doméstico";

        Console.WriteLine(diccionario["hola"]); 
        Console.WriteLine(diccionario["adios"]); 
        Console.WriteLine(diccionario["gato"]); 
        Console.WriteLine(diccionario["perro"]); 
    }

    class Diccionario
    {
        private string[] palabras = new string[10];
        private string[] significados = new string[10];

        public string this[string palabra]
        {
            get
            {
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i] == palabra)
                    {
                        return significados[i];
                    }
                }

                return null;
            }
            set
            {
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i] == palabra)
                    {
                        significados[i] = value;
                        return;
                    }
                }

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i] == null)
                    {
                        palabras[i] = palabra;
                        significados[i] = value;
                        return;
                    }
                }

                throw new IndexOutOfRangeException("El diccionario está lleno.");
            }
        }
    }
}
