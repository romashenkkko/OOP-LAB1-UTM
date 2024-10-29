using OOP_LAB1_UTM.Core;

namespace OOP_LAB1_UTM
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Please provide file paths as arguments.");
                return;
            }


            foreach (string filePath in args)
            {
                string content = FileReader.ReadFileToString(filePath);

                TextData textData = new TextData(content, filePath);
                Console.WriteLine($"Name: {Path.GetFileName(textData.FileName)}");
                Console.WriteLine($"Text: {textData.Text}");
                Console.WriteLine($"Number of vowels: {textData.NumberOfVowels}");
                Console.WriteLine($"Number of consonants: {textData.NumberOfConsonants}");
                Console.WriteLine($"Number of letters: {textData.NumberOfLetters}");
                Console.WriteLine($"Number of sentences: {textData.NumberOfSentences}");
                Console.WriteLine($"Longest word: {textData.LongestWord}");
            }
  
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

            Assistant assistant1 = new Assistant { AssistantName = "Helper 1" };
            assistant1.ClearDisplays();
            assistant1.AssignDisplay(display1);
            assistant1.AssignDisplay(display2);
            assistant1.AssignDisplay(display3);

            Console.WriteLine("Compare monitors using assistant1 Helper 1:");
            assistant1.Assist();

            Console.WriteLine("What monitors remains in stock?");
            assistant1.BuyDisplay(display1);

            foreach (var display in assistant1.AssignedDisplay)
            {
                Console.WriteLine(display);
            }


            Console.WriteLine("This are the comparisons by methoods");
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
