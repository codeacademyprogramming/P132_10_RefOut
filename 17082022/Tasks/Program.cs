using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result);
            string[] names = { "Abbas", "Nermin", null, "Tofiq", null };

            ChangeNull(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\n=======================================");
            int[] numbers = { 14, -90, 34, -5 };

            MakePositive(numbers);
            for (int i = 0;i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\n=======================================");

            int num = -560;
            MakePositive(ref num);

            Console.WriteLine(num);

            Console.WriteLine("\n=======================================");

            numbers = new int[] { 14, -90, 34, -5 };

            DeleteNegative(ref numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void ChangeNull(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    arr[i] = "0";
            }
        }

        static void MakePositive(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] *= -1;
            }
        }

        static void MakePositive(ref int num)
        {
                num *= -1;
        }

        static void DeleteNegative(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    count++;
            }

            int[] newArr = new int[count];

            int index = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }

            arr = newArr;
        }









    }
}
