
void matriz()
{
    string[] nombre = new string[]
    {
       "Anderson","Brandon","Yeimi","Fatima","Vivian"
    };

    foreach (string n in nombre)
    {
        Console.WriteLine("\tnombre = " + n);
    }

    int[] notas = new int[]
    {
        51,80,96,76,61
    };

    int promedio = 0;
    foreach (int n in notas)
    {
        promedio = promedio + n;
    }
    promedio = promedio / notas.Length;
    Console.WriteLine("\tel promedio=" + promedio);

    int max = notas[0];
    int indexMax = 0;
    int min = notas[0];
    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] > max)
        {
            max = notas[i];
            indexMax = i;
        }
        if (notas[i] < min)
        {
            min = notas[i];
        }
    }
    Console.WriteLine("\tel numero mayor es " + max);
    Console.WriteLine("\tel numero menor es " + min);
    Console.WriteLine("\tel estudiante con la puntuacion mas alta es: " + nombre[indexMax]);
}

matriz();
