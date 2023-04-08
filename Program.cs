using System;
using FundamentosCSHARP.Models;
using System.Collections.Generic;
namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new { nombre = "Ana", apellido = "Muedas", edad = 27 };
            Console.WriteLine(persona.apellido);

            Console.WriteLine("Hello World!");
            Bebida bebida = new Bebida("Coca Cola", 1000);
            bebida.Beber(500);
            Console.WriteLine(bebida.Cantidad);
            Cerveza cerveza = new Cerveza();
            Console.WriteLine(cerveza.Cantidad);

            int[] numeros = new int[5] { 1,2,3,4,5 };
            int numero = numeros[0];
            Console.WriteLine(numero);

            for(int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            foreach(var numerito in numeros)
            {
                Console.WriteLine(numerito);
            }

            List<int> lista = new List<int>() { 1, 2, 3, 4 };
            lista.Add(5);
            lista.Add(6);
            Console.WriteLine(lista);

            foreach (var valor in lista)
            {
                Console.WriteLine(valor);
            }

        }
    }
}
