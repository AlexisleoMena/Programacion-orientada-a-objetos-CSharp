
class Metodos_estaticos 
{
    public static void imprimir()
    {
        //Utilidades utilidades = new Utilidades(); // No se puede instanciar.

        Utilidades.Saludar("Alexis");

        DateTime fechaNacimiento = new DateTime(1999, 5, 15);
        int miEdad = Utilidades.CalcularEdad(fechaNacimiento);
        Console.WriteLine($"Tienes {miEdad} años.");
    }


    static class Utilidades // Clase estatica; No se puede instanciar. Todos sus metodos son estaticos. No posee constructores.
    {
        public static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}!");
        }

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.Month < fechaNacimiento.Month || (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }
    }
}

