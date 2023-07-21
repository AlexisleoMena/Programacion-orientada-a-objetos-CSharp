class Composicion
{
    public static void imprimir()
    {
        Bicicleta miBicicleta = new Bicicleta(26, 24);
        miBicicleta.Pedalear();
        miBicicleta.Frenar();
        miBicicleta.GirarManubrio();

        Console.WriteLine("Rodado de la rueda delantera: " + miBicicleta.ObtenerRodadoDelantera());
        Console.WriteLine("Rodado de la rueda trasera: " + miBicicleta.ObtenerRodadoTrasera());

    }

    class Rueda
    {
        public int Rodado { get; set; }

        public Rueda(int rodado) 
        {
            Rodado = rodado;
        }

        public void Girar()
        {
            Console.WriteLine("La rueda está girando.");
        }
    }

    class Manubrio
    {
        public void Girar()
        {
            Console.WriteLine("El manubrio está girando.");
        }
    }

    class Bicicleta
    {
        private Rueda ruedaDelantera;
        private Rueda ruedaTrasera;
        private Manubrio manubrio;

        public Bicicleta(int rodadoDelantera, int rodadoTrasera)
        {
            ruedaDelantera = new Rueda(rodadoDelantera);
            ruedaTrasera = new Rueda(rodadoTrasera);
            manubrio = new Manubrio();
        }

        public void Pedalear()
        {
            Console.WriteLine("La bicicleta está avanzando.");
        }

        public void Frenar()
        {
            Console.WriteLine("La bicicleta está frenando.");
        }

        public void GirarManubrio()
        {
            manubrio.Girar();
        }

        public int ObtenerRodadoDelantera()
        {
            return ruedaDelantera.Rodado;
        }

        public int ObtenerRodadoTrasera()
        {
            return ruedaTrasera.Rodado;
        }
    }

}

