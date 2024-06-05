namespace Labb1
{
    internal class NormalAccount : Account
    {
        public override void AccountType()
        {
            Logger.Instance.Log("Nytt Normalt konto öppnat");
            Console.WriteLine($"\nNytt Normalt konto med kontonr {AccountNumber} öppnat");
        }


    }
}
