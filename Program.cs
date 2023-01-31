using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Find1stWord("hello usaqlarr");
            Console.WriteLine(word);
        }
        static int Find1stWord(string text)
        {
            string word = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    break;
               do
                {
                }
                while(text.Length > 0);
                    
                   
                





            }
            return word.Length;
            //yaza bilmedim muellim, alinmadi

        }
    }
}
