namespace OOP_LAB1_UTM.Core
{
    public class Display
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Ppi { get; set; }
        public String Model { get; set; } = string.Empty;


        private void Compare(Display m, Func<Display, double> getValue, string quality)
        {
            double thisValue = getValue(this);
            double otherValue = getValue(m);

            if (thisValue > otherValue)
            {
                Console.WriteLine($"Monitor {this.Model} is {quality} than Monitor {m.Model}");
            }
            else if (thisValue < otherValue)
            {
                Console.WriteLine($"Monitor {m.Model} is {quality} than Monitor {this.Model}");
            }
            else
            {
                Console.WriteLine($"Monitor {this.Model} and Monitor {m.Model} have the same {quality}");
            }
        }

        public void CompareSize(Display m)
        {
            Compare(m, d => Specification.CalculateDiagonal(d.Width, d.Height), "bigger");
        }

        public void CompareSharpness(Display m)
        {
            Compare(m, d => d.Ppi, "sharper");
        }

        public void CompareWithMonitor(Display m)
        {
            CompareSize(m);
            CompareSharpness(m);
        }
    }
}


