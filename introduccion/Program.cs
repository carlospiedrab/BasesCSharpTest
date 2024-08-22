// See https://aka.ms/new-console-template for more information

using System.Drawing;
using Models;

int x = 12;
string nombres = "Carlos";
string apellidos = "Piedra";
Console.WriteLine($"El valor es {x.ToString()}");
Console.WriteLine($"Nombre Completo: {nombres} {apellidos}");
nombres = "Ricardo";
Console.WriteLine($"Nombres Completo Updated: {nombres.ToUpper()} {apellidos.ToUpper()}");
bool IsMayor = false;
int edad = 18;
/*if (edad > 18)
{
    IsMayor = true;
}

if (IsMayor == true)
{
    Console.WriteLine("Es Mayor de Edad");
}
else
{
    Console.WriteLine("Es Menor de Edad");
}
*/
IsMayor = edad >= 18;
Console.WriteLine((IsMayor) ? "Es Mayor de Edad" : "Es Menor de Edad");

int kilometros = 100;
ConvertidorUnidad kilometrosAMetros = new ConvertidorUnidad(1000);
Console.WriteLine($"{kilometros} kilometros son {kilometrosAMetros.Convertir(kilometros)} metros");

// Por Valor y Referencia
Punto p1 = new Punto();
p1.x = 7;
p1.y = 0;

Punto p2 = p1;
Console.WriteLine($"Punto 1: {p1.x} {p1.y}");
Console.WriteLine($"Punto 2: {p2.x} {p2.y}");
p1.x = 8;
Console.WriteLine($"Punto 1: {p1.x} {p1.y}");
Console.WriteLine($"Punto 2: {p2.x} {p2.y}");

// Arrays
// string[] personas = new string[5];
// personas[0] = "Carlos";
// personas[1] = "Ricardo";
// personas[2] = "Enrique";
// personas[3] = "Julio";
// personas[4] = "Manuel";

// for (int i = 0; i < personas.Length; i++)
// {
//     Console.WriteLine("Nombre Persona: " + personas[i]);
// }

string[] personas = new string[] { "Carlos", "Ricardo", "Enrique", "Julio", "Manuel" };
for (int i = 0; i < personas.Length; i++)
    Console.WriteLine("Nombre Persona: " + personas[i]);

// Switch
char letra;
string resultado;
Console.WriteLine("Ingrese una letra");
letra = Convert.ToChar(Console.ReadLine());

// switch (Char.ToLower(letra))
// {
//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//         resultado = "La letra es una vocal";
//         break;    
//     default:
//         resultado = "La letra NO es una vocal";
//         break;
// }

resultado = letra switch
{
    'a' => "La letra es una vocal",
    'e' => "La letra es una vocal",
    'i' => "La letra es una vocal",
    'o' => "La letra es una vocal",
    'u' => "La letra es una vocal",
    _ => "La letra No es una vocal"
};

Console.WriteLine(resultado);

Persona persona = new Persona()
{
    Id = 1,
    Nombres = "Carlos",
    Apellidos = "Piedra",
    Genero = Genero.Masculino,
    Edad = 40,
    Direccion = new Direccion()
    {
        Numero = "123",
        NombreCalle = "El Oro",
        Ciudad = "Gye",
        Pais = "Ecuador"
    }
};

Console.WriteLine($"La Persona: {persona.NombreCompleto} de genero {persona.Genero} {persona.Direccion.DireccionCompleta}");

Empleado empleado = new Empleado()
{
    Id = 3,
    Apellidos = "Toledo",
    Nombres = "Sara",
    Direccion = new Direccion()
    {
        Numero = "29",
        NombreCalle = "Gomez Rendon",
        Ciudad = "Guayaquil",
        Pais = "Ecuador"
    },
    NumeroEmpleado = Guid.NewGuid(),
    FechaIngreso = new DateOnly(2020, 1, 1),
    Salario = 2000
};

Console.WriteLine($"Empleado #: {empleado.NumeroEmpleado}");
Console.WriteLine($"Nombres #: {empleado.NombreCompleto}");
Console.WriteLine($"Nombres #: {empleado.Direccion.DireccionCompleta}");
Console.WriteLine($"Años de Antiguedad #: {empleado.Antiguedad}");

