using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// To check if the given requirement is possible we must check the following condition:
// sum * i % n == 0 where sum is the sum of the elements of the array, n is the number of elements in the array, and i goes from 1 to n-1
// This algorithm is valid for all integer arrays, and is actually not a lot of coding involved, it's mostly maths behind this problem

namespace UMTSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            string nstr;
            int n,aux, i, sum = 0;
            int[] A = new int[30];
            Console.WriteLine("Please enter the maximum number of your array,as an integer, please be carefull the array will keep registering numbers until it hits maximum capacity");
            nstr = Console.ReadLine();
            if(int.TryParse(nstr, out aux ))
            {
                n = aux;
            }
            else
            {
                n = 10;
                Console.WriteLine("Number you entered didn't respect the number format, max number set as 10");
            }

            Console.WriteLine("Please enter members of your array, again as integers");
            for(i = 0; i<n; i++)
            {
                try
                {
                    A[i] = Convert.ToInt32(Console.ReadLine());
                    sum = sum + A[i];
                  
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number format incorrect, please enter integer");
                }
            }

            Console.WriteLine("Your array can be split in two separate arrays with equal averages : {0}",isPossible(n, sum));
            Console.ReadLine();
        }
        // metoda prin care verificam conditia matematica care demonstreaza ca matricea noastra poata sa fie impartita in doua matrici cu medii aritmetice egale
        static bool isPossible (int n, int sum)
        {
            bool possible = false;
            for( int i = 0; i<= n; i++)
            {
                if (sum * i % n == 0)
                    possible = true;
            }
            return possible;
        }
    }
}
