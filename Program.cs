﻿using OOP_LAB1_UTM.Core;

namespace OOP_LAB1_UTM
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = args[0];
            string content = FileReader.ReadFileToString(filePath);

            if (content == null)
            {
                Console.WriteLine("Failed to load file.");
                return;
            }

            TextData textData = new TextData(content, filePath);
            Console.WriteLine($"Name: {Path.GetFileName(textData.FileName)}");
            Console.WriteLine($"Text: {textData.Text}");
            Console.WriteLine($"Number of vowels: {textData.NumberOfVowels}");
            Console.WriteLine($"Number of consonants: {textData.NumberOfConsonants}");
            Console.WriteLine($"Number of letters: {textData.NumberOfLetters}");
            Console.WriteLine($"Number of sentences: {textData.NumberOfSentences}");
            Console.WriteLine($"Longest word: {textData.LongestWord}");

            Display display1 = new Display()
            {
                Width = 45,
                Height = 25,
                Ppi = 401,
                Model = "LG"
            };

            Display display2 = new Display
            {
                Width = 60,
                Height = 35,
                Ppi = 300,
                Model = "Samsung"
            };

            Display display3 = new Display
            {
                Width = 60,
                Height = 35,
                Ppi = 600,
                Model = "HP"
            };

            //comparing by size
            display1.CompareSize(display2);
            display2.CompareSize(display3);
            display3.CompareSize(display1);

            //comparing by sharpness
            display1.CompareSharpness(display2);
            display2.CompareSharpness(display3);
            display3.CompareSharpness(display1);

            //compare by both criterias
            display1.CompareWithMonitor(display2);
            display3.CompareWithMonitor(display2);
            display2.CompareWithMonitor(display1);
        }
    }
}
