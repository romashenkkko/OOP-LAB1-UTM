public static class FileReader
{
    public static string ReadFileToString(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading the file: {e.Message}");
            return null;
        }
    }
}
