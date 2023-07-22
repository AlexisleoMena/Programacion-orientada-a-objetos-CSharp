## Programación Orientada a Objetos en C#

**01-Clases.cs**

Las clases en C# son plantillas o moldes para crear objetos. Definen propiedades y métodos que caracterizan el comportamiento y las características de los objetos que se instancian a partir de ellas.

Ejemplo:

```csharp
  class Persona {
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Métodos
    public void Saludar() {
      Console.WriteLine("Hola, mi nombre es " + Nombre + " y tengo " + Edad + " años.");
    }
  }

  // Creación de un objeto de la clase Persona
  Persona persona1 = new Persona();
  persona1.Nombre = "Juan";
  persona1.Edad = 30;
  persona1.Saludar(); // Imprime: "Hola, mi nombre es Juan y tengo 30 años."
```

**02-Constructores.cs**

Los constructores en C# son métodos especiales que se utilizan para inicializar objetos cuando se crean. Pueden aceptar parámetros para configurar propiedades o realizar tareas de inicialización.

Ejemplo:

```csharp
  class Persona {
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Persona(string nombre, int edad) {
      Nombre = nombre;
      Edad = edad;
    }
  }

  // Creación de un objeto de la clase Persona utilizando el constructor
  Persona persona1 = new Persona("Juan", 30);
```

**03-Modificadores-de-Acceso.cs**

Los modificadores de acceso en C# determinan la visibilidad y accesibilidad de los miembros (propiedades y métodos) de una clase. Los principales modificadores de acceso son: `public`, `private`, `protected` e `internal`.

Ejemplo:

```csharp
  class Persona {
    public string Nombre { get; set; } // Puede ser accedido desde cualquier lugar
    private int Edad { get; set; } // Solo puede ser accedido desde la misma clase
    protected string Correo { get; set; } // Puede ser accedido desde la misma clase y sus subclases
    internal string Direccion { get; set; } // Puede ser accedido desde el mismo ensamblado
  }
```

**04-Metodos-Estaticos.cs**

Los métodos estáticos en C# pertenecen a la clase en lugar de una instancia específica. Se invocan a través del nombre de la clase y no requieren que se cree un objeto para ser utilizados.

Ejemplo:

```csharp
  class Calculadora {
    public static int Sumar(int a, int b) {
      return a + b;
    }
  }

  int resultado = Calculadora.Sumar(5, 3); // resultado = 8
```

**05-Sobrecarga-de-Metodos.cs**

La sobrecarga de métodos (o polimorfismo estático) en C# permite definir varios métodos con el mismo nombre pero con diferentes parámetros. El compilador seleccionará automáticamente el método adecuado en función del número y tipo de argumentos pasados.

Ejemplo:

```csharp
  class Calculadora {
    public int Sumar(int a, int b) {
      return a + b;
    }

    public double Sumar(double a, double b) {
      return a + b;
    }
  }

  Calculadora calc = new Calculadora();
  int resultado1 = calc.Sumar(5, 3); // resultado1 = 8
  double resultado2 = calc.Sumar(2.5, 3.7); // resultado2 = 6.2
```

**06-Herencia.cs**

La herencia en C# permite que una clase (clase derivada o subclase) herede las características y comportamientos de otra clase (clase base o superclase). La subclase puede extender o modificar el comportamiento de la superclase y agregar nuevos métodos o propiedades.

Ejemplo:

```csharp
  class Animal {
    public string Nombre { get; set; }

    public void EmitirSonido() {
      Console.WriteLine("Sonido de animal");
    }
  }

  class Perro : Animal {
    public void Ladra() {
      Console.WriteLine("Guau guau");
    }
  }

  Perro miPerro = new Perro();
  miPerro.Nombre = "Firulais";
  miPerro.EmitirSonido(); // Imprime: "Sonido de animal"
  miPerro.Ladra(); // Imprime: "Guau guau"
```

**07-Composicion.cs**

La composición es una técnica en la que una clase contiene instancias de otras clases (componentes) en lugar de heredar de ellas directamente. Esto permite reutilizar funcionalidades combinando objetos de otras clases en la clase actual.

Ejemplo:

```csharp
  class Motor {
    public void Encender() {
      Console.WriteLine("Motor encendido.");
    }

    public void Apagar() {
      Console.WriteLine("Motor apagado.");
    }
  }

  class Automovil {
    private Motor motor = new Motor();

    public void EncenderAuto() {
      motor.Encender();
      Console.WriteLine("Automóvil encendido.");
    }

    public void ApagarAuto() {
      motor.Apagar();
      Console.WriteLine("Automóvil apagado.");
    }
  }

  class Program {
    static void Main() {
      Automovil miAuto = new Automovil();
      miAuto.EncenderAuto();
      miAuto.ApagarAuto();
    }
  }

```

