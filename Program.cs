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
double num3 = 0;
do {
    Console.WriteLine("Ingresar 1 si desear sumar");
    Console.WriteLine("Ingresar 2 si desear restar");
    Console.WriteLine("Ingresar 3 si desear multiplicar");
    Console.WriteLine("Ingresar 4 si desear dividir");
    Console.WriteLine("Ingresar 5 si desea el valor absoluto de un numero");
    Console.WriteLine("Ingresar 6 si desea elevar el numero al cudrado");
    Console.WriteLine("Ingresar 7 si desea la raiz cuadrada del numero");
    Console.WriteLine("Ingresar 8 si desea el seno del numero");
    Console.WriteLine("Ingresar 9 si desea el coseno del numero");
    Console.WriteLine("Ingresar 10 si desea la parte entera de un numero entero");
    int operacion = Convert.ToInt32(Console.ReadLine());
    switch (operacion)
    {
        case 1:
            Console.WriteLine("Ingresar primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (num1 + num2));
            break;
        case 2:
            Console.WriteLine("Ingresar primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La resta es: " + (num1 - num2));
            break;
        case 3:
            Console.WriteLine("Ingresar primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La multiplicacion es: " + (num1 * num2));
            break;
        case 4:
            Console.WriteLine("Ingresar primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La division es: " + (num1 / num2));
            break;
        case 5:
            Console.WriteLine("Ingresar el numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            int va = Math.Abs(num1);
            Console.WriteLine("El valor absoluto es: " + (va));
            break;
        case 6:
            Console.WriteLine("Ingresar el nuemero");
            num1 = Convert.ToInt32(Console.ReadLine());
            double cuadrado = Math.Pow(num1, 2);
            Console.WriteLine("El cudrado del numero es: "+ cuadrado);
            break;
        case 7:
            Console.WriteLine("Ingresar el nuemero");
            num1 = Convert.ToInt32(Console.ReadLine());
            double raiz = Math.Sqrt(num1);
            Console.WriteLine("La raiz del numero es: "+ raiz);
            break;
        case 8:
            Console.WriteLine("Ingresar el nuemero");
            num1 = Convert.ToInt32(Console.ReadLine());
            double seno = Math.Sin(num1);
            Console.WriteLine("El seno del numero es: "+ seno);
            break;
        case 9:
            Console.WriteLine("Ingresar el nuemero");
            num1 = Convert.ToInt32(Console.ReadLine());
            double coseno = Math.Cos(num1);
            Console.WriteLine("El seno del numero es: "+ coseno);
            break;
        case 10:
            Console.WriteLine("Ingresar el numero");
            double.TryParse(Console.ReadLine(), out num3);
            double entera = Math.Floor(num3);
            Console.WriteLine("La parte entera del numero es: " + entera);
            break;
    }

    Console.WriteLine("Ingresar 1 si desea seguir operando, ingresar 0 si ya no desea operar");
    opcion = Convert.ToInt32(Console.ReadLine());
}while(opcion == 1); 