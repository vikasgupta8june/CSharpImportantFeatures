
//Feature 2: File-Scoped Namespaces
namespace GlobalUsingFeatures;

internal class Program
{
    static void Main(string[] args)
    {
        // Feature 4: Using Declaration for new
        WriteToFile.OldUsingDeclaration();
        WriteToFile.NewUsingDeclaration();








        // Feature 3: Interpolated String Improvements
        string name = "Jane";
        string message = $"Hello, {name.ToUpper()}!";
        Console.WriteLine(message);

















        //Feature 1: Global Usings
        Credit credits = new Credit();
        Debit debits = new Debit();

        // TotalBalance is withing same namespace as soln
        TotalBalance totalBalance = new TotalBalance();

        var totaBalance = totalBalance.BalanceAmount(100, credits.CreditedAmount(49), debits.DebitedAmount(51));
        Console.WriteLine(totaBalance);

        

             
    }
}
