
//namespace myNameSpaceA // Los namespaces son útiles para organizar y estructurar el código 
//{
class Modificadores_de_acceso // internal por defecto.
{
    public static void imprimir()
    {
        Persona personaA = new Persona("Alexis", 22, "alex@gmail.com", "Algún lugar.");

        personaA.Nombre = "Alexis";
        //personaA.Edad = 22;
        //personaA.Correo = "alexisleo@gmail.com";
        personaA.Direccion = "El mas acá.";

        personaA.Saludar();
    }


    class Persona // private por defecto.
    {
        public string Nombre { get; set; } // Puede ser accedido desde cualquier lugar
        private int Edad { get; set; } // Solo puede ser accedido desde la misma clase
        protected string Correo { get; set; } // Puede ser accedido desde la misma clase y sus subclases
        internal string Direccion { get; set; } // Puede ser accedido desde el mismo ensamblado

        public Persona(string nombre, int edad, string correo, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Correo = correo;
            Direccion = direccion;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, me llamo {Nombre}.\nTengo {Edad} años.\nMi correo es {Correo}.\nMi direccion es {Direccion}");
        }
    }
}


//}


