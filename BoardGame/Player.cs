using System.Collections.Generic;

namespace BoardGame
{
    public class Player
    {
        public string Nickname { get; set; }
        public int CurrentAge { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();

        public Player(string nickname, int currentAge)
        {
            Nickname = nickname;
            CurrentAge = currentAge;
        }

        public void AddGame(Game game)
        {
            Games.Add(game);
        }

        public void RemoveGame(Pub pub,Game game)
        {
            pub.GamesInMotion.Remove(game);
        }
    }
}