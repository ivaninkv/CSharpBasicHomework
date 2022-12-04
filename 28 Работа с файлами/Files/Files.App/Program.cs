namespace Files.App;

public static class Program
{
    private static readonly string Dir1 = Path.Combine("c:", "Otus", "TestDir1");
    private static readonly string Dir2 = Path.Combine("c:", "Otus", "TestDir2");
    private static readonly IEnumerable<string> FileNames = Enumerable.Range(1, 10).Select(n => $"File{n}.txt");

    public static void Main(string[] args)
    {
        CreateDirectory(Dir1);
        CreateDirectory(Dir2);

        CreateFiles(Dir1, FileNames);
        CreateFiles(Dir2, FileNames);

        AppendFiles(Dir1, FileNames);
        AppendFiles(Dir2, FileNames);

        PrintFiles(Dir1, FileNames);
        PrintFiles(Dir2, FileNames);
    }

    private static void PrintFiles(string directory, IEnumerable<string> fileNames)
    {
        foreach (var fileName in fileNames)
        {
            try
            {
                var fullPath = Path.Combine(directory, fileName);
                using var streamReader = File.OpenText(fullPath);
                Console.WriteLine($"Full filename: {fullPath}, content:\n{streamReader.ReadToEnd()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void AppendFiles(string directory, IEnumerable<string> fileNames)
    {
        foreach (var fileName in fileNames)
        {
            try
            {
                using var streamWriter = File.AppendText(Path.Combine(directory, fileName));
                streamWriter.WriteLine(DateTime.Now);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    private static void CreateFiles(string directory, IEnumerable<string> fileNames)
    {
        foreach (var fileName in fileNames)
        {
            try
            {
                using var streamWriter = File.CreateText(Path.Combine(directory, fileName));
                streamWriter.WriteLine(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void CreateDirectory(string path)
    {
        try
        {
            var dir1 = new DirectoryInfo(path);
            if (!dir1.Exists)
            {
                dir1.Create();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
