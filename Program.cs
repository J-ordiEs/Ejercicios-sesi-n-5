/*Ejercicios sesión 5
Ejercicio 1 - If

Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.
*/

Console.WriteLine("Escribe tu nombre");
string? name = Console.ReadLine();
Console.WriteLine("Escribe tu email");
string? email = Console.ReadLine();
Console.WriteLine("Ingresa tu cupon de descuento");
string? cupon = Console.ReadLine();
var precioProducto = 55m;
var precioConDescuento = 0m;

Console.WriteLine($@"Estos son tus datos:
Nombre: {name} 
Email: {email} 
Descuento: {cupon}%");

List<string> cliente = new List<string>();
cliente.Add(name);
cliente.Add(email);
cliente.Add(cupon);

if (cliente[cliente.Count - 1] != "")
{
    Console.WriteLine($"Si tienes un cupon de descuento es de {cupon}%");
    precioConDescuento = precioProducto * Convert.ToDecimal(cupon) /100;
    Console.WriteLine($"El precio del producto es de {precioProducto:C2} y con descuento seria {precioProducto -  precioConDescuento:C2}");
}
else
{
    Console.WriteLine($"No tienes cupon de descuento el precio de producto seria {precioProducto:C2}");
}

Console.WriteLine();
/*
Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
*/

List<string> lenguajesDeProgramacion = new List<string>
{
    "C#",
    "Java",
    "C++"
};

int count = 0;

Console.WriteLine("Seleccione una opcion");
foreach (var item in lenguajesDeProgramacion)
{
    count++;
    Console.WriteLine($"{count}: {item}");
}

string? opcion = Console.ReadLine();

switch (opcion) 
{
    case "1":
    case "a":
    Console.WriteLine("Has escogido la opcion: " + lenguajesDeProgramacion[0]);
    break;
    case "2":
    case "b":
    Console.WriteLine("Has escogido la opcion: " + lenguajesDeProgramacion[1]);
    break;
    case "3":
    case "c":
    Console.WriteLine("Has escogido la opcion: " + lenguajesDeProgramacion[2]);
    break;
    default:
    Console.WriteLine("Opcion no es valida");
    break;
}
