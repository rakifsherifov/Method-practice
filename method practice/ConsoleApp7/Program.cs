using System;
using System.Xml;

namespace ConsoleApp7
{
    internal class Program
    //Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod
    {
        static void Main(string[] args)
        {
            var output = RemoveSpace ("Hello usaqlar");
            Console.WriteLine(output);
        }
        static string RemoveSpace(string input)
        {
            string output= "";

            for (int i = 0; i <input.Length; i++)
            {
                if (input[i] !=' ')
                {
                    output += input[i];
                }
                
            }
            return output;
        }
    }
}
