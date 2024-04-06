// See https://aka.ms/new-console-template for more information

//EXAMEN 01 - BY DANIEL CCAHUAY

using System.Collections.Specialized;
using System.Timers;

string TipoDeNumero(int numero)
{
    string tipoNumero = string.Empty;
    if (numero > 0)
        tipoNumero = "Numero Positivo";
    else if (numero < 0)
        tipoNumero = "Numero Negativo";
    else
        tipoNumero = "Numero Cero";
    return tipoNumero;
}

void MensajeSegunDiaSemana(string diaSemana)
{
    switch (diaSemana.ToUpper())
    {
        case "LUNES":
            Console.WriteLine($"Hoy {diaSemana} es un excelente dia para iniciar la semana");
            break;
        case "MARTES":
            Console.WriteLine($"Hoy {diaSemana} a continuar con el buen inicio de semana");
            break;
        case "MIERCOLES":
            Console.WriteLine($"Hoy {diaSemana} estamos a mitad de semana");
            break;
        case "JUEVES":
            Console.WriteLine($"Hoy {diaSemana} solo faltan dos dias para el fin de semana");
            break;
        case "VIERNES":
            Console.WriteLine($"Hoy {diaSemana} a terminar los labores y disfrutar el fin de semana");
            break;
        case "SABADO":
            Console.WriteLine($"Hoy {diaSemana} a compartir con los amigos");
            break;
        case "DOMINGO":
            Console.WriteLine($"Hoy {diaSemana} a compartir con la familia");
            break;
        default:
            Console.WriteLine($"El dia ingresado es incorrecto");
            break;
    }
}


int sumaPrimerosCienNumeros()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma = suma + i;
    }
    return suma;
}


void ImprimirNumeroHastaNumeroEspecifico(int numero)
{
    Console.WriteLine($"Impresión de numeros del 1 hasta el {numero}");
    for (int i = 1;i <= numero; i++)
    {
        Console.WriteLine(i);
    }
}

double CalcularAreaCirculo(double radio)
{
    double areaCirculo = 0.0d;
    areaCirculo = Math.PI * Math.Pow(radio, 2);
    return Math.Round(areaCirculo, 2);
}

void ArregloUnidimensional()
{
    string[] cursos = new string[5];
    cursos[0] = "Matematica";
    cursos[1] = "Lenguaje";
    cursos[2] = "Historia";
    cursos[3] = "Educación Fisica";
    cursos[4] = "Quimica";

    Console.WriteLine("Los elementos de mi arreglo son :");
    int i = 1;
    foreach (var item in cursos)
    {
        Console.WriteLine($"{i} => { item}");    
        i++;
    }

}

void MostrarPersonasLista()
{

    List<string> personas = new List<string>();


    string nommbre = string.Empty;
    bool salir = false;
    string letra = string.Empty;
    do
    {
        Console.WriteLine("Ingrese nombre Persona");
        nommbre = Console.ReadLine();
        personas.Add(nommbre);

        Console.WriteLine("Presione la letra S para salir");
        letra = Console.ReadLine();

        if (letra.ToUpper() == "S")
            salir = true;

    } while (!salir);

    Console.WriteLine("La lista de personas registradas es :");
    foreach (var item in personas)
    {
        Console.WriteLine(item);
    }
}



int opcion = 0;
int numero = 0;
string diaSemana = string.Empty;
double radio = 0;


Console.WriteLine("BIENVENIDO AL SISTEMA");
Console.WriteLine("\n");
do
{
    Console.WriteLine("INGRESE UNA DE LAS SIGUIENTES OPCIONES");
    Console.WriteLine("===========================");
    Console.WriteLine("\n");
    Console.WriteLine("1.Determinar si un numero es positivo, negativo o cero");
    Console.WriteLine("2.Imprimir mensaje segun dia de la semana");
    Console.WriteLine("3.Calcular la suma de los primeros 100 numero naturales");
    Console.WriteLine("4.Imprimir numeros desde el numero 1 hasta un determinado numero");
    Console.WriteLine("5.Calcular el area de un circulo");
    Console.WriteLine("6.Mostrar elementos de un arreglo unidemensional predefinido");
    Console.WriteLine("7.Mostrar nombres de personas almacenados en una lista predefinida");
    Console.WriteLine("8.Salir del sistema");


    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        
        case 1:            
            Console.WriteLine("Ingrese el numero a evaluar");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El numero {numero} es : { TipoDeNumero(numero) } ");
            Console.WriteLine("\n");
            break;

        case 2:
            Console.WriteLine("Ingrese el dia de la semana");
            diaSemana = Console.ReadLine();
            MensajeSegunDiaSemana(diaSemana);
            Console.WriteLine("\n");
            break;

        case 3:
            Console.WriteLine($"La suma de los primero 100 numero es : {sumaPrimerosCienNumeros()}");
            Console.WriteLine("\n");
            break;

        case 4:
            Console.WriteLine("Ingrese el numero de finalización de impresión");
            numero = Convert.ToInt32(Console.ReadLine());
            ImprimirNumeroHastaNumeroEspecifico(numero);
            Console.WriteLine("\n");
            break;

        case 5:
            Console.WriteLine("Ingrese el radio del circulo");
            radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El area del ciruclo es : {CalcularAreaCirculo(radio)} ");
            Console.WriteLine("\n");
            break;

        case 6:
            ArregloUnidimensional();
            Console.WriteLine("\n");
            break;

        case 7:
            MostrarPersonasLista();
            Console.WriteLine("\n");
            break;

        default:
           
            break;
    }

}
while (opcion != 8);
