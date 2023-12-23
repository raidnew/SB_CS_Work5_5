using System;

namespace Work5_5
{
    public class Work5_5
    {
        public static string RequestStringFromUser(string defaultLine = "Word1 Word2 Word3 Word4 Word5 Word6 Word7 Word8")
        {
            string inputString = Console.ReadLine();
            if(inputString == "") return defaultLine;
            return inputString;
        }
        
        public static string[] SplitString(string text, char delmitter = ' ')
        {
            return text.Split(delmitter);
        }
    }
}