﻿using System;
using Design_Patterns.Strategy;
using Design_Patterns.Chain_Of_Responsibility;
using Design_Patterns.Method_Template;
using Design_Patterns.Decorator;
using Design_Patterns.State;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Strategy-----------------------------------------------------
            ");
            // Implementing Strategy 
            Budget budget = new Budget(50.0f);
            ISS iss = new ISS();
            Icms icms = new Icms();
            CalculateTax calculateTax = new CalculateTax();

            calculateTax.CalculateTaxes(budget, iss);
            calculateTax.CalculateTaxes(budget, icms);

            Console.WriteLine(@"
            Chain Of Responsability--------------------------------------
            ");
            // Implementing Chain Of Responsability

            CalculateDiscount calculateDiscount = new CalculateDiscount();

            BudgetDiscount budgetDiscountOne = new BudgetDiscount(7.0f);
            budgetDiscountOne.AddItemToList(new Item(" Pen ", 2.0f));
            budgetDiscountOne.AddItemToList(new Item(" Pen ", 2.0f));
            budgetDiscountOne.AddItemToList(new Item(" Eraser ", 1.0f));
            budgetDiscountOne.AddItemToList(new Item(" Eraser ", 1.0f));
            budgetDiscountOne.AddItemToList(new Item(" Eraser ", 1.0f));


            var result = calculateDiscount.Discount(budgetDiscountOne);
            Console.WriteLine("DIscount: " + result);

            BudgetDiscount budgetDiscountTwo = new BudgetDiscount(510.0f);
            budgetDiscountTwo.AddItemToList(new Item(" caneta ", 250.0f));

            result = calculateDiscount.Discount(budgetDiscountTwo);
            Console.WriteLine("Discount: " + result);

            Console.WriteLine(@"
            Method Template----------------------------------------------
            ");
            // Implementing Method Template

            ICPP icpp = new ICPP();
            IKCV ikcv = new IKCV();
            IHIT ihit = new IHIT();

            BudgetTax budgetTax = new BudgetTax(501);
            budgetTax.AddItemToList(new ItemTemplate("ToyCarr", 50.0f));
            budgetTax.AddItemToList(new ItemTemplate("ToyCarr", 50.0f));


            result = icpp.tax(budgetTax);
            Console.WriteLine("Discount method: " + result);

            result = ikcv.tax(budgetTax);
            Console.WriteLine("Discount method2: " + result);

            result = ihit.tax(budgetTax);
            Console.WriteLine("Discount method3: " + result);

            Console.WriteLine(@"
            Decorator ---------------------------------------------------
            ");
            // Implementing Decorator

            TaxDecorator tax = new ISSDecorator(new IcmsDecorator());
            TaxDecorator tax1 = new ISSDecorator(new ICPPDecorator());
            TaxDecorator tax2 = new ISSDecorator(new HigTaxDecorator());
            TaxDecorator tax3 = new ISSDecorator(new IKCVDecorator());

            BudgetDecorator budgetDecorator = new BudgetDecorator(5864.35f);
            budgetDecorator.AddItemToList(new ItemDecorator("car", 150));
            budgetDecorator.AddItemToList(new ItemDecorator("car", 50));
            budgetDecorator.AddItemToList(new ItemDecorator("tiny toy", 150));


            result = tax.Tax(budgetDecorator);
            Console.WriteLine("Tax Decorator: " + result);

            result = tax1.Tax(budgetDecorator);
            Console.WriteLine("Tax Decorator: " + result);

            result = tax2.Tax(budgetDecorator);
            Console.WriteLine("Tax Decorator: " + result);

            result = tax3.Tax(budgetDecorator);
            Console.WriteLine("Tax Decorator: " + result);

            Console.WriteLine(@"    
            State ------------------------------------------------------
            ");
            // Implementing State

            BudgetState Account = new BudgetState(0);

            result = Account.Balance;
            Console.WriteLine("Balance: " + result);

            Account.DepositMoney(50.0f);

            result = Account.Balance;
            Console.WriteLine("Balance: " + result);


            Console.ReadKey();
        }
    }
}
