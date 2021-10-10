using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AlogirthmBuildMatch
{
    class Player
    {
        public string Id { get; set; }
    }


    
    class Party
    {
        public IList<Player> Players { get; set; }
    }


    
    class Game
    {
        public IList<Player> Team1 { get; set; }
        public IList<Player> Team2 { get; set; }
    }


    class Common
    {
        public static string MakeId(int length = 8)
        {
            string result = "";
            char[] characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            int charactersLength = characters.Length;

            Random rnd = new Random();
            
            for (int i = 0; i < length; i++)
            {
                result += characters.ElementAt(rnd.Next(0, charactersLength));
            }

            return result;
        }
    }



    class GenerateMocksData
    {
        public static IList<Party> GetParties(int count)
        {
            List<Party> parties = new List<Party>();
            
            Random rnd = new Random();

            
            for (int i = 0; i < count; i++)
            {
                int playerCount = rnd.Next();

                Party party = new Party();

                for (int j = 0; j < playerCount; j++)
                {
                    Player player = new Player();

                    player.Id = Common.MakeId();
                    
                    party.Players.Add(player);
                }
                
                parties.Add(party);
            }
            

            return parties;
        }
    }


    class BuildMatchReadDto
    {
        public Game Game { get; set; }
        public IList<Party> Unassigned { get; set; }
    }

    class BuildMatch
    {
        public BuildMatchReadDto GenerateGames(IList<Party> parties)
        {
            Game Game = new Game();
            List<Party> Unassigned = new List<Party>();

            // TODO: algorithm
            
            BuildMatchReadDto viewModel = new BuildMatchReadDto();

            return viewModel;
        }
    }



    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}