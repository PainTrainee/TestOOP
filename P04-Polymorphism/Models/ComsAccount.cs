namespace P04_Polymorphism.Models
{
    internal class ComsAccount : BankAccount
    {
        public decimal Interest { get; set; }
        public void DisplayAccount(char select = 'A')
        {
            if (select == 'A') Console.WriteLine(GetBalance());
            else Console.WriteLine(base.GetBalance());
        }
        //override method
        public override string GetBalance()
        {
            return $"This account from ComsAccount is {AccountHolder}\n has money {Balance} Baht\nInterest = {Interest}";
        }
        public void CalInterest(double rate = 0)
        {
            Interest = Balance - (Balance * (decimal)rate);
        }
    }
}
