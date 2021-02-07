using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Strategy;
using Design_Patterns.Chain_Of_Responsibility;

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

            // implementing Chain Of Responsability
            CalculateDiscount calculateDiscount = new CalculateDiscount();

            BudgetDiscount budgetDiscountOne = new BudgetDiscount(7.0f);
            budgetDiscountOne.AddItemToList(new Item(" Pen ",2.0f));
            budgetDiscountOne.AddItemToList(new Item(" Pen ",2.0f));
            budgetDiscountOne.AddItemToList(new Item(" Eraser ",1.0f));
            budgetDiscountOne.AddItemToList(new Item(" Eraser ",1.0f));
            budgetDiscountOne.AddItemToList(new Item(" Eraser ",1.0f));
          

            float discount = calculateDiscount.Discount(budgetDiscountOne);
            Console.WriteLine("DIscount: " + discount);

            BudgetDiscount budgetDiscountTwo = new BudgetDiscount(510.0f);
            budgetDiscountTwo.AddItemToList(new Item(" caneta ",250.0f));

            discount = calculateDiscount.Discount(budgetDiscountTwo);
            Console.WriteLine("Discount: " + discount);


            Console.ReadKey();
        }
    }
}
