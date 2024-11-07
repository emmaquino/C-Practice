// Cree un programa en C# que solicite un número (x) y muestre 10*x. Debe repetirse hasta que el usuario ingrese 0.

public class UsandoInstrucciónWhile
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());

        while (x != 0) {
            Console.WriteLine(10*x);
            x = Convert.ToInt32(Console.ReadLine());
        }
    }
}
