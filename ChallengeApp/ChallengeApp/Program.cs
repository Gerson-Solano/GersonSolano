using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using ChallengeApp.models;
namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            challenge challenge = new challenge();
            // Crear una instancia de Person utilizando el constructor
            //Person p = new Person(1, "Gerson", "Solano", new DateTime(2000, 10, 23));

            // challenge.MultiplyWithoutOperator(3, 6);
            //challenge.TenPrimeNumbers();
            int[] newArray = { 18, 2, 6, 9, 15, 3, 7, 4, 11 };
            challenge.MaxandMinFromArray(newArray);
            // Utilizar el método ToString() para imprimir información sobre la persona
            //Console.WriteLine(p.ToString());
            // Console.WriteLine(challenge.isPalindromo("A casaca"));
        }
    }
    
    
    
    
    //Crear una funci6n que copie todas Ias propiedades y sus valores de un objeto en Otrol


    class challenge
    {
        // 1- Write a funtion that detected if the string is a palindromo: "a casaca".
        public bool isPalindromo(String pharse)
        {
           
            String[] text = pharse.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            String tempTxt = "";
            foreach (string letra in text)
            {
                Console.WriteLine("Letra: "+letra);
                tempTxt += string.Join("", letra);
            }
            string resultado = string.Join("", pharse.Split(' '));
            
            if (resultado.ToLower().Equals(tempTxt.ToLower()))
            {
                return true;
            }
            return false;

        }

        //Multiplicar dos nümeros sin utilizar el sfrnbolo de multiplicaci6n o de divisi6n.
        public void MultiplyWithoutOperator(int a, int b)
        {
            var maxNumber = 0;
            var minNumber = 0;
            var result = 0;
            if (a >= b)
            {
                maxNumber = a;
                minNumber = b;
            }
            else
            {
                maxNumber = b;
                minNumber = a;
            }
            for (int i = 0; i < maxNumber; i++)
            {
                result += minNumber;
            }
            Console.WriteLine(a+" * "+b+" es igual a: "+result);
        }

        //Imprimir los primeros 10 nümeros primos
        public void TenPrimeNumbers()
        {
            for (int i = 2; i < 30; i++)
            {
                if (i/i == 1 && (i%3!=0 && i % 2 != 0) )
                {
                    Console.WriteLine(i);

                    Console.WriteLine(i % i);
                }
            }
        }

        public void MaxandMinFromArray(int[] newArray)
        {
            int max = 0;
            int min = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == 0)
                {
                    max = newArray[i];
                    min = newArray[i];
                }
                else{

                    if (max<i)
                    {
                        max = newArray[i];
                    }
                    else if (min>i){
                        min = newArray[i];
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}



