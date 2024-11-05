// Escribe un programa en C# que calcule el resultado de sumar, restar,
// multiplicar y dividir dos números introducidos por el usuario.
// Además también debería calcular el resto de la división en la última linea.

class CalculadoraBásica
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce dos números: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} + {y} = {x+y}");
        Console.WriteLine($"{x} - {y} = {x-y}");
        Console.WriteLine($"{x} * {y} = {x*y}");
        Console.WriteLine($"{x} / {y} = {x/y}");
        Console.WriteLine($"{x} mod {y} = {x%y}");


    }

}