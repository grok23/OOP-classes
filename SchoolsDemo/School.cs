using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
   
    class School : IComparable<School>
    {
        public int StudentCount { get; set; }
        public string Name { get; set; }

        public int CompareTo(School other)
        {
            //if Sorts alphabetically if StudentCount is equal (a to z)
            if (this.StudentCount == other.StudentCount)
            {
                return this.Name.CompareTo(other.Name);
            }
            //Default to StudentCount sort. (Low to High)
            return this.StudentCount.CompareTo(other.StudentCount);
        }

        public override string ToString()
        {
            return this.StudentCount.ToString() + ", " + this.Name;
        }
    }
}
