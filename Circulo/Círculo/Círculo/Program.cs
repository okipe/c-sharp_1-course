// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var radio = 0d; // 0d indica que es un número con decimales
var resultado = 0d;

Console.WriteLine("Bienvenido, calculemos círculos!!");
// Pi * radio * radio
Console.WriteLine("Ingrese el radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;

Console.WriteLine("El área de tu círculo es de: " + resultado);