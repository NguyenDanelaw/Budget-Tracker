# 📖 How to Use the Budget Tracker  

A simple guide to managing your finances with this C# console application.  

## 🏁 **Getting Started**  

1. **Run the Application**  
   ```bash
   dotnet run
   ```
   *(Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed!)*  

2. **You’ll see the main menu**:  
   ```
   ------------- BUDGET TRACKER -------------
   1. Add a transaction
   2. List transactions
   3. View summary
   4. Exit
   ```
   Use the **number keys (1-4)** to navigate.  

## 📥 **1. Adding a Transaction**  

▶ **Step 1:** Select **`1`** from the menu.  
▶ **Step 2:** Enter a **description** (e.g., `🍕 Pizza night`).  
▶ **Step 3:** Enter the **amount**:  
   - **💰 Income** → Positive number (e.g., `5000000`)  
   - **💸 Expense** → Negative number (e.g., `-200000`)  

✅ **Done!** The transaction is saved.  

## 📋 **2. Listing All Transactions**  

▶ **Step 1:** Select **`2`** from the menu.  
▶ **Step 2:** View your transactions in a clean table:  
   ```
   Date           Type      Description       Amount
   -----------------------------------------------
   2024-05-01     Income    Salary           +10,000,000₫  
   2024-05-02     Expense   Groceries        -500,000₫  
   ```
▶ **Step 3:** Press any key to return to the menu.  

## 📊 **3. Viewing Financial Summary**  

▶ **Step 1:** Select **`3`** from the menu.  
▶ **Step 2:** Check your financial health:  
   ```
   Total income:   10,000,000₫  
   Total expenses: 500,000₫  
   Net balance:    9,500,000₫  
   ```
▶ **Step 3:** Press any key to go back.

## 🚪 **4. Exiting the App**  

▶ Select **`4`** to safely exit.  
*(Note: Transactions are stored in memory and will reset when you close the app. We are working to let it save in a .txt file.)*
