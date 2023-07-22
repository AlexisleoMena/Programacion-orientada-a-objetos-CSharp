class Eventos
{
    public static void imprimir()
    {
        Producto producto = new Producto("Teléfono móvil", 500);

        Comprador comprador1 = new Comprador("Juan");
        Comprador comprador2 = new Comprador("María");

        producto.PrecioCambiado += comprador1.EscucharPrecio;
        producto.PrecioCambiado += comprador2.EscucharPrecio;

        producto.Precio = 600; // El precio ha cambiado y se notificará a los compradores

        // Eliminamos a comprador1 de los observadores
        producto.PrecioCambiado -= comprador1.EscucharPrecio;

        producto.Precio = 550; // Solo comprador2 recibirá la notificación

        Console.ReadLine();
    }
    class Producto
    {
        public string Nombre { get; set; }
        private double precio;

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            this.precio = precio;
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (precio != value)
                {
                    precio = value;
                    OnPrecioCambiado();
                }
            }
        }

        public event EventHandler PrecioCambiado;

        protected virtual void OnPrecioCambiado()
        {
            PrecioCambiado?.Invoke(this, EventArgs.Empty);
        }
    }

    class Comprador
    {
        public string Nombre { get; }

        public Comprador(string nombre)
        {
            Nombre = nombre;
        }

        public void EscucharPrecio(object sender, EventArgs e)
        {
            Producto producto = (Producto)sender;
            Console.WriteLine($"{Nombre} ha sido notificado del cambio de precio. Nuevo precio del producto {producto.Nombre}: ${producto.Precio}");
        }
    }

}
