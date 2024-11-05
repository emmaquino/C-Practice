// Escribe un programa en C# que solicite un número entero x al usuario y imprima el resultado de sumarlo al cuadro.

public class SumasCuadrado
{
    public static void Main(string[] args)
    {

        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}+{0}= {1}", x,x*x);
    }
}
