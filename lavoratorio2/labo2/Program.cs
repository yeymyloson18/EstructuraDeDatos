















//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.


/* 


double numero1, numero2, suma, resta, multiplicacion, division;

Console.Write("Ingrese el primer número: ");
numero1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
numero2 = int.Parse(Console.ReadLine());

suma = numero1 + numero2;
resta = numero1 - numero2;
multiplicacion = numero1 * numero2;
division = numero1 / numero2;

Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + division);   */




//2) Solicita un número al usuario y determina si es par o impar.


/*
double numero;
Console.Write("Ingrese un número: ");
numero = double.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El número " + numero + " es par");
}
else
{
    Console.WriteLine("El número " + numero + " es impar");
}

*/
/*
double numero;
Console.Write("Ingrese un número: ");
numero = double.Parse(Console.ReadLine());

string mensaje = (numero % 2 == 0) ? "El número " + numero + " es par" : "El número " + numero + " es impar";
Console.WriteLine(mensaje);
*/


// 3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

/*  


double bace, altura, area;

Console.Write("ingrese la medida de la base del triangulo: ");
bace = double.Parse(Console.ReadLine());

Console.Write("\"ingrese la medida de la altura del triangulo: ");
altura = double.Parse(Console.ReadLine());

area = (bace * altura) / 2;
Console.WriteLine("El área del triángulo es: " + area);

*/


// 4) Crea una función que calcule la factorial de un número. 

/*


Console.Write("Ingrese un número para calcular su factorial: ");
int numero = int.Parse(Console.ReadLine());

long factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}

Console.WriteLine("El factorial de " + numero + " es: " + factorial);


*/

//5) Verifica si un número ingresado por el usuario es primo o no.


/*


Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
int divisor = 1, contador = 0;

while (divisor <= numero)
{
    if (numero % divisor == 0)
    {
        contador++;
    }
    divisor++;
}

if (contador == 2)
{
    Console.WriteLine("El número es primo.");
}
else
{
    Console.WriteLine("El número no es primo.");
}


*/


//6) Toma una cadena de texto y muestra su inversión. 

/*


Console.Write("Ingrese una cadena de texto: ");
string texto = Console.ReadLine();

string textoInvertido = "";

for (int i = texto.Length - 1; i >= 0; i--)
{
    textoInvertido += texto[i];
}

Console.WriteLine("La cadena invertida es: " + textoInvertido);


*/


//7) Calcula la suma de los números pares en un rango especificado por el usuario. 


/*


Console.Write("Ingrese el inicio del rango: ");
int inicio = int.Parse(Console.ReadLine());

Console.Write("Ingrese el fin del rango: ");
int fin = int.Parse(Console.ReadLine());

int sumaPares = 0;
for (int i = inicio; i <= fin; i++)
{
    if (i % 2 == 0)
    {
        sumaPares += i;
    }
}

Console.WriteLine("La suma de los números pares en el rango es: " + sumaPares);

*/


//8) Crea una lista de los cuadrados de los primeros 10 números naturales. 


/*
// Crear una lista para almacenar los cuadrados de los números naturales
List<int> cuadrados = new List<int>();

// Calcular y agregar los cuadrados de los primeros 10 números naturales a la lista
for (int i = 1; i <= 10; i++)
{
    int cuadrado = i * i;
    cuadrados.Add(cuadrado);
}

// Mostrar la lista de cuadrados
Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
foreach (int cuadrado in cuadrados)
{
    Console.WriteLine(cuadrado);
}

*/


//9) Cuenta el número de vocales en una cadena de texto. 

/*

// Solicitar al usuario que ingrese una cadena de texto
        Console.Write("Ingrese una cadena de texto: ");
string texto = Console.ReadLine().ToLower(); // Convertir la cadena a minúsculas para simplificar la comparación

// Inicializar el contador de vocales
int contadorVocales = 0;

// Iterar a través de cada carácter de la cadena y contar las vocales
foreach (char caracter in texto)
{
    // Verificar si el carácter es una vocal
    if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
    {
        contadorVocales++;
    }
}

// Mostrar el número de vocales en la cadena
Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);

*/


//10) Genera los primeros 10 números de la serie Fibonacci. 


/*
// Definir los primeros dos números de la serie Fibonacci
int a = 0;
int b = 1;

// Mostrar los primeros dos números
Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
Console.Write(a + " " + b + " ");

// Generar los siguientes 8 números de la serie Fibonacci
for (int i = 2; i < 10; i++)
{
    int c = a + b; // Calcular el siguiente número de la serie sumando los dos anteriores
    Console.Write(c + " ");

    // Actualizar los valores de a y b para la siguiente iteración
    a = b;
    b = c;
}


*/





//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 


/*


// Solicitar al usuario que ingrese la cantidad de números
Console.Write("Ingrese la cantidad de números: ");
int cantidad = int.Parse(Console.ReadLine());

// Crear un arreglo para almacenar los números ingresados por el usuario
int[] numeros = new int[cantidad];

// Solicitar al usuario que ingrese los números y almacenarlos en el arreglo
for (int i = 0; i < cantidad; i++)
{
    Console.Write("Ingrese el número " + (i + 1) + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
} 

// Ordenar los números de menor a mayor
Array.Sort(numeros);

// Mostrar los números ordenados
Console.WriteLine("Los números ordenados de menor a mayor son:");
foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}

*/


//12) Verifica si una palabra ingresada por el usuario es un palíndromo. 


/*
 

// Solicitar al usuario que ingrese una palabra
Console.Write("Ingrese una palabra: ");
string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para simplificar la comparación

// Verificar si la palabra es un palíndromo
bool esPalindromo = true;
for (int i = 0; i < palabra.Length / 2; i++)
{
    // Comparar el i-ésimo carácter con el carácter correspondiente desde el final
    if (palabra[i] != palabra[palabra.Length - i - 1])
    {
        esPalindromo = false;
        break; // Si no coinciden, la palabra no es un palíndromo, se detiene el bucle
    }
}

// Mostrar el resultado
if (esPalindromo)
{
    Console.WriteLine("La palabra \"" + palabra + "\" es un palíndromo.");
}
else
{
    Console.WriteLine("La palabra \"" + palabra + "\" no es un palíndromo.");
}

*/


// 13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 


/*
// Solicitar al usuario que ingrese un número para generar su tabla de multiplicar
Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
int numero = int.Parse(Console.ReadLine());

// Mostrar la tabla de multiplicar del número ingresado
Console.WriteLine("Tabla de multiplicar del número " + numero + ":");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
}
*/


//14) Pide el radio de un círculo al usuario y calcula su área. 

/*
// Solicitar al usuario que ingrese el radio del círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        // Calcular el área del círculo utilizando la fórmula: área = π * radio^2
        double area = Math.PI * Math.Pow(radio, 2);

        // Mostrar el área del círculo
        Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
 
*/


// 15) Toma un número entero y calcula la suma de sus dígitos. 

/*

// Solicitar al usuario que ingrese un número entero
Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

// Calcular la suma de los dígitos del número
int sumaDigitos = 0;
int numeroAbsoluto = Math.Abs(numero); // Tomar el valor absoluto para manejar números negativos
while (numeroAbsoluto > 0)
{
    sumaDigitos += numeroAbsoluto % 10; // Obtener el último dígito y sumarlo a la suma total
    numeroAbsoluto /= 10; // Eliminar el último dígito del número
}

// Mostrar la suma de los dígitos
Console.WriteLine("La suma de los dígitos del número es: " + sumaDigitos);
 
*/
































