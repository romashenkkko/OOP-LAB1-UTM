namespace OOP_LAB1_UTM.Core
{
    public class Assistant
    {
        public string AssistantName { get; set; } = string.Empty;
        public List<Display> AssignedDisplay { get; set; } = new List<Display>();

        public void AssignDisplay(Display d)
        {  
                AssignedDisplay.Add(d);

        }

        public void ClearDisplays()
        {
            AssignedDisplay.Clear();
        }

        public void Assist()
        {
            for (int i = 0; i < AssignedDisplay.Count; i++)
            {
                for (int j = i + 1; j < AssignedDisplay.Count; j++)  
                {
                    AssignedDisplay[i].CompareSize(AssignedDisplay[j]);
                    AssignedDisplay[i].CompareSharpness(AssignedDisplay[j]);
                    AssignedDisplay[i].CompareWithMonitor(AssignedDisplay[j]);
                }
            }
        }
        public Display BuyDisplay(Display d)
        {
            AssignedDisplay.Remove(d);
            return d;
        }
    }

}
