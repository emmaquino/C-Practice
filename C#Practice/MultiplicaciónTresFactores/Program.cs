// Escribe un programa en C# que multiplique por tres factores.
// Solicita tres números al usuario y muestra el resultado de multiplicarlos entre sí.

public class MultiplicaciónTresFactores
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa 3 números: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x*y*z);
    }
}