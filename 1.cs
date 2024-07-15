using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{

    internal class Program
    {
        static void Main()
        {
            string[] name;
            int[] age;

            Console.WriteLine("enter the length of the arrays");
            int size = int.Parse(Console.ReadLine());
            name = new string[size];
            age = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter the values");
                name[i] = Console.ReadLine();
                age[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("which member do you want to know? ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(name[j]);
            Console.WriteLine(age[j]);
        }




    }
}