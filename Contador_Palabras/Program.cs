// See https://aka.ms/new-console-template for more information

Console.WriteLine("Por favor ingresa un texto: ");
string TextoUsuario = Console.ReadLine();

string[] Texto = TextoUsuario.Split(new char[] { ' ' });

foreach (string texto in Texto)
{
    Console.WriteLine(texto);
}

Dictionary<string, int> FrecuenciaPalabras = new Dictionary<string, int>();

foreach (string texto in Texto)
{
    if (FrecuenciaPalabras.ContainsKey(texto))
    {
        FrecuenciaPalabras[texto]++;
    }
    else
    {
        FrecuenciaPalabras[texto] = 1;
    }
}

foreach (KeyValuePair<string, int> entrada in FrecuenciaPalabras)
{
    Console.WriteLine("Palabra: " + entrada.Key + ", Frecuencia: " + entrada.Value);
}

