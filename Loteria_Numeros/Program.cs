// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenido al juego de loteria.");
Random random = new Random();
int[] numerosGanadores = new int[6];

for (int i = 0; i < numerosGanadores.Length; i++)
{
    int numero;
    do
    {
        numero = random.Next(1, 49);
    }
    while (Array.IndexOf(numerosGanadores, numero) >= 0);

    numerosGanadores[i] = numero;
}

List<int> numerosUsuario = new List<int>();
Console.WriteLine("Por favor, Ingrese 6 numeros diferentes entre 1 y 49:");

while (numerosUsuario.Count < 6)
{
    Console.Write("Ingrese un numero: ");
    if (int.TryParse(Console.ReadLine(), result: out int numeros))
    {
        if (numeros >= 1 && numeros <= 49)
        {
            if (!numerosUsuario.Contains(numeros))
            {
                numerosUsuario.Add(numeros);
                Console.WriteLine("Numero almacenado.");
            }
            else
            {
                Console.WriteLine("El numero ya esta en la lista, por favor ingrese un numero diferente.");
            }
        }
        else
        {
            Console.WriteLine("El numero debe estar entre 1 y 49, por favor intente de nuevo.");
        }
    }
    else
    {
        Console.WriteLine("Entrada invalida, por favor ingrese un numero.");
    }
}

int aciertos = 0;
foreach (int numero in numerosGanadores)
{
    if (numerosUsuario.Contains(numero))
    {
        aciertos++;
    }

}

Console.WriteLine("Numeros ganadores de la loteria: " + string.Join(", ", numerosGanadores));

Console.WriteLine("Numeros ingresados por el usuario:");

foreach (int n in numerosUsuario)
{
    Console.WriteLine(n);
}

Console.WriteLine($"Numero de aciertos:  {aciertos}");

bool acierto = false;
foreach (int intento in numerosUsuario)
{
    if (numerosGanadores.Contains(intento))
    {
        acierto = true;
        Console.WriteLine($"¡Felicidades! Has adivinado el numero ganador {intento}.");
    }
}

if (!acierto)
{
    Console.WriteLine("Lo siento, no has adivinado ninguno de los numeros ganadores.");
}

