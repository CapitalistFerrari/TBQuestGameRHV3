using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGameRH.Models;

namespace TBQuestGameRH.DataLayer
{
    public static class GameData
    {

        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Raoul Duke",
                CurrentLevel = Player.Level.One,
                CurrentStatus = Player.Status.Hallucinating,
                HP = 100,
                LocationId = 0,
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "We were somewhere around Barstow, near the edge of the desert, when the drugs began to take hold."
            };
        }
        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }

        public static Location EmptyLocation()
        {
            return new Location()
            {
                Id = 0,
                Name = "Wrong Way!",
                Description = "All energy flows according to the whims of the great magnet. What a fool I was to defy him.",
                Accessible = true
            };
        }

        public static Location[,] GameMap()
        {
            int rows = 3;
            int columns = 4;

            Location[,] mapLocations = new Location[rows, columns];

            //
            // row 1
            //
            mapLocations[0, 0] = new Location()
            {
                Id = 4,
                Name = "The Desert",
                Description = "We can't stop here! This is bat country...",
                Accessible = true,
                
            };
            mapLocations[0, 1] = new Location()
            {
                Id = 1,
                Name = "Beverly Heights Hotel",
                Description = "",
                Accessible = true,
                
            };

            //
            // row 2
            //
            mapLocations[1, 1] = new Location()
            {
                Id = 2,
                Name = "The Circus Casino",
                Description = "The Circus-Circus is what the whole hep world would be doing if the Nazi's had won the war." +
                " This is the sixth Reich. The ground floor is full of gambling tables, like all the other casinos..." +
                " but the places is about four stories high, in the style of a circus tent, " +
                " and all manner of strange County-Fair/Polish Carnival madness is going on up in this space.",
                Accessible = true,
                
            };

            //
            // row 3
            //
            mapLocations[2, 0] = new Location()
            {
                Id = 3,
                Name = "Mint 400 Race Track",
                Description = "",
                Accessible = false,
                
            };
            mapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "The Flamingo Hotel",
                Description = "If the pigs were gathering in Vegas, I felt the drug culture should be represented as well. " +
                "And there was a certain bent appeal in the notion of running a savage burn in one Las Vegas, " +
                "and then just wheeling across town and checking into another. Me and a thousand ranking cops from all over America. " +
                "Why not? Move confidently into their midst.",
                Accessible = true,
                
            };

            return mapLocations;
        }
    }
}
