
//Bank Account Project
BankAccount Myacc = new BankAccount();
Myacc.AccountHolderName = "Mohamed Gasser Ahmed Nabil"; // The Name
Myacc.BankName = "CIB bank"; // The Bank
Myacc.BranchName = "Portsaid"; // The State
Myacc.BranchAddress = "elamin street mf"; // The Address
Myacc.AccountId = "EF231023123133521"; // Account Number
Myacc.Email = "madagasser15@gmail.com"; // Email
Myacc.AccountPassword = "Mg1522006"; // Password
Myacc.AccountCurrency = "USD"; // The currency
Myacc.Balance = 5400; // Balance

Console.WriteLine("welcome to CIB Bank \n 1 for Login \n 2 for registration");
int ans1 = Convert.ToInt32(Console.ReadLine());

if (ans1 == 1)
{

    Console.WriteLine("Please Enter Your email");
    var ans = Console.ReadLine();

    Console.WriteLine("Please Enter Your Password");
    var ans2 = Console.ReadLine();

    if (ans == Myacc.Email && ans2 == Myacc.AccountPassword)
    {
        Console.WriteLine($"Hello Mr {Myacc.AccountHolderName}\n How Can I serve you ?");
        info(Myacc); // info method
    }
    else
    {
        Console.WriteLine("Wrong email Or Password");
    }
}
else if (ans1 == 2)
{
    BankAccount Myaccount = new BankAccount();
    registration(Myaccount); // registration Method

    Console.WriteLine("Well Done ! You made Your Account");
    Console.WriteLine("Do You Want To Know Your Info [y/n]");
    string answer2 = Console.ReadLine();

    if (answer2 == "y" || answer2 == "Y")
    {
        info(Myaccount); // info method
    }
    else if (answer2 == "n" || answer2 == "N")
    {
        Console.WriteLine("Thanks For Using Our App");
    }

}

// Method 1
static void registration(BankAccount Myaccount)
{
    Console.WriteLine("Enter Your Name");
    Myaccount.AccountHolderName = Console.ReadLine();

    Console.WriteLine("Enter Your State");
    Myaccount.BranchName = Console.ReadLine();

    Console.WriteLine("Enter Your Address");
    Myaccount.BranchAddress = Console.ReadLine();

    Console.WriteLine("Enter Your Email");
    Myaccount.Email = Console.ReadLine();

    Console.WriteLine("Enter Your Password");
    Myaccount.AccountPassword = Console.ReadLine();

    Console.WriteLine("Enter Your Currency");
    Myaccount.AccountCurrency = Console.ReadLine();

    Console.WriteLine("Enter Your Balance");
    Myaccount.Balance = Convert.ToInt32(Console.ReadLine());

}
// Method 2
static void info(BankAccount Myacc)
{
    Console.WriteLine(" 1 for Account number \n 2 for change account password\n 3 for account balance \n 4 for transaction");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1)
    {
        Console.WriteLine($"This Is Your account number \n{Myacc.AccountId}");
    }
    else if (answer == 2)
    {
        Console.WriteLine("What is The New Password?");
        var ans3 = Console.ReadLine();
        Myacc.AccountPassword = ans3;
        Console.WriteLine($"Your New Password Is {Myacc.AccountPassword}");
    }
    else if (answer == 3)
    {
        Console.WriteLine($"Your Account Balance Is {Myacc.Balance} {Myacc.AccountCurrency}");
    }
    else if (answer == 4)
    {
        Console.WriteLine(" 1 Withdraw \n 2 deposite");
        int ans4 = Convert.ToInt32(Console.ReadLine());
        if (ans4 == 1)
        {
            Console.WriteLine("How Much Do You Want to Withdraw?");
            int ans5 = Convert.ToInt32(Console.ReadLine());
            Myacc.Withdraw(ans5);
        }
        else if (ans4 == 2)
        {
            Console.WriteLine("How Much Do You Want to Deposite?");
            int ans5 = Convert.ToInt32(Console.ReadLine());
            Myacc.Deposite(ans5);
        }
        else
        {
            Console.WriteLine("Wrong Choice");
        }
    }
    else
    {
        Console.WriteLine("Wrong Choice");
    }
}
//Class
class BankAccount
{
    public string BankName { get; set; }
    public string BranchName { get; set; }
    public string BranchAddress { get; set; }
    public string AccountHolderName { get; set; }
    public string AccountId { get; set; }
    public string Email { get; set; }

    public string AccountPassword { get; set; }
    public string AccountCurrency { get; set; }
    public decimal Balance { get; set; }

    public void Withdraw(decimal Amount)
    {
        decimal newBalance = Balance - Amount;
        if (newBalance < 0)
        {
            Console.WriteLine("Invalid Transaction");
        }
        else
        {
            Console.WriteLine($"Balance: {Balance} {AccountCurrency}");
            Console.WriteLine($"Withdraw Amount is {Amount} {AccountCurrency}");
            Console.WriteLine($"Your New Balance for {AccountId} Is {newBalance} {AccountCurrency}");
        }
        Console.WriteLine($"Transaction Date {DateTime.Now}");
    }
    public void Deposite(decimal Amount)
    {
        decimal newBalance = Balance + Amount;
        if (newBalance < 0)
        {
            Console.WriteLine("Invalid Transaction");
        }
        else
        {
            Console.WriteLine($"Balance: {Balance} {AccountCurrency}");
            Console.WriteLine($"Deposite Amount is {Amount} {AccountCurrency}");
            Console.WriteLine($"Your New Balance for {AccountId} Is {newBalance} {AccountCurrency}");
        }
        Console.WriteLine($"Transaction Date {DateTime.Now}");
    }
    public void Transfer() { }
    public void ChangePassword() { }

}