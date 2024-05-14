// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Ejercicio 1
/* int num = 0;
string cad = Console.ReadLine();
bool result = int.TryParse(cad, out num);

if (result){
    Console.WriteLine("Ingreso un numero y el nuemero es:" + num);
}
else{
    Console.WriteLine("No ingreso un numero");
}

int aux = 0;
int aux2 = num;
int acumulador = 0;

while (num > 0)
{
        aux = num % 10;
        num = num / 10;
        acumulador = acumulador * 10 + aux;
}

Console.WriteLine($"El numero ingresado es: {aux2} y el numero invertido es: {acumulador}"); */

//Ejercicio 2 

int num1 = 0;
int num2 = 0;
int opcion = 0;

do {
    Console.WriteLine("Ingresar 1 si desear sumar");
    Console.WriteLine("Ingresar 2 si desear restar");
    Console.WriteLine("Ingresar 3 si desear multiplicar");
    Console.WriteLine("Ingresar 4 si desear dividir");
    int operacion = Convert.ToInt32(Console.ReadLine());
    switch (operacion)
    {
        case 1:
            Console.WriteLine("Ingresar pimer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (num1 + num2));
            break;
        case 2:
            Console.WriteLine("Ingresar pimer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (num1 - num2));
            break;
        case 3:
            Console.WriteLine("Ingresar pimer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (num1 * num2));
            break;
        case 4:
            Console.WriteLine("Ingresar pimer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (num1 / num2));
            break;
    }

    Console.WriteLine("Ingresar 1 si desea seguir operando, ingresar 0 si ya no desea operar");
    
}while(opcion == 1);