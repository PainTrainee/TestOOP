namespace P03_Encapsulate
{
    internal class NewAccount : BankAccount
    {
        public NewAccount()
        {
            Id = 1;
            Name = "Test";
            //private Password สืบทอดไม่ได้
            Rate = 100;
            //protected สืบทอดได้ แต่เรียกใช้ทางอ้อม
            Money = 100;
        }
        //เรียกใช้ protected แบบทางอ้อม(ภายในคลาส)
        public void Withdraw(int money)
        {
            if(Money > 0 && money <= Money)
            {
                Money -= money;
                Console.WriteLine(Money);
            }
            else
            {
                Console.WriteLine("Can't withdraw");
            }
        }
    }
}
