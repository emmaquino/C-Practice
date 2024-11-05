// La escala Celsius es centígrada, 100 divisiones separan el punto de congelación del punto de ebullición del agua.
// En la escala Fahrenheit de los anglosajones, estos dos puntos están separados por 180 grados.
// La escala de Kelvin es una escala absoluta utilizada en ciencias.
// Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit.
// Solicite al usuario la cantidad de grados centígrados para convertirlos usando las siguientes tablas de conversión:
// kelvin = celsius + 273
// fahrenheit = celsius x 18/10 + 32

class CentígradosKelvinFahrenheit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la temperatura en celsius que desea convertir: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double kelvin = celsius + 273;
        double fahrenheit = (celsius) * (18 / 10) + 32;

        Console.WriteLine($"Kelvin = {kelvin}");
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

    }

}