﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_Repeticiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Numeros correlativos del 1 hasta el ingresado:
            Objetivo: Escribir un programa que solicite la carga de un valor positivo 
            y nos muestre desde 1 hasta el valor ingresado de uno en uno
            */
            /*
            int valor;
            int contador = 1;
            Console.WriteLine("Ingrese un numero");
            valor = int.Parse(Console.ReadLine()); 
            while (contador <= valor) { 
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadLine(); 
            */
            /*
             *2. Carga y suma de 10 valores 
             *Objetivo: Desarrollar un programa que permita la carga de 10 valores por teclado 
             *y nos muestre posteriormente la suma de los valores ingresados y su promedio.
            */
            /*
            int cantIngresados = 1;
            int acumulador = 0;
            double promedio;
            int valor;

            while (cantIngresados <= 10) {
                Console.WriteLine($"Ingrese un valor numero {cantIngresados}");
                valor = int.Parse(Console.ReadLine());
                acumulador = acumulador + valor;
                cantIngresados++;
                    }
            promedio = acumulador / 10;
            Console.WriteLine($"Promedio: {promedio}");
            Console.ReadLine();
            */
            /*
             * 3. Fabrica de perfiles 
             * Objetivo: Una planta que fabrica perfiles de hierro posee un lote de piezas.
             * Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar 
             * y luego ingrese la longitud de cada perfil; sabiendo que la pieza cuya longitud este 
             * comprendida en el rango de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad
             * de piezas aptas que hay en el lote.
            */
            /*
            int contador = 1;
            int cantPiezasAptas = 0;
            int cantPiezas; 
            double medida;
            Console.WriteLine("Ingrese cantidad de piezas a analizar");
            cantPiezas = int.Parse(Console.ReadLine());
            while (contador <= cantPiezas) {
                Console.WriteLine($"Ingrese medida de la pieza numero {contador}");
                medida = double.Parse(Console.ReadLine());
                if (medida >=1.2 && medida <= 1.3)
                {
                    cantPiezasAptas++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de piezas aptas es {cantPiezasAptas}");
            */
            /*
             * 4.Nota de alumnos 
             * Objetivo: Escribir un programa que solicite ingresar 10 notas de alumnos 
             * y nos informe cuantos tienen notas mayores o iguales a 7 y cuantos menores.   
            */
            /*
            int notasMayoresIguales = 0, notasMenores = 0;
            int nota;
            int contador = 1;
            while (contador <= 10) 
            {
                Console.WriteLine($"Ingrese nota {contador}");
                nota = int.Parse(Console.ReadLine());
                if (nota < 7)
                {
                    notasMenores++;
                }
                else
                {
                    notasMayoresIguales++;
                }
                contador++;
            }
            Console.WriteLine($"Cantidad de notas mayores o iguales a 7: {notasMayoresIguales}");
            Console.WriteLine($"Cantidad menores a 7: {notasMenores}");
            */
            /*
             * Alturas de personas 
             * Objetivo: Se ingresan un conjunto de n alturas de personas por teclado. 
             * Mostrar la altura promedio de las personas 
            */
            /*
            int contador = 1;
            int n;
            double altura;
            double sumaAlturas = 0;
            Console.WriteLine("Ingrese cantidad de personas");
            n = int.Parse(Console.ReadLine());
            while (contador <= n) 
            {
                Console.WriteLine($"Ingrese altura de las persona {contador}");
                altura = double.Parse(Console.ReadLine());
                sumaAlturas = sumaAlturas + altura;
                contador++;
            }
            Console.WriteLine("El promedio es: " + sumaAlturas / n);  
            */
            /*
             * 7. Lectura de sueldos
             * Objetivo: En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
             * realizar un programa que lea los sueldos que cobra cada empleado e informe cuantos empleados 
             * cobran entre $100 y $300 y cuantos cobras mas de $300. Ademas el programa debera informar el importe 
             * que gasta la empresa en sueldos al personal.
            */
            /*
            int n, sueldo, cuentaMenores300 = 0, cuentaMayores = 0, sumaSueldos = 0, contador = 1;
            Console.WriteLine("Ingrese cantidad de empleados");
            n = int.Parse(Console.ReadLine());
            while (contador <= n) 
            {
                Console.WriteLine($"Ingrese sueldo empleado {contador}");
                sueldo = int.Parse(Console.ReadLine());
                if (sueldo > 300) 
                {
                    cuentaMayores++;
                }
                else
                {
                    cuentaMenores300++;
                }
                sumaSueldos = sumaSueldos + sueldo;
                contador++;
            }
            Console.WriteLine($"La empresa gasta en empleados:{sumaSueldos}");
            Console.WriteLine($"Sueldos mayores a 300: {cuentaMayores}");
            Console.WriteLine($"Sueldos menores de 300: {cuentaMenores300}");
            */
            Console.ReadLine();
        }// static Void 
    }
}
