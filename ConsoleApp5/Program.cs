﻿using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 45, 23, -3, 2, -10 };

            Console.WriteLine(Sum(nums));

            Console.WriteLine(Power(3.5, 4));

            Console.WriteLine(LetterCount("alma"));

            Console.WriteLine(HasA("hikmet"));


            Console.WriteLine(CharCount("Abbas", 'b'));


            nums = new int[] { 20, 30, 40, 50, 60 };

            var index = FindIndex(nums, 33);

            if (index == -1)
            {
                Console.WriteLine("axtardiginiz deyer yoxdur");
            }
            else
            {
                Console.WriteLine($ "axtardiginiz deyer {index}. indexde yerlesir");
            }

            var word = FindFirstWord("Salam Hikmet necesen");
            Console.WriteLine(word);
            {
                static double Sum(double x, double);

                return x + y;
            }
            static int Sum(int x, int y, int z = 0);
            {
                return x + y + z;
            }
            static int Sum(int x, int y);
            {
                return x + y;
            }

            //Verilmis ededler siyahisindaki musbet ededlerin cemini tapan metod
             static int Sum(int{ } arr);
            {
                int sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                        sum += arr[i];
                }
                return sum;
            }
            //Verilmis ededi verilmis quvvete yukselden metod
            static int Power(int num, int pow)
            {
                int result = 1;
                for (int i = 0; i < pow; i++)
                {
                    result*= num;
                }
                return result;
            }
            static int Power(int num, int pow)
            {
                int result = 1;

                for (int i = 0; i < pow; i++)
                {
                    result *= num;
                }

                return result;
            }
            //Verilmis yazida a charinin sayini tapan metod
            static int LetterCount(string text)
            {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a') ;
                    count++;
                }
                return count;
            }
            //Verilmis yazida a charinin olub olmadigini tapan metod
            static bool HasA(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a') ;
                    {
                        return true;
                    }
                }
                return false;
            }
            //Verilmis yazida verilmis charin sayini tapan metod
            static int CharCount(string text, char cr)
            {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == cr);
                    count++;

                }
                return count;
            }
            //Verilmis ededler siyahisinda verilmis ededin yerlesdiyi ilk indexi qaytaran metod

            static int FindIndex(int[]arr, int value)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == value) ;
                    return i;
                }
                return -1;
            }
            //Verilmis yazidaki ilk sozu (lk bosluga qeder olan hisseni) qaytaran metod

            static string FindFirstWord(string str)
            {
                string word ="";
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ') ;
                    break;
                    word += str[i];
                }
                return word;
            }



        }
    }
}
