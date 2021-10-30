using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeLongestDuplicateSubstring
{
    public class Solution
    {
        private SortedDictionary<string, int> _dic = new();

        public string LongestDupSubstring(string s)
        {
            for (int i = 0; i <= s.Length; i++)
            {
                for (int j = i+1; j <= s.Length; j++)
                {
                    var str = s.Substring(i, j - i);
                    if (_dic.ContainsKey(str))
                        _dic[str]++;
                    else
                        _dic[str] = 1;
                }
            }

            return string.Empty;

        }
    }
}
