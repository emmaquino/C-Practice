// Escriba un programa en C# que solicite tres números (a, b, c) y muestre el resultado de (a+b)*c
// y el resultado de a*c + b*c.

class OperacionesEquivalentes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce 3 números: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine((a + b) * c);
        Console.WriteLine((a * c) + (b * c));

    }

}
