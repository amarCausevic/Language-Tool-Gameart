using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageToolAmar.LanguagePropertirs
{
    class DiffResultProps
    {
        public string DiffProperties { get; set; }
        public JToken DiffResult { get; set; }
        public int ChildCount { get; set; }
        public DiffResultProps(string diffProperties, JToken diffResult)
        {
            DiffProperties = diffProperties;
            DiffResult = diffResult;
            ChildCount = diffResult.Count();
        }
    }
    class TestClass1
    {
        public string ServerSideValue { get; set; }
        public string LocalSidevalue { get; set; }
        public TestClass1(string serverSideValue, string localSideValue)
        {
            ServerSideValue = serverSideValue;
            LocalSidevalue = localSideValue;
        }
    }
}
