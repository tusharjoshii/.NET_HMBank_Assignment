using Assignment9;
public class BankApp
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Calculate Interest");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Call bank.CreateAccount() method
                    Console.Write("Enter Account Type (1 for Savings, 2 for Current): ");
                    int accountType = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    if (accountType == 1)
                    {
                        Console.Write("Enter Interest Rate: ");
                        decimal interestRate = Convert.ToDecimal(Console.ReadLine());
                        bank.CreateAccount(new SavingsAccount(0, customerName, balance, interestRate));
                    }
                    else if (accountType == 2)
                    {
                        Console.Write("Enter Overdraft Limit: ");
                        decimal overdraftLimit = Convert.ToDecimal(Console.ReadLine());
                        bank.CreateAccount(new CurrentAccount(0, customerName, balance, overdraftLimit));
                    }
                    break;
                case 2:
                    // Call bank.Deposit() method
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    float amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Deposit(accountNumber, amount);
                    break;
                case 3:
                    // Call bank.Withdraw() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Withdraw(accountNumber, amount);
                    break;
                case 4:
                    // Call bank.CalculateInterest() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    bank.CalculateInterest(accountNumber);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}