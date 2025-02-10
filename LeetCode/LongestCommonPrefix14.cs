using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LongestCommonPrefix14
    {
        public static string Run(string[] strs)
        {
            Dictionary<string, int> countPrefix = new();

            foreach (string str in strs)
            {
                string prefix = string.Empty;

                foreach (var s in str)
                {
                    prefix += s;

                    if (prefix.Length == 1) continue;

                    if (countPrefix.ContainsKey(prefix))
                        countPrefix[prefix] += 1;
                    else
                        countPrefix[prefix] = 1;
                }
            }

            var firstResult = countPrefix.OrderByDescending(x => x.Value).First();

            return firstResult.Value > 1 ? firstResult.Key : string.Empty;
        }
    }
}
