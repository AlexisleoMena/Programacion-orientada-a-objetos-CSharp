class Excepciones
{
    public static void imprimir()
    {
        try
        {
            ValidarNumero(10); // Imprime: "El n�mero es v�lido: 10"
            ValidarNumero(-5); // Lanza MiExcepcion con el mensaje "El n�mero no puede ser negativo"
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
            throw new MiExcepcion("El n�mero no puede ser negativo");
        }
        else
        {
            Console.WriteLine("El n�mero es v�lido: " + numero);
        }
    }

    class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje) : base(mensaje)
        {
        }
    }
}
