public static class FileReader
{
    public static string ReadFileToString(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine($"Error reading the file: {e.Message}");
            return null;
        }
    }
}
