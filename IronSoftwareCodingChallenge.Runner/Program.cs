using System;
using IronSoftwareCodingChallenge;

class Program
{
    static void Main()
    {
        string[] inputs =
        {
            "33#",
            "227*#",
            "4433555 555666#",
            "8 88777444666*664#" // correct out put is "TURING"
        };

        foreach (var input in inputs)
        {
            var output = OldPhonePadConverter.OldPhonePadDecoder(input);
            Console.WriteLine($"Input: {input} => Output: {output}");
        }
    }
}
