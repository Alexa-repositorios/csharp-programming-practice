//Ingresa los datos de la cuenta

// Solicita valor de la cuenta 

Console.Write("Ingresa el valor de la cuenta: ");
decimal valorCuenta = Convert.ToDecimal(Console.ReadLine());

// Solicita porcentaje de propina

Console.Write("Ingresa el porcentaje de la propina: ");
decimal porcentajePropina = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nDetalles de la factura:");
Console.WriteLine($"  Valor de la cuenta:    ${valorCuenta}");
Console.WriteLine($"  Porcentaje de propina: {porcentajePropina}%");

// Calcular
decimal valorPropina = valorCuenta * (porcentajePropina / 100);
decimal totalCuenta = valorCuenta + valorPropina;

// Display the results
 Console.WriteLine($"\n porcentaje de propina:   ${porcentajePropina}");
 Console.WriteLine($"Total cuenta: ${totalCuenta}");



