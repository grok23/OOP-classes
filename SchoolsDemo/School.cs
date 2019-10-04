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
            // Alphabetic sort if StudentCount is equal. [A to Z]
            if (this.StudentCount == other.StudentCount)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to StudentCount sort. [High to low]
            return other.StudentCount.CompareTo(this.StudentCount);
        }

        public override string ToString()
        {
            // String representation.
            return this.StudentCount.ToString() + "," + this.Name;
        }
    }
}
