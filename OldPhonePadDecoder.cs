using System;
using System.Collections.Generic;
using System.Text;

namespace IronSoftwareCodingChallenge
{
    public static class OldPhonePadConverter
    {
        // Mapping of keypad numbers to their corresponding letters
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

        // Helper method to append the correct character based on key and count
        private static void AppendChar(StringBuilder result, char key, int count)
        {
            if (count == 0 || !Keypad.ContainsKey(key))
                return;

            string letters = Keypad[key];
            int index = (count - 1) % letters.Length;
            result.Append(letters[index]);
        }


        // Main method to decode the input string
        public static string OldPhonePad(string input)
        {
            var result = new StringBuilder();

            char lastKey = '\0'; // Spacing character
            int count = 0;

            foreach (char c in input)
            {
               // End Input
               if (c == '#')
               {
                   AppendChar(result, lastKey, count);
                   break;
               }

               // Backspace 
               if (c == '*')
                {                      
                    AppendChar(result, lastKey, count);
                    if (result.Length > 0)
                    {
                        result.Length--;
                    }

                    lastKey = '\0';
                    count = 0;
                    continue;
                }

                // Pause between letters same keys
                if (c == ' ')
                {
                    AppendChar(result, lastKey, count);
                    lastKey = '\0';
                    count = 0;
                    continue;
                }

                // Same number -> keep counting
                if (c == lastKey)
                {
                    count++;
                }
                else // Different number -> append previous character and reset count
                {
                    AppendChar(result, lastKey, count);
                    lastKey = c;
                    count = 1;
                }
            }
            return result.ToString();
        }
    }
}
