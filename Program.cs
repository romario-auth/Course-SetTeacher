using System;
using System.Collections.Generic;
using Teacher.Services;

namespace Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Statistics tearch = new Statistics();
            
            Console.WriteLine();
            Console.Write("How many students for course A? ");
            int courserA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= courserA; i++)
            {
                tearch.AddStudents(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many student for course B? ");
            int courserB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= courserB; i++)
            {
                tearch.AddStudents(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many student for course C? ");
            int courserC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= courserC; i++)
            {
                tearch.AddStudents(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Total students: " + tearch.TotalStudents());

        }
    }
}
