namespace Labb1.Strategy
{
    internal class UsdWithdraw : IWithdraw
    {
        public void WithdrawMoney(double amount)
        {
            Logger.Instance.Log($"Uttag om {amount} USDollar genomfört");
            Console.WriteLine($"Kvitto: {amount} Usd$");
        }
    }
}
