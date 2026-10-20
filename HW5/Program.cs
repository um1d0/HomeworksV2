using HW5;

Player player1 = new Player { Name = "John", Score = 100 };
Player player2 = new Player { Name = "Alice", Score = 150 };
Player player3 = new Player { Name = "Bob", Score = 120 };
Player player4 = new Player { Name = "Eve", Score = 90 };
Player player5 = new Player { Name = "Charlie", Score = 200 };
Player player6 = new Player { Name = "David", Score = 80 };
Player player7 = new Player { Name = "Frank", Score = 110 };
Player player8 = new Player { Name = "Grace", Score = 130 };
List<Player> players = new List<Player> { player1, player2, player3, player4, player5, player6, player7, player8 };
List<int> playersScore = new List<int>
{
    player1.Score, player2.Score, player3.Score, player4.Score, player5.Score, player6.Score, player7.Score, player8.Score
};
playersScore.Sort();
for (int i = playersScore.Count - 3; i < playersScore.Count; i++)
{

    Console.WriteLine(playersScore[i]);
}
Console.WriteLine(playersScore[0]);
Console.WriteLine(playersScore[playersScore.Count - 1]);