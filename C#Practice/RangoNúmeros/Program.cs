// Cree un programa en C# que solicite un rango de números al usuario (x, y) y los muestre en pantalla.

public class RangoNúmeros
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i < y + 1; i++) {
            Console.WriteLine(i);
        }
    }
}