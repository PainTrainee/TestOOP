namespace P03_Encapsulate
{
    //การเรียกใช้ internal ในโปรเจคเดียวกันสามารถทำได้
    public class Class1
    {
        //Constructor
        public Class1()
        {
            var temp = new BankAccount();
            temp.Rate = 100;
        }
    }
}
