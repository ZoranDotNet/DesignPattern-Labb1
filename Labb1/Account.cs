namespace Labb1
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }

        public Account()
        {
            AccountNumber = random.Next(100000, 999999).ToString();
        }

        Random random = new();


        public abstract void AccountType();
    }
}
