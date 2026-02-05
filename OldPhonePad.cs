namespace OldPhonePad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs =
            {
                "33#",
                "227*#",
                "4433555 555666#",
                "8 88777444666*664#" // correct out put is "TURING"
            };

            for (int i = 0; i < inputs.Length; i++)
            {
                string output = IronSoftwareCodingChallenge.OldPhonePadConverter.OldPhonePadDecoder(inputs[i]);
                Console.WriteLine($"Input: {inputs[i]} => Output: {output}");
            }
        }
    }
}