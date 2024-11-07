// Escriba un programa en C# que solicite un número (x) y luego muestre un rectángulo de 3 columnas de ancho
// y 5 filas de alto usando ese dígito.


public class DibujarRectángulo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }
}
