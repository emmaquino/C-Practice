// Escriba un programa en C# que solicite un número (x) y un ancho para mostrar un cuadrado de ese ancho.
// Use el número para pintar el cuadrado.

public class DibujarCuadrado
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un ancho: ");
        int width = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
        
    }
}
