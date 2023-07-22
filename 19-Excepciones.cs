class Excepciones
{
    public static void imprimir()
    {
        try
        {
            ValidarNumero(10); // Imprime: "El número es válido: 10"
            ValidarNumero(-5); // Lanza MiExcepcion con el mensaje "El número no puede ser negativo"
        }
        catch (MiExcepcion ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static void ValidarNumero(int numero)
    {
        if (numero < 0)
        {
            throw new MiExcepcion("El número no puede ser negativo");
        }
        else
        {
            Console.WriteLine("El número es válido: " + numero);
        }
    }

    class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje) : base(mensaje)
        {
        }
    }
}
