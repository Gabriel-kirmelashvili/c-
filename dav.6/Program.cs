namespace dav._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // davaleba 1
            //int[][] students =
            //[
            //    [85, 90, 78],
            //    [92, 88, 95, 100],
            //    [70, 65],
            //    [88, 91, 84, 79, 95]
            //];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        sum += students[i][j];
            //    }
            //    Console.WriteLine($"studenti {i + 1} sashaualo qula: {sum / students[i].Length}");
            //}


            // davaleba 2
            //Random random = new();
            //int[] passcodes = new int[10];

            //for (int i = 0; i < passcodes.Length; i++)
            //{
            //    passcodes[i] = random.Next(1000, 9999);
            //}

            //Console.Write("seiyvane 4 nishna kodi: ");
            //int userCode = int.Parse(Console.ReadLine());

            //bool found = false;
            //for (int i = 0; i < passcodes.Length; i++)
            //{
            //    if (passcodes[i] == userCode)
            //    {
            //        found = true;
            //    }
            //}

            //if (found)
            //    Console.WriteLine("Correct");
            //else
            //    Console.WriteLine("Wrong");


            // davaleba 3
            //int[] numbers = { 5, -3, 12, -8, 0, 47, -1, 23, -15, 6 };

            //int min = numbers[0];
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //        min = numbers[i];

            //    if (numbers[i] > max)
            //        max = numbers[i];
            //}

            //Console.WriteLine($"minimaluri: {min}");
            //Console.WriteLine($"maximaluri: {max}");


            // davaleba 4
            //string[] words = { "hello", "world", "csharp" };

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write($"{words[i]}: ");
            //    for (int j = 0; j < words[i].Length; j++)
            //    {
            //        Console.Write(words[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            // davaleba 5
            //string[] emails = { "test@gmail.com", "invalidEmail", "user@yahoo.com", "wrongemail.com", "hello@mail.ge" };

            //for (int i = 0; i < emails.Length; i++)
            //{
            //    bool hasAt = false;
            //    for (int j = 0; j < emails[i].Length; j++)
            //    {
            //        if (emails[i][j] == '@')
            //        {
            //            hasAt = true;
            //        }
            //    }

            //    if (hasAt)
            //        Console.WriteLine($"{emails[i]} - valid");
            //    else
            //        Console.WriteLine($"{emails[i]} - invalid");
            //}

        }
    }
}