**08-Clases-abstractas.cs**

Una clase abstracta en C# es una clase que no se puede instanciar directamente y que generalmente se utiliza como una clase base para otras clases concretas. Suele utilizarse con métodos abstractos, los cuales no tienen implementación en la clase abstracta y deben ser implementado en las clases derivadas que hereden de ella.

Ejemplo:

```csharp
  abstract class Figura {
    public abstract double CalcularArea();
  }

  class Circulo : Figura {
    private double radio;

    public Circulo(double radio) {
      this.radio = radio;
    }

    public override double CalcularArea() {
      return Math.PI * radio * radio;
    }
  }

  class Cuadrado : Figura {
    private double lado;

    public Cuadrado(double lado) {
      this.lado = lado;
    }

    public override double CalcularArea() {
      return lado * lado;
    }
  }

  class Program {
    static void Main() {
      Figura figura1 = new Circulo(5);
      Figura figura2 = new Cuadrado(4);

      Console.WriteLine("Área del círculo: " + figura1.CalcularArea());
      Console.WriteLine("Área del cuadrado: " + figura2.CalcularArea());
    }
  }

```

**09-Interfaces.cs**

Las interfaces en C# son una colección de métodos y propiedades que definen un conjunto de comportamientos que una clase puede implementar. Una clase puede implementar múltiples interfaces.

Ejemplo:

```csharp
  interface IReproductorMusica {
    void Play();
    void Pause();
    void Stop();
  }

  class ReproductorMP3 : IReproductorMusica {
    public void Play() {
      Console.WriteLine("Reproduciendo música");
    }

    public void Pause() {
      Console.WriteLine("Pausa en la reproducción");
    }

    public void Stop() {
      Console.WriteLine("Reproducción detenida");
    }
  }

  ReproductorMP3 reproductor = new ReproductorMP3();
  reproductor.Play(); // Imprime: "Reproduciendo música"
```

**10-Polimorfismo-dinamico.cs**

El polimorfismo dinámico en C# se refiere al comportamiento en tiempo de ejecución de las clases derivadas que reemplazan los métodos de la clase base. Esto permite que un objeto de la clase base se comporte de acuerdo con su implementación en la clase derivada.

Ejemplo:

```csharp
  class Animal {
    public virtual void Sonido() {
      Console.WriteLine("Sonido de animal");
    }
  }

  class Perro : Animal {
    public override void Sonido() {
      Console.WriteLine("Guau guau");
    }
  }

  class Gato : Animal {
    public override void Sonido() {
      Console.WriteLine("Miau miau");
    }
  }

  class Program {
    static void Main() {
      Animal animal1 = new Perro();
      Animal animal2 = new Gato();

      animal1.Sonido(); // Imprime: "Guau guau"
      animal2.Sonido(); // Imprime: "Miau miau"
    }
  }

```

**11-Sobrecarga-de-operadores.cs**

La sobrecarga de operadores en C# permite definir comportamientos personalizados para operadores como +, -, *, /, etc. en nuestras clases.

```csharp
  class Punto {
    public int X { get; set; }
    public int Y { get; set; }

    public static Punto operator +(Punto punto1, Punto punto2) {
      return new Punto { X = punto1.X + punto2.X, Y = punto1.Y + punto2.Y };
    }
  }
```

**12-Entrada-Salida-de-Textos.cs**

La entrada y salida de textos en C# se realiza utilizando las clases `Console`, `StreamWriter` y `StreamReader`. `Console` se utiliza para mostrar mensajes en la consola, mientras que `StreamWriter` y `StreamReader` se utilizan para leer y escribir archivos de texto.

Ejemplo:

```csharp
  // Salida de texto en la consola
  Console.WriteLine("Hola, mundo!");

  // Escritura de texto en un archivo
  using (StreamWriter archivo = new StreamWriter("mi_archivo.txt")) {
    archivo.WriteLine("Hola, archivo!");
  }

  // Lectura de texto desde un archivo
  using (StreamReader archivo = new StreamReader("mi_archivo.txt")) {
    string contenido = archivo.ReadLine();
    Console.WriteLine(contenido); // Imprime: "Hola, archivo!"
  }
```

**13-Entrada-Salida-de-Archivos-Binarios.cs**

