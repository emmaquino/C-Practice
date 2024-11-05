// Cree un programa en C# que solicite al usuario una distancia en metros y el tiempo necesario (horas, minutos, segundos).
// Muestra la velocidad, en metros por segundo, kilómetros por hora y millas por hora.
// 1 milla = 1609 metros.

public class ValorFloat
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una distancia en metros: ");
        float mt = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tiempo en horas: ");
        float thours = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tiempo en minutos: ");
        float tminutes = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tiempo en segundos: ");
        float tseconds = float.Parse(Console.ReadLine());

        float timeBySeconds = (thours * 3600) + (tminutes * 60) + tseconds;

        float mts = mt / timeBySeconds;
        float kph = (mt / 1000.0f) / (timeBySeconds / 3600.0f);
        float mph = kph / 1.609f;   

        Console.WriteLine($"La velocidad en metros/seg es {mts}\r\nLa velocidad en km/h es {kph}\r\nLa velocidad en millas/h es {mph}");
    }
}
