// Escriba un programa C# que solicite un número (x) y responda si es positivo o negativo.

public class PositivoNegativo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
        {
            Console.WriteLine("Positivo");
        }
        else if (x < 0) {
            Console.WriteLine("Negativo");
        }
        else
        {
            Console.WriteLine("El número no es ni positivo ni negativo es 0");
        }
    }
}
