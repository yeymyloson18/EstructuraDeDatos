
// declaracion de variables

//Console.WriteLine("ingrese un numero entero: ");
//var numeroresivido = Console.ReadLine();
//var numero = int.Parse(numeroresivido);
//var esPar = false;

//// resolucion

//if (numero % 2 == 0)
//{
//    esPar = true;
//}
//// mostrar resultado


/*
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Mostrar opciones al usuario
            Console.WriteLine("Elija una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            // Leer la opción del usuario
            string opcion = Console.ReadLine();

            // Salir si el usuario elige la opción 5
            if (opcion == "5")
            {
                break;
            }

            // Solicitar al usuario que ingrese dos números
            Console.Write("Ingrese el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Realizar la operación seleccionada
            double resultado = 0;
            switch (opcion)
            {
                case "1":
                    resultado = numero1 + numero2;
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    break;
                case "4":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    continue;
            }

            // Mostrar el resultado de la operación
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}


*/



// mi primer hola mundo


/*
Console.WriteLine("este es el culso de estructura de datos !");
Console.WriteLine("unsch 2024 !");
Console.WriteLine("bola bolita");

// Definir dos números para sumar
int numero1 = 5;
int numero2 = 7;

// Sumar los dos números
int suma = numero1 + numero2;

// Mostrar el resultado
Consol.WriteLine("La suma de " + numero1 + " y " + numero2 + " es: " + suma);


int[] numeros = new int[10];

numeros[0] = 1; numeros[1] = 2;
numeros[2] = 3; numeros[3] = 4;
numeros[4] = 5; numeros[5] = 6;
numeros[6] = 7; numeros[7] = 8;
numeros[8] = 9; numeros[9] = 0;

var numero = numeros[3];
var cantidad = numeros.Length;
*/



/*se desea calcular la distancia recorrida (m) por un móvil que tiene velocidad constante
(m/s) durante un tiempo T (sg), considerar que es un MRU (movimiento rectilíneo uniforme) 


double d, v, t;
Console.Write("ingrese la velocidad constante: ");
v = int.Parse(Console.ReadLine());
Console.Write("ingrese el tiempo : "); 
t = int.Parse(Console.ReadLine());
d = v * t;
Console.Write("la distancia es: {0}", d); Console.ReadLine();

*/



/*
int Factorial(int fact)
{
    if (fact > 0)
{
        int valor = fact * Factorial(fact - 1);
        return valor;
    }
else
        return 1;
}

int f = Factorial(5);
Console.WriteLine(" El factorial de 5 es " +f);
Console.ReadKey();

*/



//int Fibonacci(int n)
//{
//    if ((n == 0) || (n == 1))
//    {
//        return n;
//    }
//    else

//    {
//        return Fibonacci(n - 1) + Fibonacci(n - 2);
//    }
//}
//Console.Write(" ESCRIBA LA CANTIDAD DE LOS NUMEROS DE FIBONACCI QUE DESEA IMPRIMIR: ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 2; i <= n + 1; i++)
//{
//    Console.WriteLine(Fibonacci(i));
//}



//// Declarar a array simple de 5 enteros.
//int[] array1 = new int[5];
//// Declarar y asignar array de enteros.
//int[] array2 = [1, 2, 3, 4, 5, 6];
//// Declarar un array de 2 dimensiones.
//int[,] multiDimensionalArray1 = new int[2, 3];
//// Declarar y asignar un array 2 dimensiones de enteros.
//int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };


//using System.Text;

//int[] array = new int[5];
//string[] weekDays = ["Lunes ;", "Martes", " Miercoles ", " Jueves ", " Viernes", " Sabado","Domingo"];
//Console.WriteLine(weekDays[0]);
//Console.WriteLine(weekDays[1]);
//Console.WriteLine(weekDays[2]);
//Console.WriteLine(weekDays[3]);
//Console.WriteLine(weekDays[4]);
//Console.WriteLine(weekDays[5]);
//Console.WriteLine(weekDays[6]);




//Console.Write(" Ingrese tamaño del array : ");
//int n = int.Parse(Console.ReadLine());
//int[] m = new int[n];
//Console.WriteLine("Ingrese elementos : ");
//bool multiplo = false; int temp = 0;
//for (int i = 0; i < m.Length; i++)
//{
//    multiplo = false;
//    while (multiplo == false)
//    {
//        Console.Write("Ingrese elemento ["+ i + "]:");
//        temp = int.Parse(Console.ReadLine()) ;
//        if (temp % 5 == 0)
//        { m[i] = temp; multiplo = true; }
//        else
//        { Console.WriteLine(temp + " no es múltiplo de 5 "); }
//    }
//}
//Console.WriteLine("Los elementos del array son :");
//foreach (int i in m)
//{ Console.Write(i + " "); }
//Console.ReadLine();


Console.Write("Ingrese el tamaño del arreglo: ");
int tamaño = int.Parse(Console.ReadLine());

int[] arreglo = new int[tamaño];

for (int i = 0; i < tamaño; i++)
{
    Console.Write("Ingrese el elemento " + (i + 1) + ": ");
    arreglo[i] = int.Parse(Console.ReadLine());
}

















































