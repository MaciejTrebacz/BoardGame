using System;
using System.Collections.Generic;

namespace BoardGame
{
    public class Puzzle : Game
    {
        public Puzzle(string name, int playingTime, Complexity complexity) : base(name, playingTime, complexity, 1, 10, true)
        {

        }

        public override void Play(List<Player> players)
        {
            if (players.Count >= MinimumNumberOfPlayers && players.Count <= MaximumNumberOfPlayers)
            {
                if (Onsite)
                {
                    Console.WriteLine("Playing onsite");
                    Location.City = "Paris";
                }
                else
                {
                    Console.WriteLine("Playing online");
                    Onsite = false;
                }
            }
        }
    }
}