La entrada y salida de archivos binarios en C# permite leer y escribir datos en forma binaria, lo que es útil para guardar y cargar estructuras de datos complejas en archivos.

Ejemplo: 

```csharp
  using System;
  using System.IO;

  class Program {
    static void Main() {
      // Escritura de datos binarios en un archivo
      using (BinaryWriter writer = new BinaryWriter(File.Open("datos.bin", FileMode.Create))) {
        int entero = 42;
        double flotante = 3.14;
        bool booleano = true;
        writer.Write(entero);
        writer.Write(flotante);
        writer.Write(booleano);
      }

      // Lectura de datos binarios desde un archivo
      using (BinaryReader reader = new BinaryReader(File.Open("datos.bin", FileMode.Open))) {
        int enteroLeido = reader.ReadInt32();
        double flotanteLeido = reader.ReadDouble();
        bool booleanoLeido = reader.ReadBoolean();
        Console.WriteLine("Entero: " + enteroLeido); // Imprime: "Entero: 42"
        Console.WriteLine("Flotante: " + flotanteLeido); // Imprime: "Flotante: 3.14"
        Console.WriteLine("Booleano: " + booleanoLeido); // Imprime: "Booleano: True"
      }
    }
  }
```

**14-Templates.cs**

En C#, los templates o genéricos permiten crear clases y métodos que pueden trabajar con diferentes tipos de datos. Se utilizan para lograr la reutilización de código y aumentar la flexibilidad de las estructuras de datos y algoritmos.

Ejemplo:

```csharp
  class MiLista<T> {
    private T[] elementos = new T[5];
    private int contador = 0;

    public void Agregar(T elemento) {
      elementos[contador] = elemento;
      contador++;
    }
  }

  MiLista<int> listaEnteros = new MiLista<int>();
  listaEnteros.Agregar(5);

  MiLista<string> listaStrings = new MiLista<string>();
  listaStrings.Agregar("Hola");
```

**15-Linq.cs**

Language Integrated Query (LINQ) es una extensión de C# que permite realizar consultas a colecciones y fuentes de datos utilizando una sintaxis similar a SQL. Se utiliza para filtrar, ordenar y transformar datos de manera eficiente.

Ejemplo:

```csharp
  List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
  var numerosPares = from num in numeros where num % 2 == 0 select num;

  foreach (var num in numerosPares) {
    Console.WriteLine(num); // Imprime: 2, 4
  }
```

**16-Delegados-Predeterminados.cs**

C# proporciona varios delegados predefinidos que se utilizan para representar funciones con firmas específicas, como `Action`, `Func` y `Predicate`. Estos delegados facilitan el trabajo con métodos que toman y devuelven valores.

Ejemplo:

```csharp
  // Delegado Action sin parámetros y sin valor de retorno
  Action miAction = () => Console.WriteLine("Hola, mundo!");
  miAction(); // Imprime: "Hola, mundo!"

  // Delegado Func que toma dos enteros y devuelve un entero
  Func<int, int, int> miFunc = (a, b) => a + b;
  int resultado = miFunc(5, 3); // resultado = 8
```


**17-Eventos.cs**

Los eventos en C# son una forma de implementar el patrón de diseño Observador. Permiten que una clase notifique a otras clases cuando ocurre un evento específico.

Ejemplo:

```csharp
  class Contador {
    private int _contador;

    public delegate void ContadorEventHandler(object sender, EventArgs e);
    public event ContadorEventHandler ContadorCambiado;

    public int Valor {
      get { return _contador; }
      set {
        _contador = value;
        OnContadorCambiado();
      }
    }

    protected virtual void OnContadorCambiado() {
      if (ContadorCambiado != null)
        ContadorCambiado(this, EventArgs.Empty);
    }
  }

  class Program {
    static void Main(string[] args) {
      Contador miContador = new Contador();
      miContador.ContadorCambiado += MiContador_ContadorCambiado;

      miContador.Valor = 10; // Imprime: "El contador ha cambiado a: 10"
    }

    static void MiContador_ContadorCambiado(object sender, EventArgs e) {
      Contador contador = (Contador)sender;
      Console.WriteLine("El contador ha cambiado a: " + contador.Valor);
    }
  }
```

**18-Serializacion.cs**

La serialización en C# es el proceso de convertir objetos en un formato que se puede almacenar o transmitir, como XML o JSON. La deserialización es el proceso inverso, donde se convierten los datos serializados en objetos.

Ejemplo:

