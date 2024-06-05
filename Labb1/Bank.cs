using Labb1.Factory;
using Labb1.Strategy;

namespace Labb1
{
    public class Bank
    {

        private IWithdraw _currency;

        public void SetWithdrawStrategy(IWithdraw currency)
        {
            _currency = currency;
        }


        public void WithdrawMoney(double amount)
        {
            _currency.WithdrawMoney(amount);
        }

        public void OpenAccount(AccountFactory factory)
        {
            var account = factory.CreateAccount();
            account.AccountType();
        }

        public void ShowMenu()
        {
            bool loop = true;
            Console.WriteLine("Välkommen till Bankomaten");

            do
            {
                Console.WriteLine("*****************");
                Console.WriteLine("* 1 Öppna Konto *");
                Console.WriteLine("* 2 Uttag       *");
                Console.WriteLine("* 3 Avsluta     *");
                Console.WriteLine("*****************");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        HandleOpenAccount();
                        break;

                    case "2":
                        HandleWithdrawal();
                        break;

                    case "3":
                        Console.WriteLine("stänger Bankomaten...");
                        Console.ReadKey();
                        loop = false;
                        break;
                }

            } while (loop);

        }

        private void HandleOpenAccount()
        {
            bool openAccount = false;
            while (!openAccount)
            {
                Console.WriteLine("1 för Normalt konto");
                Console.WriteLine("2 för Sparkonto");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        OpenAccount(new NormalAccountFactory());
                        openAccount = true;
                        break;

                    case "2":
                        OpenAccount(new SavingsAccountFactory());
                        openAccount = true;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void HandleWithdrawal()
        {
            bool withdraw = false;
            while (!withdraw)
            {
                Console.WriteLine("Vilken valuta vill du ta ut?");
                Console.WriteLine("1 för SEK");
                Console.WriteLine("2 för EURO");
                Console.WriteLine("3 för Dollar");
                string currency = Console.ReadLine();
                Console.Clear();

                switch (currency)
                {
                    case "1":
                        SetWithdrawStrategy(new SekWithdraw());
                        withdraw = true;
                        break;

                    case "2":
                        SetWithdrawStrategy(new EuroWithdraw());
                        withdraw = true;
                        break;

                    case "3":
                        SetWithdrawStrategy(new UsdWithdraw());
                        withdraw = true;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Hur mycket vill du ta ut?");
            string inputAmount = Console.ReadLine();
            if (!double.TryParse(inputAmount, out double amount))
            {
                Console.WriteLine("Ogiltigt belopp, försök igen.");
                return;
            }

            WithdrawMoney(amount);
            Console.ReadKey();
        }
    }

}

