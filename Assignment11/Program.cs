using Assignment11;
public class BankApp
{
    public static void Main(string[] args)
    {
        IBankServiceProvider bank = new BankServiceProviderImpl();
        while (true)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Get Account Details");
            Console.WriteLine("6. List Accounts");
            Console.WriteLine("7. Exit");
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
                    Console.Write("Enter Account Type: ");
                    string accountType = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    bank.CreateAccount(customer, accountType, balance);
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
                    // Call bank.Transfer() method
                    Console.Write("Enter From Account Number: ");
                    int fromAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter To Account Number: ");
                    int toAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Transfer(fromAccountNumber, toAccountNumber, amount);
                    break;
                case 5:
                    // Call bank.GetAccountDetails() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(bank.GetAccountDetails(accountNumber));
                    break;
                case 6:
                    // Call bank.ListAccounts() method
                    foreach (Account account in bank.ListAccounts())
                    {
                        Console.WriteLine(account);
                    }
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}