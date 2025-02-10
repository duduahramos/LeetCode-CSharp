using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RomanToInteger13
    {
        private static readonly Dictionary<char, int> RomanMap = new()
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 },
            { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };

        public static int Run(string s)
        {
            var romanListStr = s.ToUpper();
            var romanListInt = RomanStrToIntList(romanListStr);
            int lastIdx = romanListInt.Count - 1;
            int result = 0;

            for (int currentIdx = 0; currentIdx < romanListInt.Count; currentIdx++)
            {
                var currentNumber = romanListInt[currentIdx];
                var nextNumber = currentIdx != lastIdx ? romanListInt[currentIdx + 1] : 0;

                if (currentNumber < nextNumber)
                {
                    result += nextNumber - currentNumber;
                    currentIdx++;
                    continue;
                }

                result += currentNumber;
            }

            return result;
        }

        private static List<int> RomanStrToIntList(string roman)
        {
            var romanListInt = new List<int>();

            foreach (char romanChar in roman)
            {
                romanListInt.Add(RomanMap[romanChar]);
            }

            return romanListInt;
        }
    }
}
