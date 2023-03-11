// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var radio = 0d;
var resultado = 1.1;

const double Pi = 3.141589;

const double SiempreSeEscribeAsi = 200.0d;

Console.WriteLine("Bienvenido, calculemos círculos");
// Pi * radio * radio

Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * radio * radio;

Console.WriteLine("El área de tu cículo es de: " + resultado);