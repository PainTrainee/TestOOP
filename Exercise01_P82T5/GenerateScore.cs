namespace Exercise01_P82T5
{
    public class GenerateScore
    {
        static public List<Score> ScoreList;
        public GenerateScore(int number)
        {
            ScoreList = new List<Score>();
            Generate(number);
        }
        void Generate(int number) 
        {
            Random rnd = new();
            for (int i = 0; i < number; i++) 
            {
                ScoreList.Add(new Score
                {
                    Test1 = rnd.Next(0, 100) + 1,
                    Test2 = rnd.Next(0, 100) + 1,
                    Test3 = rnd.Next(0, 100) + 1,
                    Test4 = rnd.Next(0, 100) + 1,
                });
            }
            ScoreList.Max(p=>p.Test1);
        }

    }
}
