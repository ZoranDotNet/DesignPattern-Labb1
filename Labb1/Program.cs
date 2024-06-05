namespace Labb1
{
    public class Program
    {
        //Enkel bankomat app. Har en Loggerklass som följer Singleton pattern. En global instans.
        //Kan öppna antingen Sparkonto eller Normalt konto, Factory Pattern
        //Kan göra uttag i olika valutor - Strategy Pattern
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.ShowMenu();
        }
    }
}
