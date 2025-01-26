using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c_1.Q2_3_5
{
    internal static class Helper
    {

        public static int FirstNonRepeatedCharacter(string s)
        {
            if (s is null)
            {
                return -1; 
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public static void ReverseArrayList(ArrayList list)
        {
            if (list == null || list.Count <= 1)
            {
                return;
            }

            int s = 0;
            int e = list.Count - 1;

            while (s < e)
            {
                object temp = list[s];
                list[s] = list[e];
                list[e] = temp;

                s++;
                e--;
            }
        }
        public static List<T> FilterEvenNumbers<T>(List<T> inputList)
        {
            List<T> evenNumbers = new List<T>();
            for (int i = 0; i < inputList.Count; i++)
            {
                T number = inputList[i];
                if (Convert.ToInt64(number) % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
    }
}
