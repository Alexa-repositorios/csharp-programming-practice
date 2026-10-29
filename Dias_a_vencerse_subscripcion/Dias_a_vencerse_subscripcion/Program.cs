// Generar un número aleatorio de días hasta el vencimiento
Random aleatorio = new Random();
int diasParaVencer = aleatorio.Next(12);
int porcentajeDescuento = 0;

// Mostrar un mensaje según los días restantes
if (diasParaVencer == 0)
{
    Console.WriteLine("Tu suscripción ha vencido.");
}
else if (diasParaVencer == 1)
{
    Console.WriteLine("¡Tu suscripción vence en un día!");
    porcentajeDescuento = 20;
}
else if (diasParaVencer <= 5)
{
    Console.WriteLine($"Tu suscripción vence en {diasParaVencer} días.");
    porcentajeDescuento = 10;
}
else if (diasParaVencer <= 10)
{
    Console.WriteLine("Tu suscripción vencerá pronto. ¡Renueva ahora!");
}

// Mostrar el mensaje de descuento si corresponde
if (porcentajeDescuento > 0)
{
    Console.WriteLine($"¡Renueva ahora y ahorra un {porcentajeDescuento}%!");
}
