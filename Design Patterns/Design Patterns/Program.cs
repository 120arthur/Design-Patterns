using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Strategy;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementing Strategy examples
            Budget budget = new Budget(50.0f);
            ISS iss = new ISS();
            Icms icms = new Icms();
            CalculateTax calculateTax = new CalculateTax();

            calculateTax.CalculateTaxes(budget, iss);
            calculateTax.CalculateTaxes(budget, icms);

            Console.ReadKey();
        }
    }
}
