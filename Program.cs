using _41_50;
using _41_50.Custom_Exception;
using _41_50.E_Num;

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

        //try
        //{
        //    BankAccount account = new BankAccount(500);
        //    account.withdraw(300);
        //}
        //catch (InsufficientBalanceException ex)
        //{
        //    Console.WriteLine("Outer exception");
        //    Console.WriteLine($"Exception: {ex.Message}");

        //    if (ex.InnerException != null)
        //    {
        //        Console.WriteLine("Innner exception");
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        Coustomer[] coustomer = new Coustomer[3];

        coustomer[0] = new Coustomer
        {
            name = "Neel",
            gender = Gender.Male
        };
        coustomer[1] = new Coustomer
        {
            name = "Parag",
            gender = Gender.Female
        };
        coustomer[2] = new Coustomer
        {
            name = "Jem",
            gender = Gender.Unknown
        };


        foreach (var item in coustomer)
        {
            Console.WriteLine($"name - {item.name}, gender - {getGender(item.gender)}");
        }
    }
    public static string getGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "unKnown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Please select valid";
        }
    }
}