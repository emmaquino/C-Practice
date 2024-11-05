//Cree un programa en C# que solicite dos números al usuario (x, y) y muestre el resultado de su división.
//Tendrá que controlar la división por 0 con el uso de la excepción DivideByZeroException en un bloque try-catch.
//Si el usuario intenta dividir por 0 muestre No se puede dividir por 0.

class DivisiónEntreCero
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa dos números enteros: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine(x / y);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por 0");
        }
        

    }
}
