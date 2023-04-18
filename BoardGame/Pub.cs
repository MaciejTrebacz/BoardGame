using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BoardGame
{
    public class Pub
    {
        public List<Game> GamesInMotion { get; set; } = new List<Game>();

        public bool AlreadyGameInLocation(Game game)
        {
            return GamesInMotion.Any(x => x.Location.City == game.Location.City);
        }

        public void TryToPlay(Game game, List<Player> players)
        {
            switch (game)
            {
                case StoryTelling storyTelling:
                    if (!AlreadyGameInLocation(game))
                    {
                        storyTelling.Play(players);
                        InMotion(game);
                    }
                    else
                    {
                        Console.WriteLine("Already playing cheerful game in this location");
                    }
                    break;
                default:
                    game.Play(players);
                    InMotion(game);
                    break;
            }    
            //if (game.Name == "StoryTelling")
            //{
            //    if (!AlreadyGameInLocation(game))
            //    {
            //        Console.WriteLine(game.Location.City);
            //        game.Play(players);
            //        InMotion(game);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Already game in this location");
            //    }
            //}
            //else
            //{
            //    game.Play(players);
            //    InMotion(game);
            //}
        }

        public void InMotion(Game game)
        {
            GamesInMotion.Add(game);
        }
    }
}
