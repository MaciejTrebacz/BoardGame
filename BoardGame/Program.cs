using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puzzle puzzle = new Puzzle("Puzzle", 30, Complexity.Easy);
            StoryTelling storyTelling = new StoryTelling("StoryTelling", 1, Complexity.Easy);
            storyTelling.Location.City = "Spain";
            StoryTelling storyTelling2 = new StoryTelling("StoryTelling", 1, Complexity.Easy);
            storyTelling2.Location.City = "Polska";
            StoryTelling storyTelling3 = new StoryTelling("StoryTelling", 1, Complexity.Easy);
            storyTelling3.Location.City = "Polska";
            Pub pub = new Pub();


            Player player = new Player("Maciej", 3);
            Player player2 = new Player("Tomek", 3);
            List<Player> players = new List<Player>();
            players.Add(player);
            players.Add(player2);

            
            pub.TryToPlay(storyTelling3,players);
            player.RemoveGame(pub, storyTelling3);
            pub.TryToPlay(storyTelling3,players);
            Console.ReadLine();
        }
    }
}
