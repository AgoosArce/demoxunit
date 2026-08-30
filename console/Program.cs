Console.WriteLine("Precio por clase");
int precioBase = 9000;

var pagoDeClase = new PagoDeClase();
var total = pagoDeClase.Sum(precioBase);

Console.WriteLine($"Total: {total}");