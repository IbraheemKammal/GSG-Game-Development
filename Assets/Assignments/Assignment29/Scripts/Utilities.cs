using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assignment29
{

    public static class Utilities
    {
        public static int Add(params int[] ints)
        {
            return ints.Sum();

        }
    }

    public static class ExtensionMethods
    {
        public static string RepeatString(this string s, int reapetationNum)
        {
            string result = " ";
            foreach(int i in Enumerable.Range(1, 3))
            {
                result +=$"{s}, ";
            }
            return result;
        }

    }
}
