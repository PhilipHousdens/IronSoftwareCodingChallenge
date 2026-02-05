using System;
using System.Collections.Generic;
using System.Text;

namespace IronSoftwareCodingChallenge
{
    public static class OldPhonePadConverter
    {
        private static readonly Dictionary<char, string> Keypad = new()
        {
            { '1', "&'(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        private static void AppendChar(StringBuilder result, char key, int count)
        {
            if (count == 0 || !Keypad.ContainsKey(key))
                return;

            string letters = Keypad[key];
            int index = (count - 1) % letters.Length;
            result.Append(letters[index]);
        }
    }
}
