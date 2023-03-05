//                       "PARCIAL I"
//   "INGIENERIA EN SISTEMAS Y CIENCIAS DE LA COMPUTACIÓN"
//              ADÁN ISAAC SARCEÑO FLORES
//                      0905-22-6380

Console.WriteLine("\nIngrese un número entero positivo mayor que cero:");
int n = int.Parse(Console.ReadLine());

//Guardamos el dato y se saca el cuadrado para mostrarlo al final.
int[] cuadrados = new int[n];
for (int i = 1; i <= n; i++)
{
    cuadrados[i - 1] = i * i;
}

//Números primos menores o iguales que el numero ingresado "n".
Console.WriteLine("\nNúmeros primos menores o iguales que "+n,"\n");
for (int i = 2; i <= n; i++)
{
    bool esPrimo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            esPrimo = false;
            break;
        }
    }
    if (esPrimo)
    {
        Console.Write(i + " \n");
    }
}

//Multiplos de 4 menores o iguales que el número ingresado "n".
Console.WriteLine("\nMúltiplos de 4 menores o iguales que " +n,"\n");
for (int i = 4; i <= n; i += 4)
{
    Console.Write(i + "\n");
}
//Incrementa en 3 desde 1 hasta llegar al numero en n.
Console.WriteLine("\nSecuencia de números que se incrementan en 3:");
for (int i = 1; i <= n; i += 3)
{
    Console.Write(i + "\n");
}
//Cuadrados de los numeros menores a n.
Console.WriteLine("\nCuadrados de los números menores o iguales que "+n,"\n");
for (int i = 0; i <= n; i++)
{
    Console.WriteLine(cuadrados[i] + " ");
}

Console.ReadKey();