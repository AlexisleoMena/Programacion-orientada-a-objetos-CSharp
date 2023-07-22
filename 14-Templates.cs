class Templates
{
    public static void imprimir()
    {
        MiLista<int> listaEnteros = new MiLista<int>();
        listaEnteros.Agregar(5);
        listaEnteros.Agregar(10);
        listaEnteros.Agregar(15);

        MiLista<string> listaStrings = new MiLista<string>();
        listaStrings.Agregar("Hola");
        listaStrings.Agregar("Mundo");
        listaStrings.Agregar("!");

        listaEnteros.MostrarElementos();
        listaStrings.MostrarElementos();



        MiDiccionario<int, string> diccionarioEnteroString = new MiDiccionario<int, string>();
        diccionarioEnteroString.Agregar(1, "Uno");
        diccionarioEnteroString.Agregar(2, "Dos");
        diccionarioEnteroString.Agregar(3, "Tres");

        MiDiccionario<string, double> diccionarioStringDouble = new MiDiccionario<string, double>();
        diccionarioStringDouble.Agregar("Pi", 3.1416);
        diccionarioStringDouble.Agregar("Raíz cuadrada de 2", 1.4142);

        diccionarioEnteroString.MostrarElementos();
        diccionarioStringDouble.MostrarElementos();
    }

    class MiLista<T>
    {
        private T[] elementos = new T[5];
        private int contador = 0;

        public void Agregar(T elemento)
        {
            elementos[contador] = elemento;
            contador++;
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Elementos en la lista:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }

    class MiDiccionario<T, U>
    {
        private T[] claves = new T[5];
        private U[] valores = new U[5];
        private int contador = 0;

        public void Agregar(T clave, U valor)
        {
            claves[contador] = clave;
            valores[contador] = valor;
            contador++;
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Elementos en el diccionario:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Clave: {claves[i]}, Valor: {valores[i]}");
            }
        }
    }

}