```csharp
  [Serializable]
  class Persona {
    public string Nombre { get; set; }
    public int Edad { get; set; }
  }

  // Serialización de un objeto Persona
  Persona persona = new Persona { Nombre = "Juan", Edad = 30 };
  XmlSerializer serializer = new XmlSerializer(typeof(Persona));

  using (StreamWriter archivo = new StreamWriter("persona.xml")) {
    serializer.Serialize(archivo, persona);
  }

  // Deserialización del archivo XML a un objeto Persona
  Persona personaDeserializada;
  using (StreamReader archivo = new StreamReader("persona.xml")) {
    personaDeserializada = (Persona)serializer.Deserialize(archivo);
  }
```

**19-Excepciones.cs**

Las excepciones en C# son eventos inesperados que pueden ocurrir durante la ejecución del programa. Permiten manejar situaciones de error y evitar que el programa se detenga abruptamente. Las excepciones se capturan y se manejan mediante bloques `try-catch`.

Ejemplo:

```csharp
  try {
    int resultado = 5 / 0; // Intento de división por cero
  } catch (DivideByZeroException ex) {
    Console.WriteLine("Error: " + ex.Message); // Imprime: "Error: Intento de división por cero."
  }
```

**20-Atributos.cs**

Los atributos en C# proporcionan información adicional sobre tipos, métodos, propiedades y otros elementos del programa. Se utilizan para agregar metadatos y anotaciones que pueden ser leídos en tiempo de ejecución.

Ejemplo:

```csharp
  [Obsolete("Este método está obsoleto. Utilice otro método en su lugar.")]
  void MetodoObsoleto() {
    // Código del método obsoleto
  }
```

**21-Partial.cs**

Las clases parciales en C# permiten dividir la definición de una clase en múltiples archivos. Se utilizan para mantener la organización y evitar la modificación de un solo archivo grande.

Ejemplo:

```csharp
  // Archivo 1
  public partial class Persona {
    public string Nombre { get; set; }
  }

  // Archivo 2
  public partial class Persona {
    public int Edad { get; set; }
  }
```

**22-Indexadores.cs**

Los indexadores en C# permiten acceder a los elementos de una clase como si fueran un array utilizando una sintaxis similar a los corchetes.

Ejemplo:

```csharp
  class MiLista {
    private int[] datos = new int[5];

    public int this[int index] {
      get { return datos[index]; }
      set { datos[index] = value; }
    }
  }

  MiLista lista = new MiLista();
  lista[0] = 10;
  int valor = lista[0]; // valor = 10
```

**23-Reflection.cs**

La reflexión en C# permite obtener información sobre tipos, métodos, propiedades y otros elementos en tiempo de ejecución. Se utiliza para realizar tareas como la creación dinámica de objetos, la invocación de métodos y la obtención de atributos.

Ejemplo:

```csharp
  Type tipo = typeof(Persona);

  // Obtener propiedades públicas de la clase Persona
  PropertyInfo[] propiedades = tipo.GetProperties();
  foreach (PropertyInfo propiedad in propiedades) {
    Console.WriteLine(propiedad.Name); // Imprime: "Nombre", "Edad"
  }
```
**24-record.cs**

Los registros (records) en C# 9 son una nueva característica que simplifica la creación de clases inmutables con propiedades de solo lectura y otros miembros autoimplementados. Los registros son adecuados para modelar objetos de datos.

Ejemplo:

```csharp
  public record Persona(string Nombre, int Edad);

  public static void imprimir()
  {
    Persona persona = new Persona("Alexis", 30);
    Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
  }
```

**25-async-await.cs**

El async y await en C# se utilizan para escribir código asíncrono de forma más sencilla. Los métodos marcados con la palabra clave async pueden contener operaciones asincrónicas, y la palabra clave await se utiliza para esperar la finalización de una operación asíncrona.

Ejemplo:

```csharp
  public static async Task<int> ObtenerNumeroAsync()
  {
    await Task.Delay(2000); // Simula una operación asíncrona que toma 2 segundos
    return 42;
  }

  public static async Task imprimir()
  {
    int resultado = await ObtenerNumeroAsync();
    Console.WriteLine($"Resultado: {resultado}");
  }
```

**26-inicializador-de-objeto.cs**

El inicializador de objeto en C# permite asignar valores a las propiedades de un objeto al crearlo.

Ejemplo:

```csharp
  public class Persona
  {
    public string Nombre { get; set; }
    public int Edad { get; set; }
  }

  public static void imprimir()
  {
    Persona persona = new Persona { Nombre = "Juan", Edad = 25 };
    Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
  }
```