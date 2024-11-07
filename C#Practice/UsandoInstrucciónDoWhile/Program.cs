// Cree un programa en C# que solicite un número (x) y muestre 10*x. Debe repetirse hasta que el usuario ingrese 0.

public class UsandoInstrucciónDoWhile
{
    static void Main(string[] args)
    {
        int x = default;

        do
        {
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(10 * x);
        }
        while (x != 0);
    }
}
