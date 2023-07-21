
using System.Xml.Linq;

class Sobrecarga_de_metodos
{
    public static void imprimir()
    {
        Calculadora calc = new Calculadora();

        /* 
            En tiempo de compilaci�n, el compilador realiza el proceso de "resoluci�n de sobrecarga", donde eval�a qu� m�todo 
            invocar seg�n los argumentos proporcionados, teniendo en cuenta la cantidad, tipo y orden de los par�metros, es decir, 
            la firma del m�todo.
        */
        int resultado1 = calc.Sumar(5, 3); 
        int resultado2 = calc.Sumar(2, 4, 6); 
        double resultado3 = calc.Sumar(2.5, 3.7);

        Console.WriteLine($"Resultado 1: {resultado1}");
        Console.WriteLine($"Resultado 2: {resultado2}");
        Console.WriteLine($"Resultado 3: {resultado3}");
    }

    class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }
    }

}

