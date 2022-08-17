using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int num = 45;
            //num = 55;
            //num = 5;
            int num = 100;
            //AddRef(ref num);
            SetZeroOut(out num);
            Console.WriteLine(num);

            Console.WriteLine(num);
            char letter = 'A';
            letter = 'B';

            Console.WriteLine(letter);

            string name = "Abbas";
            name = null;

            SetZero(name);
            Console.WriteLine(name);

            int[] numbers = { 1, 5, 34 };

            SetZero(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] names = { "Abbas", "Nermin" };
            AddStr(ref names, "Hikmet");
            AddStr(ref names, "Gulnar");
            AddStr(ref names, "Nezrin");

            //SetZero(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


       
        }

        static void SetZero(int num)
        {
            num = 0;
        }
        static void SetZeroRef(ref int num)
        {
            num = 0;
        }
        static void SetZeroOut(out int num)
        {
            num = 0;
        }

        static void SetZero(int[] numbers)
        {
            //numbers = new int[numbers.Length];
            if(numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = 0;
                }
            }
         
        }

        static void SetZero(string[] numbers)
        {
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = "0";
                }
            }

        }

        static void SetZero(string str)
        {
            str = "0";
        }
        static void Add(int num)
        {
            num++;
        }
        static void AddRef(ref int num)
        {
            num++;
        }

        static void AddStr(ref string[] arr, string value)
        {
            if(arr !=null && value != null)
            {
                string[] newArr = new string[arr.Length + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }

                newArr[newArr.Length - 1] = value;
                arr = newArr;
            }
          
        }


    }
}
