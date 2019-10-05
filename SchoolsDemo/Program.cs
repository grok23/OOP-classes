using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class Program
    {
        static void Main(string[] args)
        {  
            //create a list to hold the School objects
            List<School> edu = new List<School>();

            for (int i = 0; i < 5; i++)    //for loop runs 5 times to limit the number of schools
            {
                string name ="";
                int nums = 0;
                Console.Write("Please enter school name: ");
                name = Console.ReadLine();
                Console.Write("Please enter school enrolment numbers: ");
                nums = int.Parse(Console.ReadLine());
                edu.Add(new School() { Name = name, StudentCount = nums}); //generates an object in the list using the getters/setters from the School class 
            }

            //Using IComparable.CompareTo() to sort the list
            edu.Sort();

            //Use School.ToString to display the newly sorted list
            Console.WriteLine("\nSorted Schools: ");
            foreach (var school in edu)
            {
                Console.WriteLine(school);
            }
            Console.WriteLine("\n");

            //prompt user to decide minimum enrolment to show
            Console.Write("Please choose the minimum enrolment to display: ");           
            int minCount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            foreach (var school in edu)
            {
                if (school.StudentCount >= minCount)
                {
                    Console.WriteLine(school);
                }
            }
        }     
    }
}
