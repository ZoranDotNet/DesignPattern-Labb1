namespace Labb1.Factory
{
    internal class SavingsAccountFactory : AccountFactory
    {
        public override Account CreateAccount()
        {
            return new SavingsAccount();
        }
    }
}
