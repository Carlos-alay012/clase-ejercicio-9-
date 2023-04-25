//void matriz()
//{
//    string[] nombre = new string[]
//    {
//       "Anderson","Brandon","Yeimi","Fatima","Vivian"
//    };

//    foreach (string n in nombre)
//    {
//        Console.WriteLine("\tnombre = " + n);
//    }

//    int[] notas = new int[]
//    {
//        51,80,96,76,61
//    };

//    int promedio = 0;
//    foreach (int n in notas)
//    {
//        promedio = promedio + n;
//    }
//    promedio = promedio / notas.Length;
//    Console.WriteLine("\tel promedio=" + promedio);

//    int max = notas[0];
//    int indexMax = 0;
//    int min = notas[0];
//    for (int i = 1; i < notas.Length; i++)
//    {
//        if (notas[i] > max)
//        {
//            max = notas[i];
//            indexMax = i;
//        }
//        if (notas[i] < min)
//        {
//            min = notas[i];
//        }
//    }
//    Console.WriteLine("\tel numero mayor es " + max);
//    Console.WriteLine("\tel numero menor es " + min);
//    Console.WriteLine("\tel estudiante con la puntuacion mas alta es: " + nombre[indexMax]);
//}

//matriz();

using System;
namespace EjemploArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tIngrese la cantidad de alumnos:");
            int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[cantidadAlumnos];
            int[] notas = new int[cantidadAlumnos];

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("\tIngrese el nombre del alumno " + (i + 1) + ":");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("\tIngrese la nota del alumno " + (i + 1) + ":");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\tDatos de los alumnos:");
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("Alumno " + (i + 1) + ": " + nombres[i] + ", Nota: " + notas[i]);
            }

            int mayor = notas[0];
            int menor = notas[0];
            int indexMax = 0;

            for (int i = 1; i < cantidadAlumnos; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    indexMax = i;
                }

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            Console.WriteLine("\nMayor nota: " + mayor);
            Console.WriteLine("Menor nota: " + menor);
            Console.WriteLine("Estudiante con la puntuación más alta: " + nombres[indexMax]);
        }
    }
}
