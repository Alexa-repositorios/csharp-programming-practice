Random dados = new Random();

// Lanzar los tres dados
int dado1 = dados.Next(1, 7);
int dado2 = dados.Next(1, 7);
int dado3 = dados.Next(1, 7);

// Calcular el total
int total = dado1 + dado2 + dado3;

// Mostrar los resultados de los dados
Console.WriteLine($"Lanzamiento de dados: {dado1} + {dado2} + {dado3} = {total}");

// Otorgar un bono por dobles o triples
if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
{
    // Comprobar si son triples
    if ((dado1 == dado2) && (dado2 == dado3))
    {
        Console.WriteLine("¡Sacaste triples! ¡+6 de bono al total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("¡Sacaste dobles! ¡+2 de bono al total!");
        total += 2;
    }
}

// Mostrar el total final
Console.WriteLine($"Total final: {total}");

// Determinar el premio
if (total >= 16)
{
    Console.WriteLine("¡Ganaste un automóvil nuevo!");
}
else if (total >= 10)
{
    Console.WriteLine("¡Ganaste un portátil nuevo!");
}
else if (total == 7)
{
    Console.WriteLine("¡Ganaste un viaje para dos personas!");
}
else
{
    Console.WriteLine("¡Ganaste un gatito!");
}