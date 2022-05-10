using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los 9 numeros del Social Security Number");
            List<char> ssn = new List<char>();
            ConsoleKeyInfo x = new ConsoleKeyInfo();
           


            for (int contador = 0; contador <= 10; contador++)
            {
                x = Console.ReadKey(true);

                if (contador == 9 || x.Key == ConsoleKey.Enter)
                {
                    SepararNumber(ssn);
                }
                else
                {
                    if(x.Key == ConsoleKey.Backspace)
                    {
                        Console.Write("\b \b");
                        if(ssn.Count != 0)
                        {
                            ssn.RemoveAt(ssn.Count - 1);
                        }
                        if(contador != 0)
                        {
                            contador--;
                        }
                        
                    }
                    
                    else
                    {
                        Console.Write(x.KeyChar);
                        ssn.Add(x.KeyChar);
                        
                    }
                    
                    
                    if (contador == 2)
                    {
                        Console.Write("-");
                    }
                    else if (contador == 4)
                    {
                        Console.Write("-");
                    }
                }
            }
        }

        //funcion para seprarar el SSN
        static void SepararNumber(List<char> SSN)
        {

             if(SSN.Count < 9)
             {
                Console.WriteLine(Environment.NewLine + "Numero SSN incompleto"); 
               return;
             }
            
            int cont = 0;
            
            string part1S = "", part2S = "", part3S = "";
            int part1 = 0, part2 = 0, part3 = 0;
            foreach (char number in SSN)
            {
                
                if(number != '0' && number != '1' && number != '2' && number != '3' && number != '4' && number != '5' && number != '6' && number != '7' && number != '8' && number != '9')
                {
                    Console.WriteLine(System.Environment.NewLine + "caracter especial no permitido, SSN invalido");  
                    return;
                }
                if(cont < 3)
                {
                    part1S += number;
                    
                }
                else if(cont >= 3 && cont < 5)
                {
                    part2S += number;
                }
                else
                {
                    part3S += number;
                }

                

                cont++;
            }
            part1 = Convert.ToInt32(part1S);
            part2 = Convert.ToInt32(part2S);
            part3 = Convert.ToInt32(part3S);

            



            IsAValidNumber(part1, part2, part3);
        }

        static void IsAValidNumber(int part1, int part2, int part3)
        {
            bool check1 = false, check2 = false, check3 = false;

            if(part1 == 0 && part2 == 0 && part3 == 0)
            {
                Console.WriteLine(Environment.NewLine + "No se puede procesar un numero vacío");
            }

            if(part1 == 000 || part1 == 666 || (part1 >= 900 && part1 <= 999))
            {
                Console.WriteLine(Environment.NewLine + "El SSN introducido no es un número válido" + " " + "Parte incorrecta: parte 1");
            }
            else
            {
                check1 = true;
            }
            if(part2 >= 01 && part2 <= 99)
            {
                check2 = true;
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "El SSN introducido no es un número válido" + " " + "Parte incorrecta: parte 2");
            }
            if(part3 >= 0001 && part3 <= 9999)
            {
                check3 = true;
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "El SSN introducido no es un número válido" + " " + "Parte incorrecta: parte 3");
            }


            if(check1 == true && check2 == true && check3 == true)
            {
                Console.WriteLine(Environment.NewLine + "El SSN introducido es un número válido");
            }
        }

    }
}
