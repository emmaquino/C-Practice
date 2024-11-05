// Escriba un programa en C# que solicite el ancho (x) y la altura (y) de un rectángulo y calcule el perímetro,
// el área y la diagonal.
// Perímetro = suma de los cuatro lados.
// Área= base x altura.
// Diagonal= Teorema de Pitágoras.

class ValorDouble
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el ancho (x) y la altura (y) de un rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());
        double altura = Convert.ToDouble(Console.ReadLine());

        double perimetro = ancho * 2 + altura * 2;
        double area = ancho * altura;
        double diagonal = Math.Sqrt( Math.Pow(ancho, 2) + Math.Pow(altura, 2) );

        Console.WriteLine($"Perímetro: {perimetro}\r\nÁrea: {area}\r\nDiagonal: {diagonal}");

    }

}