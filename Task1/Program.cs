using System;
using System.Text;

namespace Work5_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task1 task2 = new Task1();
            task2.Run();
        }
    }
    
    class Task1
    {
        public Task1()
        {
        }

        public void Run()
        {
            Console.WriteLine("Enter a string or leave blank for default string");
            string userString = Work5_5.RequestStringFromUser();
            string[] wordsArray = Work5_5.SplitString(userString);
            string arrayAsMultiLineString = GetArrayAsMultiLineString(wordsArray);
            Console.WriteLine(arrayAsMultiLineString);
        }
        
        private static string GetArrayAsMultiLineString(string[] wordsArray)
        {
            StringBuilder multiLineString = new StringBuilder();
            for (int i = 0; i < wordsArray.Length; i++)
            {
                multiLineString.Append($"{wordsArray[i]}");
                if (i < wordsArray.Length - 1)
                {
                    multiLineString.Append($"{Environment.NewLine}");
                }
            }
            return multiLineString.ToString();
        }
    }
}