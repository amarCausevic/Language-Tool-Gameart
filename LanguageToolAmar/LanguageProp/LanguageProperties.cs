using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageToolAmar.LanguagePropertirs
{
    class LanguageProperties
    {
        public string Property { get; set; }
        public string Value { get; set; }
        public LanguageProperties(string prop, string val)
        {
            Property = prop;
            Value = val;
        }
    }
}
