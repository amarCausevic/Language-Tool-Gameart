using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageToolAmar.LanguagePropertirs
{
    class LanguagePack
    {
        public string ID { get; set; }
        public string DisplayName { get; set; }

        public LanguagePack(string id, string displayName)
        {
            ID = id;
            DisplayName = displayName;
        }

        public static List<LanguagePack> LanguagePackList()
        {
            List<LanguagePack> newList = new List<LanguagePack>()
            {
                new LanguagePack("en", "English"),
                new LanguagePack("de", "German"),
                new LanguagePack("es", "Spanish"),
                new LanguagePack("fr", "French"),
                new LanguagePack("hr", "Croation"),
                new LanguagePack("it", "Italian"),
                new LanguagePack("jp", "Japan"),
                new LanguagePack("kr", "Korean"),
                new LanguagePack("pt", "Portugese"),
                new LanguagePack("ro", "Romanian"),
                new LanguagePack("ru", "Russian"),
                new LanguagePack("th", "Thai"),
                new LanguagePack("zh", "Chinese"),
                new LanguagePack("id", "\"Simplified\" Hindi"),
            };
            return newList;
        }
    }
}
