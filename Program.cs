using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{ 

    public class Program
    //    {
    //        static void Main(string[] args)
    //        {

    //            Team india = new Team();


    //            foreach (Player p in india)
    //            {
    //                Console.WriteLine(p);
    //            }

    //        }
    //    }



    //{
    //    static void Main(string[] args)
    //{
    //    Product p1 = new Product(1500, "XZZ");
    //    Product p2 = new Product(1400, "TPP");

    //    int result = p1.CompareTo(p2); // -1 , 1 , 0

    //    if (result < 0)
    //    {
    //        Console.WriteLine("p1 has less price than p2");
    //    }
    //    else if (result > 0)
    //    {
    //        Console.WriteLine("p1 has more runs than p2");
    //    }
    //    else
    //    {
    //        Console.WriteLine("p1 & p2 has same runs");
    //    }
    //}
    {
         static void Main(string[] args)
        {


            Employee Jayesh = new Employee { Sallary = 15000, Name = "Jayesh" };
            Employee Omkar = new Employee {Sallary = 14000, Name = "Omkar"};

            SallaryComparison obj = new SallaryComparison();
            int result = obj.Compare(Jayesh,Omkar);


            if (result < 0)
            {
                Console.WriteLine("Jayesh has less sallary than Omkar");
            }
            else if (result > 0)
            {
                Console.WriteLine("Jayesh has more Sallary than Omkar");
            }
            else
            {
                Console.WriteLine("Jayesh & Omkar has same Sallary");

            }
        }
    }
}
