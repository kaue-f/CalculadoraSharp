namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------------------");
        Console.WriteLine("Selecione uma opção");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }

    }

    static void Soma()

    {
        Console.Clear();

        Console.WriteLine("1 - Soma");
        Console.WriteLine("----------------------");

        Console.WriteLine("Primeiro Valor");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = v1 + v2;
        Console.WriteLine($"O resultado da soma: {resultado}");
        Console.ReadKey();
        Menu();
        // Console.WriteLine("O resultado da soma: " + resultado);
        // Console.WriteLine($"O resultado da soma: {v1 + v2}");
        // Console.WriteLine($"O resultado da soma: " + (v1 + v2));
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("2 - Subtração");
        Console.WriteLine("----------------------");

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("3 - Divisão");
        Console.WriteLine("----------------------");

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("----------------------");

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação: {resultado}");
        Console.ReadKey();
        Menu();
    }

}

