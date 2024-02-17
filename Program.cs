//CONVERTIR DATOS
using System;

int numeroEntero;
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("1. Convertir entero a decimal");

Console.WriteLine("Ingrese un número entero:");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
numeroEntero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

decimal numeroDecimal = (decimal)numeroEntero;

Console.WriteLine("El número decimal equivalente es: {0}", numeroDecimal);
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("2. Convertir decimal a flotante");
// Declarar variable decimal

// Convertir a flotante usando la clase Convert
float numeroFlotante = Convert.ToSingle(numeroDecimal);

// Mostrar el resultado
Console.WriteLine("Número decimal: " + numeroDecimal);
Console.WriteLine("Número flotante: " + numeroFlotante);

Console.WriteLine("El número decimal equivalente es: {0}", numeroDecimal);
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("3. Convertir decimal a flotante");
// Declarar variable flotante

// Convertir a entero usando la clase Convert
Convert.ToInt32(numeroFlotante);

// Mostrar el resultado
Console.WriteLine("Número flotante: " + numeroFlotante);
Console.WriteLine("Número entero: " + numeroEntero);
{
    Console.WriteLine("**Conversor de tipos de datos**");
    Console.WriteLine("--------------------------");
    Console.WriteLine("4. Convertir en un caracter a entero ");
    // Declarar variable caracter

    // Convertir a entero usando la clase Char
    int valorEntero = (int)char.GetNumericValue('A');


    // Pedir el número entero al usuario
    Console.WriteLine("Introduzca un número entero: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

    // Convertir el número entero a caracter
#pragma warning disable CS8604 // Posible argumento de referencia nulo
    char caracter = (char)int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

    // Mostrar el resultado
    Console.WriteLine("El caracter equivalente al número entero es: " + caracter);

    // Pedir el caracter al usuario
    Console.WriteLine("Introduzca un caracter: ");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
#pragma warning disable IDE0059 // Asignación innecesaria de un valor
    char caracter1 = Console.ReadLine()[0];
#pragma warning restore IDE0059 // Asignación innecesaria de un valor
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

    // Convertir el caracter a entero
    // Mostrar el resultado
#pragma warning disable CS8604 // Posible argumento de referencia nulo
    Console.WriteLine("El número entero equivalente al caracter es: " + int.Parse(s: Console.ReadLine()));
#pragma warning restore CS8604 // Posible argumento de referencia nulo

    Console.WriteLine("**Conversor de tipos de datos**");
    Console.WriteLine("--------------------------");
    Console.WriteLine("5. Convertir en un caracter a entero ");

    // Pedir el caracter al usuario
    Console.WriteLine("Introduzca un caracter: ");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
    char _ = Console.ReadLine()[0];
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

    // Mostrar el resultado
#pragma warning disable CS8604 // Posible argumento de referencia nulo
    Console.WriteLine($"El número entero equivalente al caracter es: {int.Parse(s: Console.ReadLine())}");
#pragma warning restore CS8604 // Posible argumento de referencia nulo


}
