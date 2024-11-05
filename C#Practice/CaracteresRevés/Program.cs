// Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.

class CaracteresRevés
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 3 letras: ");
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        var c = Console.ReadLine();

        Console.WriteLine($"{c} {b} {a}");

    }

}

