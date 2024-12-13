class Program { 
    public static async Task Main(){
        string filePath = "largefile.txt";
        // string content = await ReadLargeFileAsync(filePath);
        Task<string> fileTask = ReadLargeFileAsync(filePath);
        Console.WriteLine("After fileTask");

        string content = await fileTask;
        Console.WriteLine(content);
    }
    static async Task<string> ReadLargeFileAsync(string path) { 
        string content = "";
        using (var reader = new StreamReader(path))
        {
            string? line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                content += line;
                Console.WriteLine(line);
            }
        }

        return content;
    }

}