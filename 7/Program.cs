using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Davaleba 1
            static int Power(int num, int power)
            {
                int result = 1;

                for (int i = 0; i < power; i++)
                {
                    result *= num;
                }

                return result;
            }


            //// Davaleba 2
            //static bool IsPrime(int num)
            //{
            //    if (num < 2)
            //        return false;

            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //            return false;
            //    }

            //    return true;
            //}

            //// Davaleba 3
            //static bool IsPalindrome(string text)
            //{
            //    if (text.Length <= 1)
            //        return true;

            //    if (text[0] != text[text.Length - 1])
            //        return false;

            //    return IsPalindrome(text.Substring(1, text.Length - 2));
            //}

            //// Davaleba 4
            //static void Binary(int num)
            //{
            //    if (num == 0)
            //        return;

            //    Binary(num / 2);
            //    Console.Write(num % 2);
            //}

            //// Davaleba 5
            //static int RecursivePower(int num, int power)
            //{
            //    if (power == 0)
            //        return 1;

            //    return num * RecursivePower(num, power - 1);
            //}

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("1 - xarisxshi ayvana");
            //    Console.WriteLine("2 - martivi ricxvi");
            //    Console.WriteLine("3 - palindromi");
            //    Console.WriteLine("4 - binaruli chanaweri");
            //    Console.WriteLine("5 - rekursiuli xarisxi");

            //    Console.Write("airchie davaleba: ");
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("sheiyvane ricxvi: ");
            //            int num1 = int.Parse(Console.ReadLine());

            //            Console.Write("sheiyvane xarisxi: ");
            //            int power1 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("pasuxi: " + Power(num1, power1));
            //            break;

            //        case 2:
            //            Console.Write("sheiyvane ricxvi: ");
            //            int num2 = int.Parse(Console.ReadLine());

            //            if (IsPrime(num2))
            //                Console.WriteLine(num2 + " martivi ricxvia");
            //            else
            //                Console.WriteLine(num2 + " ar aris martivi ricxvi");
            //            break;

            //        case 3:
            //            Console.Write("sheiyvane teqsti: ");
            //            string text = Console.ReadLine();

            //            if (IsPalindrome(text))
            //                Console.WriteLine(text + " palindromia");
            //            else
            //                Console.WriteLine(text + " ar aris palindromi");
            //            break;

            //        case 4:
            //            Console.Write("sheiyvane ricxvi: ");
            //            int num4 = int.Parse(Console.ReadLine());

            //            Console.Write("binaruli chanaweri: ");
            //            Binary(num4);
            //            Console.WriteLine();
            //            break;

            //        case 5:
            //            Console.Write("sheiyvane ricxvi: ");
            //            int num5 = int.Parse(Console.ReadLine());

            //            Console.Write("sheiyvane xarisxi: ");
            //            int power5 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("pasuxi: " + RecursivePower(num5, power5));
            //            break;

            //        default:
            //            Console.WriteLine("araswori archevani");
            //            break;
            //    }

        }
    }
}