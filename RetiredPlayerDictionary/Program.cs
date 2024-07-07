namespace RetiredPlayerDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, RetiredPlayer> retiredYankees = new Dictionary<int, RetiredPlayer>()
            {
                {3, new RetiredPlayer("Babe Ruth", 1948) },
                {4, new RetiredPlayer("Lou Gerhig", 1939) },
                {5, new RetiredPlayer("Joe DiMaggio", 1952) },
                {7, new RetiredPlayer("Mickey Mantle", 1969) },
                {8, new RetiredPlayer("Yogi Berra", 1972) },
                {10, new RetiredPlayer("Phil Rizzuto", 1985) },
                {23, new RetiredPlayer("Don Matingly", 1997) },
                {42, new RetiredPlayer("Jackie Robinson", 1993) },
                {44, new RetiredPlayer("Reggie Jackson", 1993) },
            };

            foreach(int jerseyNumber in retiredYankees.Keys)
            {
                RetiredPlayer player = retiredYankees[jerseyNumber];
                Console.WriteLine($"{player.Name}, nr {jerseyNumber}, zakończył karierę w roku {player.YearRetired}");
            }
        }
    }
}
