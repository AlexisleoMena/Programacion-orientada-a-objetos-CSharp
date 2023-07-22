class Polimorfismo_dinamico
{
    public static void imprimir()
    {

        //Triangulo triangulo = new Triangulo(5, 3);
        //Circulo circulo = new Circulo(4);

        //triangulo.CalcularArea();
        //Console.WriteLine(triangulo.Altura);

        //circulo.CalcularArea();
        //Console.WriteLine(circulo.Radio);


        Figura figura1 = new Triangulo(5, 3);
        Figura figura2 = new Circulo(4);

        figura1.CalcularArea();
        Console.WriteLine(((Triangulo)figura1).Altura);

        figura2.CalcularArea();
        Console.WriteLine(((Circulo)figura2).Radio);

    }

    class Figura
    {
        public virtual void CalcularArea() // "virtual" indica que el método CalcularArea puede ser redefinido en tiempo de ejecución por clases que lo hereden.
        {
            Console.WriteLine("Área de figura desconocida.");
        }
    }

    class Triangulo : Figura
    {
        public double BaseTriangulo { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double altura)
        {
            BaseTriangulo = baseTriangulo;
            Altura = altura;
        }

        public override void CalcularArea() // "override" indica que el método va a reemplazar la implementación del método en la clase base.
        {
            double area = (BaseTriangulo * Altura) / 2;
            Console.WriteLine("Área del triángulo: " + area);
        }
    }

    class Circulo : Figura
    {
        public double Radio { get; private set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override void CalcularArea()
        {
            double area = Math.PI * Radio * Radio;
            Console.WriteLine("Área del círculo: " + area);
        }
    }
}
