// Escriba un programa en C# que solicite tres números (x, y, z) y muestre el mayor de ellos.

public class MayorTresNúmeros
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        int z = Convert.ToInt32(Console.ReadLine());

        int[] numbers = { x, z, y };

        Console.WriteLine(numbers.Max());
    }
}
