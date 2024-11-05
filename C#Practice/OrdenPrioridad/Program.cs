// Crea un programa en C# que solicite un número entero x al usuario y imprima el resultado de las siguientes operaciones:
// -6 + x * 5
// (13 - 2) * x
// (x + -2) * (20 / 10)
// (12 + x) / (5 - 4)

class OrdenPrioridad
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(-6 + x * 5);
        Console.WriteLine((13 - 2) * x);
        Console.WriteLine((x + -2) * (20 / 10));
        Console.WriteLine((12 + x) / (5 - 4));
    }

}
