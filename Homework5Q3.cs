namespace Homework5Q3;
class Program
{
    static void Main()
    {
        createAccount();
    }
    public static bool checkAge(int birth_year)
    {
        if((2023-birth_year)>=18)
        return true;
        else
        return false;
    }
    public static void createAccount()
    {
        Console.WriteLine("Enter Your Username: ");
        string Username= Console.ReadLine();
        Console.WriteLine("Enter Your Password: ");
        string Password= Console.ReadLine();
        Console.WriteLine("Enter Your Password Again: ");
        string confirm_Password= Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear: ");
        int Birthyear= Convert.ToInt32(Console.ReadLine());
        if(checkAge(Birthyear))
        {
            if(Password==confirm_Password)
            Console.WriteLine("Account is created successfully.");
            else
            Console.WriteLine("Wrong Password.");
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }


}