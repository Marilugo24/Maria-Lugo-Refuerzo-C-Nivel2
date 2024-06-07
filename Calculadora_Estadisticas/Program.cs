// See https://aka.ms/new-console-template for more information

List<double> calificaciones = new List<double>();
Console.WriteLine("Por favor, ingrese las calificaciones de los estudiantes utilizando ',' para los decimales o 'fin' para terminar.");
string CalificacionesEstudiantes = Console.ReadLine();

while (true)
{
    string salir = Console.ReadLine();
    if (salir.ToLower() == "fin")
    {
        break;
    }

    else if (double.TryParse(salir, out double calificacion))
    {
        calificaciones.Add(calificacion);
    }
    else
    {
        Console.WriteLine("Por favor, introduce un número válido o 'fin' para terminar.");
    }
}

double calificacionAlta = calificaciones[0];
double calificacionBaja = calificaciones[0];

foreach (var calificacion in calificaciones)
{
    if (calificacion > calificacionAlta)
    {
        calificacionAlta = calificacion;
    } 
   
     else if (calificacion < calificacionBaja)
    {
        calificacionBaja = calificacion;
    }
}

double promedio = calificaciones.Sum() / calificaciones.Count();

Console.WriteLine($"La calificación más alta es: {calificacionAlta}");
Console.WriteLine($"La calificación más baja es: {calificacionBaja}");
Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
