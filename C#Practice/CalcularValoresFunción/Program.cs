// Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
// superficie = 4 * pi * radio al cuadrado
// volumen = 4/3 * pi * radio al cubo



class CalcularDimensionesEsfera
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el radio: ");
        int radio = Convert.ToInt32(Console.ReadLine());

        double superficie = 4 * Math.PI * Math.Pow(radio, 2);
        double volumen = (4/3) * Math.PI * Math.Pow(radio, 3);

        Console.WriteLine("Superficie: " + superficie);
        Console.WriteLine("Volumen: " + volumen);


    }

}
