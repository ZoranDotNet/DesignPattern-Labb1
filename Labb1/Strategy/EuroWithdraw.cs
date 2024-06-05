namespace Labb1.Strategy
{
    internal class EuroWithdraw : IWithdraw
    {
        public void WithdrawMoney(double amount)
        {
            Logger.Instance.Log($"Uttag om {amount} Euro genomfört");
            Console.WriteLine($"Kvitto: {amount} EURO");
        }
    }
}
