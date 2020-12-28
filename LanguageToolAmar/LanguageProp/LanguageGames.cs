using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageToolAmar.LanguagePropertirs
{
    class LanguageGames
    {
        public string ID { get; set; }
        public string DisplayName { get; set; }
        public string LinkPartOne { get; set; }

        public LanguageGames(string id, string displayName, string linkPartOne)
        {
            ID = id;
            DisplayName = displayName;
            LinkPartOne = linkPartOne;
        }

        public static List<LanguageGames> LanguageGamesPack()
        {
            List<LanguageGames> newList = new List<LanguageGames>()
            {
                new LanguageGames("mf", "Mariachi Fiesta", "MariachiFiesta"),
                new LanguageGames("nef", "Nefertiti Nile", "NefertitisNile"),
                new LanguageGames("dol", "Down Of Olympus", "DawnOfOlympus"),
                new LanguageGames("aq", "Apocalypse Quest", "ApocalypseQuest"),
                new LanguageGames("hf", "Hawaiian Fruits", "HawaiianFruits"),
                new LanguageGames("ph", "Piggy Holmes", "PiggyHolmes"),
                new LanguageGames("ric", "Roshtein Immortality Cube", "RoshteinImmortalityCube"),
                new LanguageGames("as2", "African Sunset 2", "AfricanSunset2"),
                new LanguageGames("hc", "Hawaiian Christmas", "HawaiianChristmas")
                //new LanguageGames("", "", ""),
            };
            return newList;
        }
    }
}
