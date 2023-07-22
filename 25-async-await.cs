class Async_await
{
    public static async Task imprimir()
    {
        await ImprimirInformacionAsync();
    }

    public static async Task<string> ObtenerInformacionAsync()
    {
        // Simula una operación asíncrona que obtiene información de una API
        await Task.Delay(3000);
        return "Información obtenida correctamente.";
    }

    public static async Task ImprimirInformacionAsync()
    {
        Console.WriteLine("Obteniendo información...");
        string resultado = await ObtenerInformacionAsync();
        Console.WriteLine(resultado);
    }
}