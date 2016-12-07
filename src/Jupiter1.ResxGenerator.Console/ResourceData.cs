using System.Collections.Generic;
using System.Linq;

namespace Jupiter1.ResxGenerator.Console
{
    internal class ResourceData
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public List<string> Arguments { get; set; }

        public bool UsingNamedArgs { get; set; }

        public string FormatArguments
        {
            get { return string.Join(", ", Arguments.Select(a => "\"" + a + "\"")); }
        }

        public string ArgumentNames
        {
            get { return string.Join(", ", Arguments.Select(GetArgName)); }
        }

        public string Parameters
        {
            get { return string.Join(", ", Arguments.Select(a => "object " + GetArgName(a))); }
        }

        public string GetArgName(string name)
        {
            return UsingNamedArgs ? name : 'p' + name;
        }
    }
}