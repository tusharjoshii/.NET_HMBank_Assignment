using Part2;

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
                    Console.Write("Enter Customer ID: ");
                    int customerId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Customer customer = new Customer(customerId, firstName, lastName, email, phoneNumber, address);
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Account Type: ");
                    string accountType = Console.ReadLine();
                    Console.Write("Enter Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter Interest Rate or Overdraft Limit: ");
                    decimal interestRateOrOverdraftLimit = Convert.ToDecimal(Console.ReadLine());
                    bank.CreateAccount(customer, accountNumber, accountType, balance, interestRateOrOverdraftLimit);
                    break;
                case 2:
                    // Call bank.Deposit() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
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
