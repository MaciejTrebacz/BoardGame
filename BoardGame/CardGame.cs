using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace BoardGame
{
    public class CardGame : Game
    {
        
        public CardGame(string name, int playingTime, Complexity complexity) : base(name, playingTime, complexity,2,10,true)
        {
        }

        public override void Play(List<Player> players)
        {

            if (players.Count >= MinimumNumberOfPlayers && players.Count <= MaximumNumberOfPlayers)
            {
                if (Onsite)
                {
                    Console.WriteLine("Playing onsite");
                    Location = new Location() { City = "Warsaw" };
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