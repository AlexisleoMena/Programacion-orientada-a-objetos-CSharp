class Clases
{
    public static void imprimir()
    {
        Persona persona = new Persona();
        //persona._nombre = "Alexis"; // No hay acceso al miembro privado.
        //persona.setNombre("Alexis");
        //Console.WriteLine(persona.getNombre());
        persona.Nombre = "Alexis";
        Console.WriteLine(persona.Nombre);
        persona.Saludar();

    }

    class Persona
    {
        // Formas de declarar miembros (campos o propiedades).

        // Forma 1:
        //string _nombre; // Campo privado (por defecto).

        //public string getNombre()
        //{
        //    return _nombre;
        //}

        //public void setNombre(string nombre)
        //{
        //    _nombre = nombre;
        //}


        // Forma 2:
        //string _nombre;

        // Descriptores de acceso.
        //public string Nombre
        //{
        //    get { return _nombre; }
        //    set { _nombre = value; }
        //}


        //Forma 3:
        public string Nombre { get; set; } // Propiedad autoimplementada. El campo subyacente es generado automáticamente.


        public void Saludar()
        {
            Console.WriteLine($"Hola me llamo {Nombre}.");
        }
    }
}


