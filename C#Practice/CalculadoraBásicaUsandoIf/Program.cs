// Escriba un programa en C# que solicite al usuario dos números y una operación (+,-,x,/)
// después calcule la operación y muestre el resultado por pantalla.
// Muestre el texto Caracter no reconocido si el símbolo de la operación es diferente a los anteriores.
// Debe usar el bloque if.

public class CalculadoraBásicaUsandoIf
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un símbolo: ");
        string symbol = Console.ReadLine();

        string[] symbols = ["+", "-", "*",  "/"];

        if (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/") {
            Console.WriteLine($"El simbolo {symbol} no existe. Reinicie el programa e intentelo de nuevo.");
        }
        else
        {
            if (symbol == "+") {
                Console.WriteLine(x + y);
            }
            else if (symbol == "-") {
                Console.WriteLine(x - y);
            }
            else if (symbol == "*") {
                Console.WriteLine(x * y);
            }
            else if (symbol == "/") {
                Console.WriteLine(x / y);
            }
        }
    }
}
