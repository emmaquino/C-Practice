// 

public class CalculadoraBásicaUsandoSwitch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese un símbolo: ");
        string symbol = Console.ReadLine();

        switch (symbol)
            {
                case "+":
                    Console.WriteLine(x + y);
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "*":
                    Console.WriteLine(x * y);
                    break;
                case "/":
                    Console.WriteLine(x / y);
                    break;
                default:
                    Console.WriteLine($"El simbolo {symbol} no existe. Reinicie el programa e intentelo de nuevo.");
                    break;
            }
        }
    }
