using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foothill_Project.Simple_Inventory_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Amount = 1000;
            var Members = 2;
            Members= Reduce(Members, 2);
            Console.WriteLine(Distribute(Amount, Members));
            Console.ReadLine();
        }
        static int Reduce(int members, int value)
        {
           return members -= value;
        }
        static int Distribute(int amount, int members)
        {
            try
            {
                return amount / members;    
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Anything");
            }
            return 0;
        }
    }
}
