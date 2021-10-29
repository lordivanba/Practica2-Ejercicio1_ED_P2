using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace practica2_ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string palabraInvertida = "";
            var pilaLetras = new Stack<char>();

            System.Console.WriteLine("\nIngrese la palabra que desee invertir\n");
            palabra = Console.ReadLine();

            var listLetras = palabra.ToList();
            
            //Se agrega cada letra de la palabra en la pila
            foreach(var item in listLetras){
                pilaLetras.Push(item);
            }

            foreach (var item in pilaLetras)
            {
                palabraInvertida = palabraInvertida + item;
            }
            
            System.Console.WriteLine($"Palabra original: {palabra}\nPalabra invertida: {palabraInvertida}");
            
        }
    }
}
