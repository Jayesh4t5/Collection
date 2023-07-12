using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{

    public class Employee
    {
        public int Sallary { get; set; }
        public string Name { get; set; }
    }

    public class SallaryComparison : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y) // X-> Jayesh, y-> Omkar
        {
            if (x.Sallary < y.Sallary)
            {
                return -1;
            }
            else if (x.Sallary > y.Sallary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

}
