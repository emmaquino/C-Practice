// Crea un programa en C# que solicite al usuario 2 números enteros y muestre en pantalla un número al azar entre esos valores.
// Puedes utilizar el objeto Random de .NET.

public class GenerarNúmeroAzar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número del rango: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número del rango: ");
        int y = Convert.ToInt32(Console.ReadLine());

        var rand = new Random();

        Console.WriteLine(rand.Next(x, y + 1));
    }
}
