namespace Shared
{
    /// <summary>
    /// Helpers for the recurring "print a prompt, read a line, parse it" pattern.
    /// </summary>
    public static class ConsoleInput
    {
        public static string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        public static int ReadInt(string prompt)
        {
            int.TryParse(ReadString(prompt), out int value);
            return value;
        }

        public static double ReadDouble(string prompt)
        {
            double.TryParse(ReadString(prompt), out double value);
            return value;
        }

        public static bool ReadBool(string prompt)
        {
            bool.TryParse(ReadString(prompt), out bool value);
            return value;
        }
    }
}
