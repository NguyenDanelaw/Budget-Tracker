using System;
using System.Collections.Generic;
using System.Globalization;

record Transaction(DateTime Date, string Description, decimal Amount)
{
    public string Type => Amount >= 0 ? "Income" : "Expense";
}

class Program
{
    static void Main()
    {
        // Clone the vi-VN culture and set the currency symbol to "đ"
        var vndCulture = (CultureInfo)CultureInfo.GetCultureInfo("vi-VN").Clone();
        vndCulture.NumberFormat.CurrencySymbol = "đ";
        CultureInfo.DefaultThreadCurrentCulture = vndCulture;
        CultureInfo.DefaultThreadCurrentUICulture = vndCulture;

        var transactions = new List<Transaction>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("------------- BUDGET TRACKER -------------");
            Console.WriteLine("1. Add a transaction");
            Console.WriteLine("2. List transactions");
            Console.WriteLine("3. View summary");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTransaction(transactions);
                    break;
                case "2":
                    ListTransactions(transactions);
                    break;
                case "3":
                    ViewSummary(transactions);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AddTransaction(List<Transaction> transactions)
    {
        Console.Write("Enter description: ");
        string? description = Console.ReadLine();

        decimal amount;
        while (true)
        {
            Console.Write("Enter amount (positive for income, negative for expense): ");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out amount))
                break;
            Console.WriteLine("Invalid amount. Please enter a valid number.");
        }

        transactions.Add(new Transaction(DateTime.Now, description ?? "", amount));
        Console.WriteLine("Transaction added. Press any key to continue...");
        Console.ReadKey();
    }

    static void ListTransactions(List<Transaction> transactions)
    {
        Console.WriteLine("\nDate\t\tType\t\tDescription\tAmount");
        Console.WriteLine("-------------------------------------------------------------");
        foreach (var t in transactions)
        {
            Console.WriteLine($"{t.Date:yyyy-MM-dd}\t{t.Type}\t\t{t.Description}\t{t.Amount:C0}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void ViewSummary(List<Transaction> transactions)
    {
        decimal totalIncome = 0, totalExpense = 0;
        foreach (var t in transactions)
        {
            if (t.Amount >= 0)
                totalIncome += t.Amount;
            else
                totalExpense += t.Amount;
        }
        Console.WriteLine($"\nTotal income:   {totalIncome:C0}");
        Console.WriteLine($"Total expenses: {Math.Abs(totalExpense):C0}");
        Console.WriteLine($"Net balance:    {(totalIncome + totalExpense):C0}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}