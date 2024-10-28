namespace OOP_LAB1_UTM.Core
{
    public class Display
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Ppi { get; set; }
        public String Model { get; set; } = string.Empty;


        public void CompareSize(Display m)
        {
            
            if (Specification.CalculateDiagonal(m.Width, m.Height) > Specification.CalculateDiagonal(this.Width, this.Height))
            {
                Console.WriteLine($"Monitor {this.Model} is bigger than {m.Model}");
            }
           else if (Specification.CalculateDiagonal(m.Width, m.Height) == Specification.CalculateDiagonal(this.Width, this.Height))
            {
                Console.WriteLine($"Monitor {this.Model} equal in size with monitor {m.Model}");
            }
            else
            {
                Console.WriteLine($"Monitor {m.Model} is bigger in size than {this.Model}");
            }
        }

        public void CompareSharpness(Display m)
        {
            if (this.Ppi > m.Ppi)
            {
                Console.WriteLine($"Monitor {this.Model} is sharper than Monitor {m.Model}");
            }
            else if (this.Ppi < m.Ppi)
            {
                Console.WriteLine($"Monitor {m.Model} is sharper than Monitor {this.Model}");
            }
            else
            {
                Console.WriteLine($"Monitor {this.Model} and Monitor {m.Model} have the same sharpness");
            }
        }
        public void CompareWithMonitor(Display m)
        {
            CompareSize(m);
            CompareSharpness(m);
        }

    }


}
