namespace Labb1
{
    internal class SavingsAccount : Account
    {
        public override void AccountType()
        {
            Logger.Instance.Log("Nytt Sparkonto öppnat");
            Console.WriteLine($"\nNytt Sparkonto med kontonr {AccountNumber} öppnat");
        }


    }
}
