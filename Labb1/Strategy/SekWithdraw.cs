namespace Labb1.Strategy
{
    internal class SekWithdraw : IWithdraw
    {
        public void WithdrawMoney(double amount)
        {
            Logger.Instance.Log($"Uttag om {amount} Sek genomfört");
            Console.WriteLine($"Kvitto: {amount} SEK");
        }
    }
}
