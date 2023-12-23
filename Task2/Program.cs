using System;

namespace Work5_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task2 task2 = new Task2();
            task2.Run();
        }
    }
    
    class Task2
    {
        public Task2()
        {
        }

        public void Run()
        {
            string usersString = Work5_5.RequestStringFromUser();
            string reversedUsersString = Task2.GetStringWithReverseOrderWords(usersString);
            Console.WriteLine(reversedUsersString);
        }
        
        private static string GetStringWithReverseOrderWords(string text, char stringDelimiter = ' ')
        {
            string[] wordsArray = Work5_5.SplitString(text, stringDelimiter);
            Array.Reverse(wordsArray);
            return String.Join(stringDelimiter.ToString(), wordsArray);
        }
    }
}