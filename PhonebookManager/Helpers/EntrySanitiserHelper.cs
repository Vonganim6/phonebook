using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PhonebookManager.Helpers
{
    public class EntrySanitiserHelper
    {
        public EntrySanitiserHelper()
        {
        }

        public string RemoveSpecialCaracters(string entry)
        {
            entry = Regex.Replace(entry, @"[^0-9a-zA-Z]+", "");

            return entry;
        }
    }
}
