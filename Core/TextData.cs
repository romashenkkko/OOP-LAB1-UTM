using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1_UTM.Core
{
    public class TextData
    {
        public String FileName {  get; set; } = string.Empty;
        public String Text { get; set; } = string.Empty;
        public int NumberOfVowels { get; set; }
        public int NumberOfConsonants { get; set; }
        public int NumberOfLetters  {get; set; }
        public int NumberOfSentences { get; set;}
        public String LongestWord { get; set; } = string.Empty;

        public TextData(string text, string fileName)
        {
            Text = text;
            FileName = fileName;
            CalculateMetrics();

        }
        private void CalculateMetrics()
        {
            Text = GetText();
            FileName = GetFileName();
            NumberOfVowels = GetNumberOfVowels();
            NumberOfConsonants = GetNumberOfConsonants();
            NumberOfLetters = NumberOfVowels + NumberOfConsonants;
            NumberOfSentences = GetNumberOfSentences();
            LongestWord = GetLongestWord();
        }
        private String GetFileName()
        { 
            return FileName;
        }

        private String GetText()
        { 
            return Text; 
        }

        private int GetNumberOfVowels()
        {
            return Text.Count("aeiouAEIOU".Contains);

        }
        private int GetNumberOfConsonants()
        {
            return Text.Count("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains);
        }

        private int GetNumberOfSentences()
        {
            return Text.Split(new char[] { '.', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private string GetLongestWord()
        {
            return Text.Split(new char[] { ' ', '.', '?', '!', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
                       .OrderByDescending(s => s.Length)
                       .FirstOrDefault();
        }


    }
}
