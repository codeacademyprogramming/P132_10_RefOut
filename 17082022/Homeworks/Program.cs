using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[0];
            string menu;
            string name;
            do
            {
                Console.WriteLine("1. Siyahiya bax");
                Console.WriteLine("2. Siyahiya ad elave et");
                Console.WriteLine("3. Siyahida adi yoxla");
                Console.WriteLine("4. Adi goster");
                Console.WriteLine("0. Cixis");

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        ShowArr(names);
                        break;
                    case "2":
                        Console.WriteLine("Adi daxil edin:");
                        name = Console.ReadLine();

                        if (name.Length <= 2)
                            Console.WriteLine("Adin uzunlugu minimum 3 olmalidir!");
                        else if (IsDigit(name[0]))
                            Console.WriteLine("Ad reqemle baslaya bilmez!");
                        else if (IsExist(name, names))
                            Console.WriteLine("Bu ad artiq elave edilib!");
                        else
                            names = AddStr(names, name);
                        break;
                    case "3":
                        Console.WriteLine("Axtaris etdiyiniz adi daxil edin:");
                        name = Console.ReadLine();

                        if(IsExist(name,names))
                            Console.WriteLine("var");
                        else
                            Console.WriteLine("yoxdur");

                        break;
                    case "4":
                        Console.WriteLine("index daxil edin:");
                        string indexStr = Console.ReadLine();
                        int index = Convert.ToInt32(indexStr);

                        if(index>0 && index<names.Length)
                            Console.WriteLine(names[index]);
                        else
                            Console.WriteLine("Index yanlisdir!");
                        break;
                    case "0":
                        Console.WriteLine("Bitdi!");
                        break;
                    default:
                        Console.WriteLine("Dogru secim edin!");
                        break;
                }



            } while (menu!="0");

        }

        static void ShowArr(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static bool IsExist(string str,string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == str)
                    return true;
            }

            return false;
        }

        static string[] AddStr(string[] arr,string value)
        {
            string[] newArr = new string[arr.Length + 1];

            for(int i = 0; i<arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            return newArr;
        }

        static bool IsDigit(char chr)
        {
            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //for(int i = 0;i < digits.Length; i++)
            //{
            //    if (digits[i] == chr)
            //        return true;
            //}

            //return false;

            if (chr >= '0' && chr <= '9')
                return true;
            else
                return false;
        }
    }
}
