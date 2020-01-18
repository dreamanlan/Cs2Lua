using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class StringMatcher
{
    internal static bool IsMatch(string str, IList<string> filters)
    {
        bool match = true;
        int startIx = 0;
        for (int i = 0; i < filters.Count; ++i) {
            var info = filters[i];
            var ix = str.IndexOf(info, startIx, StringComparison.CurrentCultureIgnoreCase);
            if (ix >= 0) {
                startIx = ix + info.Length;
            }
            else {
                match = false;
                break;
            }
        }
        return match;
    }
}
