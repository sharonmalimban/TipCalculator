using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Needed: bill amount, percentage of tip, tip amount and total bill
            // prompt user for total bill amount
            // prompt how much you want to tip/percentage
            //parse input (convert to string to number)
            // calculate percentage (total bill * percentage/100)
            // Inform user of tip amount 
            // Display total bill + tip

            Console.WriteLine("Enter the bill amount: ");
            string billAmountInput = Console.ReadLine();
            billAmountInput = billAmountInput.Trim();
            billAmountInput = billAmountInput.Trim('$');

            Console.WriteLine("What percent would you like to tip? ");
            string tipPercentInput = Console.ReadLine();
            // tipPercentInput = tipPercentInput.Trim();
            // tipPercentInput = tipPercentInput.Trim('%');
            tipPercentInput = tipPercentInput.Trim().Trim('%');

            double tipPercentage;
            if(!double.TryParse(tipPercentInput, out tipPercentage))
            {
                Console.WriteLine($"Invalid tip.");
                Console.ReadLine();
            }

            decimal bill = decimal.Parse(billAmountInput);
            int tipPercent = int.Parse(tipPercentInput);

            decimal tipAmount = tipPercent * bill / 100;
            decimal totalBillAmount = bill + tipAmount;
            decimal roundedTipAmount = Math.Round(tipAmount, 2);
            totalBillAmount = Math.Round(totalBillAmount, 2);

            Console.WriteLine($"Your tip amount is ${tipAmount}.");
            Console.WriteLine($"Your Total Bill plus tips is ${totalBillAmount}.");

            Console.ReadLine();
        }
    }
}
