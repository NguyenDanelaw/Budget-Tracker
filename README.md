# 💲 Budget Tracker

A simple console-based budget tracking application that helps you record and analyze your income and expenses in Vietnamese Dong (₫).

## ⛏ Features

- **Add Transactions**: Record income (positive amounts) and expenses (negative amounts) with descriptions
- **View All Transactions**: See a complete list of your financial activities
- **Financial Summary**: Get an overview of your total income, expenses, and net balance
- **Vietnamese Dong Support**: Formatted with "₫" currency symbol and Vietnamese culture settings

## ❓ How to Use

1. **Main Menu Options**:
   - `1`: Add a new transaction
   - `2`: List all recorded transactions
   - `3`: View financial summary
   - `4`: Exit the application

2. **Adding a Transaction**:
   - Enter a description (e.g., "Salary", "Groceries")
   - Enter the amount:
     - Positive values for income (e.g., 1000000)
     - Negative values for expenses (e.g., -500000)

3. **Transaction List**:
   - Displays all transactions with:
     - Date of transaction
     - Type (Income/Expense)
     - Description
     - Formatted amount

4. **Financial Summary**:
   - Shows:
     - Total income
     - Total expenses (as positive value)
     - Net balance (income minus expenses)

## Technical Details

- **Language**: C#
- **.NET Version**: Requires .NET 5.0 or later
- **Data Storage**: In-memory (transactions are not persisted between runs)
- **Culture Settings**: Uses Vietnamese culture (vi-VN) with "₫" as currency symbol

## 💨 Getting Started

1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed
2. Clone or download the project
3. Navigate to the project directory in your terminal
4. Run the application:
   ```bash
   dotnet run
