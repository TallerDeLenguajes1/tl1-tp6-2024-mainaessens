// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions; 

/*Console.WriteLine("Hello, World!");
int a; 
int b; 
a = 10; 
b = a; 
Console.WriteLine("El valor de a es: "+a); 
Console.WriteLine("El valor de b es: "+b); 

Console.WriteLine("\n-----EJERCICIO 1-----\n");
Console.WriteLine("Ingrese un numero: "); 
string cadena = Console.ReadLine(); 
int num; 
int resto; 
int numInvertido = 0; 
if(int.TryParse(cadena, out num)){ //para pasar de string a entero
    if(num>0){
        while (num != 0)
        {
            resto = num%10; 
            num = num/10; 
            numInvertido = numInvertido*10 + resto; 
        }
        Console.WriteLine($"El numero invertido es: {numInvertido}" ); 
    }
}*/

Console.WriteLine("\n-----EJERCICIO 4-----\n"); 
int opcion; 
int num1, num2; 
string cadena; 

Console.WriteLine("\nINGRESE NUMERO 1: ");
string cadena1 = Console.ReadLine(); 
Console.WriteLine("\nINGRESE NUMERO 2: ");
string cadena2 = Console.ReadLine();

int.TryParse(cadena1, out num1);
int.TryParse(cadena2, out num2);

do {
    Console.WriteLine("---MENU---");
    Console.WriteLine("1: SUMAR");
    Console.WriteLine("2: RESTAR");
    Console.WriteLine("3: MULTIPLICAR");
    Console.WriteLine("4: DIVIDIR");
    Console.WriteLine("OTRO: SALIR\n");
    Console.WriteLine("\nINGRESE OPCION: ");
    cadena = Console.ReadLine(); 
    int.TryParse(cadena, out opcion); 

switch (opcion)
{
    case 1: 
        int suma = num1 + num2; 
        Console.WriteLine($"RESULTADO DE SUMA: {suma}"); 
        break;    
    case 2: 
        int resta = num1 - num2; 
        Console.WriteLine($"RESULTADO DE RESTA: {resta}"); 
        break;       
    case 3: 
        int prod = num1 * num2; 
        Console.WriteLine($"RESULTADO DE MULTIPLICACION: {prod}"); 
        break;   
    case 4: 
        if (num2!=0)
        {
            int cociente = num1/num2; 
            Console.WriteLine($"RESULTADO DE DIVISION: {cociente}");       
        } else if(num1 != 0){
            int cociente = num2/num1; 
            Console.WriteLine($"RESULTADO DE DIVISION: {cociente}"); 
        }else{
            Console.WriteLine("ERROR: DIVISION POR CERO");
        }
        
        break;
    default:
        opcion = 0; 
        break; 
}
    
} while (opcion != 0);

