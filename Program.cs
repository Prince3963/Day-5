using _41_50;
using _41_50.Custom_Exception;

internal class Program
{
    public static void Main(string[] args)
    {

        //try
        //{
        //    Innerexception.checkException();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Outer Exceptions: {ex.Message}");
        //    if (ex.InnerException != null)
        //    {
        //        throw new Exception("Inner exception found", ex);
        //    }
        //}

        try
        {
            BankAccount account = new BankAccount(500);
            account.withdraw(300);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Outer exception");
            Console.WriteLine($"Exception: {ex.Message}");

            if (ex.InnerException != null)
            {
                Console.WriteLine("Innner exception");
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}