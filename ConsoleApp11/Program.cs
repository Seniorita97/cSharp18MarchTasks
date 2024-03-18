using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsPrime(52)
            int[] arr = { 70, 95, 60, 80, 30 };
            int sum = CalcAvg(arr);
            double average = sum / arr.Length;
            if(average > 60)
            {
                Console.WriteLine("Tebrikler, Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Teesufki Telebe ola bimedeniz");
            }
        }
        static void IsPrime(int n)
        {
            bool check = true;
            if (n <= 1) 
            {
                check = false;
            }
            else 
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {

                        check = false;
                        break;

                    }
                }
            }
          
            Console.WriteLine(check);
        }


        static int CalcAvg(int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            return sum;
        }


    }
}
