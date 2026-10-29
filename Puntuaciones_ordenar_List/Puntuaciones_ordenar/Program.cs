// Configurar el juego
Random aleatorio = new Random();
int rondasJugadas = 8;
List<int> todasLasPuntuaciones = new List<int>();

Console.WriteLine($"Jugando {rondasJugadas} rondas...\n");

// Simular las rondas y registrar cada puntuación
for (int ronda = 1; ronda <= rondasJugadas; ronda++)
{
    int puntuacion = aleatorio.Next(0, 101);
    todasLasPuntuaciones.Add(puntuacion);
    Console.WriteLine($"Ronda {ronda}: obtuvo {puntuacion} puntos");
}

Console.WriteLine($"\nTotal de rondas registradas: {todasLasPuntuaciones.Count}");

// Construir el arreglo de los 5 mejores resultados
todasLasPuntuaciones.Sort();
todasLasPuntuaciones.Reverse();

int[] mejoresPuntuaciones = new int[5];

for (int i = 0; i < mejoresPuntuaciones.Length; i++)
{
    mejoresPuntuaciones[i] = todasLasPuntuaciones[i];
}

// Mostrar la tabla de posiciones
Console.WriteLine("\n Tabla de los 5 mejores resultados");

for (int i = 0; i < mejoresPuntuaciones.Length; i++)
{
    Console.WriteLine($"{i + 1}. {mejoresPuntuaciones[i]} puntos");
}
