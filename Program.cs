﻿// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions; 

Console.WriteLine("Hello, World!");
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
}

