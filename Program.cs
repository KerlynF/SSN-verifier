using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Lab_de_tendencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los 9 numeros del Social Security Number");
            List<int> ssn = new List<int>();
            ConsoleKeyInfo x = new ConsoleKeyInfo();
            int contador = 0;
            
            
            for( x = Console.ReadKey(true); x.Key != ConsoleKey.Enter; x = Console.ReadKey(true))
            {
               if(contador == 9)
               {
                   // ValidNumber();
               }
               else{
                Console.Write(x.KeyChar);
                ssn.Add(Convert.ToInt32(x.KeyChar));
                ssn
                contador++;
                if(contador == 3){
                    Console.Write("-");
                }
                else if(contador == 5){
                    Console.Write("-");
                }
               } 
            }


            


        }
        //funcion para validar el SSN
        static void ValidNumber(List<int> SSN)
        {
            foreach (int number in SSN)
            {
                
            }
        }
        
    }
}
