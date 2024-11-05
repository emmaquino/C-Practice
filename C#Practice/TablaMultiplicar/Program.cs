// Escribe un programa en C# que pregunte al usuario por un número x
// y muestre el resultado de su tabla de multiplicar del 1 al 10.

public class TablaMultiplicar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 11; i++) {
            Console.WriteLine($"{x}x{i} = {x*i}");
        }
    }
}