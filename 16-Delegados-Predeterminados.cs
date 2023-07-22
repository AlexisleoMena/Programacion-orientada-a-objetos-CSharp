class Delegados_predeterminados
{
    public static void imprimir()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        // Action: Imprime todos los números
        Action imprimirNumeros = () =>
        {
            Console.WriteLine("Números:");
            foreach (var num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        };
        imprimirNumeros();

        // Func: Suma todos los números
        Func<int, int, int> sumar = (a, b) => a + b;
        int sumaTotal = numeros.Aggregate(sumar);
        Console.WriteLine("Suma total: " + sumaTotal);

        // Predicate: Verifica si algún número es par
        Predicate<int> esPar = num => num % 2 == 0;
        bool hayNumerosPares = numeros.Exists(esPar);
        Console.WriteLine("¿Hay números pares? " + (hayNumerosPares ? "Sí" : "No"));

        // Func con varias sobrecargas: Obtener el número mayor
        Func<int, int, int> obtenerMayor = (a, b) => a > b ? a : b;
        int numeroMayor = numeros.Aggregate(obtenerMayor);
        Console.WriteLine("Número mayor: " + numeroMayor);

        // Action<T>: Imprimir el cuadrado de cada número
        Action<int> imprimirCuadrado = num => Console.Write(num * num + " ");
        numeros.ForEach(imprimirCuadrado);
        Console.WriteLine();

        // Func<T, TResult>: Convertir los números a strings
        Func<int, string> convertirAString = num => num.ToString();
        List<string> numerosComoStrings = numeros.Select(convertirAString).ToList();
        Console.WriteLine("Números como strings: " + string.Join(", ", numerosComoStrings));

        // Action<T1, T2>: Imprimir la suma de dos números
        Action<int, int> imprimirSuma = (a, b) =>
            Console.WriteLine($"La suma de {a} y {b} es {a + b}");
        imprimirSuma(3, 7);

        // Func<T1, T2, TResult>: Calcular la resta de dos números
        Func<int, int, int> restar = (a, b) => a - b;
        int resta = restar(10, 4);
        Console.WriteLine("Resta: " + resta);

        // Func con 16 parámetros: Calcular la suma de 16 números
        Func< int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> sumar16 = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p;
        int suma16 = sumar16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        Console.WriteLine("Suma de 16 números: " + suma16);
    }
}
