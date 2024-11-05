// Escribe un programa en C# que solicite dos números enteros al usuario (x, y)
// y imprima el resultado de la división y el resto de la división en una nueva linea.


public class DivisiónMóduloDivisión
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa dos números enteros: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x / y);
        Console.WriteLine(x % y);
    
    }
}