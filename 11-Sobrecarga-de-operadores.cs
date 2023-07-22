class Sobrecarga_de_operadores
{
    public static void imprimir()
    {
        NumeroComplejo num1 = new NumeroComplejo(3, 2);
        NumeroComplejo num2 = new NumeroComplejo(1, 4);

        NumeroComplejo suma = num1 + num2;
        Console.WriteLine($"Suma: {suma}");

        NumeroComplejo resta = num1 - num2;
        Console.WriteLine($"Resta: {resta}");

        NumeroComplejo multiplicacion = num1 * num2;
        Console.WriteLine($"Multiplicación: {multiplicacion}");
    }

    class NumeroComplejo
    {
        public double Real { get; set; }
        public double Imaginario { get; set; }

        public NumeroComplejo(double real, double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }

        // Sobrecarga del operador de suma (+)
        public static NumeroComplejo operator +(NumeroComplejo num1, NumeroComplejo num2)
        {
            return new NumeroComplejo(num1.Real + num2.Real, num1.Imaginario + num2.Imaginario);
        }

        // Sobrecarga del operador de resta (-)
        public static NumeroComplejo operator -(NumeroComplejo num1, NumeroComplejo num2)
        {
            return new NumeroComplejo(num1.Real - num2.Real, num1.Imaginario - num2.Imaginario);
        }

        // Sobrecarga del operador de multiplicación (*)
        public static NumeroComplejo operator *(NumeroComplejo num1, NumeroComplejo num2)
        {
            double realPart = (num1.Real * num2.Real) - (num1.Imaginario * num2.Imaginario);
            double imagPart = (num1.Real * num2.Imaginario) + (num1.Imaginario * num2.Real);
            return new NumeroComplejo(realPart, imagPart);
        }

        public override string ToString()
        {
            string signo = Imaginario < 0 ? "-" : "+";
            double absImaginario = Math.Abs(Imaginario);
            return $"{Real} {signo} {absImaginario}i";
        }
    }
}
