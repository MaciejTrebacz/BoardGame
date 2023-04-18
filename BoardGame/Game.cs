using System.Collections.Generic;

namespace BoardGame
{
    public abstract class Game

    {
        public string Name { get; set; }
        public int PlayingTime { get; set; }
        public Complexity Complexity { get; set; }
        public int MinimumNumberOfPlayers { get; protected set; }
        public int MaximumNumberOfPlayers { get; set;}
        public abstract void Play(List<Player> players);

        public Game(string name, int playingTime, Complexity complexity, int minimumNumberOfPlayers, int maximumNumberOfPlayers, bool onsite)
        {
            MinimumNumberOfPlayers = minimumNumberOfPlayers;
            MaximumNumberOfPlayers = maximumNumberOfPlayers;
            Name = name; 
            PlayingTime = playingTime;
            Complexity = complexity;
            Onsite = onsite;
            

        }

        public bool InMotion { get; set; } = false;
        public bool  Onsite { get; set; }
        public Location Location { get; set; } = new Location();
    }
}