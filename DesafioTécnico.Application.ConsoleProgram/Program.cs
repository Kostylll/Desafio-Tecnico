using DesafioTécnicoApi.Application.Services;

class Program
{
    private readonly NumberService _numberService;
    public Program(NumberService numberService)
    {
        _numberService = numberService;
    }

    static void Main(string[] args)
    {

        var numberService = new NumberService();

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        List<int> divisores = numberService.ObterDivisores(numero);
        List<int> divisoresPrimos = numberService.ObterDivisoresPrimos(divisores);

        Console.WriteLine($"Número de Entrada: {numero}");
        Console.Write("Números divisores: ");

        foreach (int divisor in divisores)
        {
            Console.Write($"{divisor} ");
        }

        Console.WriteLine();

        Console.Write("Divisores Primos: ");

        foreach (int primo in divisoresPrimos)
        {
            Console.Write($"{primo} ");
        }

        Console.WriteLine();
    }
}
