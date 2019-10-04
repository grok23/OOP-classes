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
        {//schools data entry will be handled from here
            List<School> list = new List<School>();
            list.Add(new School() { Name = "St Patricks", StudentCount = 458 });
            list.Add(new School() { Name = "Magdalene", StudentCount = 1998 });
            list.Add(new School() { Name = "The Model", StudentCount = 64 });
            list.Add(new School() { Name = "Prep", StudentCount = 128 });
            list.Add(new School() { Name = "Sligo IT", StudentCount = 1024 });
            list.Add(new School() { Name = "Alpha", StudentCount = 1024 });
            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses School.ToString
            foreach (var school in list)
            {
                Console.WriteLine(school);
            }
        }

        
    }
}
