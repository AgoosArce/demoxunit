Console.WriteLine("Precio por clase");
int precioBase = 5000;
Console.WriteLine("El precio de la clase es $5000. El mínimo de clases que se pueden tomar es a partir de 2 clases por semana.");
Console.WriteLine("Por lo que si suma otra clase más el total sería:");

var pagoDeClase = new PagoDeClase();
var total = pagoDeClase.Sum(precioBase);

Console.WriteLine($"Total: {total}");