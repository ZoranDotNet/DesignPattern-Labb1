namespace Labb1.Factory
{
    internal class NormalAccountFactory : AccountFactory
    {
        public override Account CreateAccount()
        {
            return new NormalAccount();
        }
    }
}
