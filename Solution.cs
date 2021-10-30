using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeLongestDuplicateSubstring
{
    public class Solution
    {
        private Dictionary<string, int> _dic = new();

        public string LongestDupSubstring(string s)
        {
            string longestEntry = string.Empty;

            for (int i = 0; i <= s.Length; i++)
            {
                for (int j = i+1; j <= s.Length; j++)
                {
                    var str = s.Substring(i, j - i);
                    if (_dic.ContainsKey(str))
                    {
                        _dic[str]++;
                        if (str.Length > longestEntry.Length)
                            longestEntry = str;
                    }
                    else
                        _dic[str] = 1;
                }
            }
            
            return longestEntry;
        }
    }
}
