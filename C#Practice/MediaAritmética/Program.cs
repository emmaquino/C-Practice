// Escribe un programa en C# que calcule la medía aritmética de 4 factores introducidos por el usuario, uno por cada linea.

class MediaAritmética
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce 4 factores númericos: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        int z2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((x+y+z+z2) / 4);
    }

}
