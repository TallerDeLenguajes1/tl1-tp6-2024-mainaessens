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
string cadena, cadena1;
float numero; 

    do{

        Console.WriteLine("\nINGRESE NUMERO: ");
        cadena1 = Console.ReadLine(); 

    } while(!float.TryParse(cadena1, out numero)); 


do {
    Console.WriteLine("\n---CALCULADORA---");
    Console.WriteLine("1: VALOR ABSOLUTO");
    Console.WriteLine("2: CUADRADO");
    Console.WriteLine("3: RAIZ CUADRADA");
    Console.WriteLine("4: SENO");
    Console.WriteLine("5: COSENO");
    Console.WriteLine("6: PARTE ENTERA");
    Console.WriteLine("OTRO: SALIR\n");
    Console.WriteLine("\nINGRESE OPCION: ");
    cadena = Console.ReadLine(); 
    int.TryParse(cadena, out opcion); 


    switch (opcion){
    case 1: 
        float valorAbs = Math.Abs(numero);
        Console.WriteLine($"EL VALOR ABSOLUTO ES: {valorAbs}"); 
        break;    
    case 2: 
        double cuadrado = numero * numero; 
        Console.WriteLine($"EL CUADRADO ES: {cuadrado}"); 
        break;       
    case 3: 
        if(numero>=0){
            double raiz = Math.Sqrt(numero); 
            Console.WriteLine($"LA RAIZ CUADRADA ES: {raiz}"); 
        }else {
            Console.WriteLine("ERROR: NO ES POSIBLE CALCULAR LA RAIZ CUADRADA."); 
        }
        break;   
    case 4: 
        double seno = Math.Sin(numero); 
        Console.WriteLine($"EL SENO ES: {seno}"); 
        
        break;
    case 5: 
        double coseno = Math.Cos(numero); 
        Console.WriteLine($"EL COSENO ES: {coseno}"); 
        
        break;
    case 6: 
        int parteEntera = (int)numero; 
        Console.WriteLine($"LA PARTE ENTERA ES: {parteEntera}"); 
        
        break;
    default:
        opcion = 0; 
        break; 
}
    
} while (opcion != 0);


