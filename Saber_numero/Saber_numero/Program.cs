// Configurar el juego
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 21);
int maximoIntentos = 5;
int contadorIntentos = 0;
bool haGanado = false;

Console.WriteLine("Estoy pensando en un número entre 1 y 20.");
Console.WriteLine($"Tienes {maximoIntentos} intentos. ¡Buena suerte!");

// Pedir al jugador que adivine
while (contadorIntentos < maximoIntentos)
{
    contadorIntentos++;

    Console.Write($"\nIntento #{contadorIntentos}: ");
    int intento = Convert.ToInt32(Console.ReadLine());

    // Comprobar el intento y dar una pista
    if (intento == numeroSecreto)
    {
        Console.WriteLine($"¡Correcto! Lo acertaste en {contadorIntentos} intentos.");
        haGanado = true;
        break;
    }
    else if (intento < numeroSecreto)
    {
        Console.WriteLine("El número es demasiado bajo.");
    }
    else
    {
        Console.WriteLine("El número es demasiado alto.");
    }
}

// Anunciar el resultado
if (!haGanado)
{
    Console.WriteLine($"\n¡Se acabaron los intentos! El número era {numeroSecreto}.");
}
