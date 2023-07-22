class Async_await
{
    public static async Task imprimir()
    {
        await ImprimirInformacionAsync();
    }

    public static async Task<string> ObtenerInformacionAsync()
    {
        // Simula una operaci�n as�ncrona que obtiene informaci�n de una API
        await Task.Delay(3000);
        return "Informaci�n obtenida correctamente.";
    }

    public static async Task ImprimirInformacionAsync()
    {
        Console.WriteLine("Obteniendo informaci�n...");
        string resultado = await ObtenerInformacionAsync();
        Console.WriteLine(resultado);
    }
}