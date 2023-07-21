class Constructores
{
    public static void Imprimir()
    {
        Persona personaA = new Persona();
        personaA.Nombre = "Alexis";
        Console.WriteLine(personaA.Nombre);
        personaA.Saludar();

        Persona personaB = new Persona("Alexis");
        Console.WriteLine(personaB.Nombre);
        personaB.Nombre = "Kevin";
        personaB.Saludar();
    }

    class Persona
    {
        //public string? Nombre { get; set; } // 'string?' indica que, al momento de instanciar la clase, la propiedad puede ser un string o null (propiedad nullable).

        //// Constructor por defecto. Est� presente de forma impl�cita, pero si se sobrecarga y se desea instanciar una clase sin par�metros, se debe declarar expl�citamente.
        //public Persona()
        //{
        //    //Nombre = string.Empty; // Declarar la propiedad como un string vac�o evita advertencias en caso de que la propiedad no sea nullable.
        //}

        public string Nombre { get; set; } = string.Empty;
        public Persona() { } // Puede ser privado (Ej. Si se quiere implementar el patr�n de dise�o Singleton).



        public Persona(string nombre) 
        {
            Nombre = nombre;
        }



        public void Saludar()
        {
            Console.WriteLine($"Hola, me llamo {Nombre}.");
        }
    }
}
