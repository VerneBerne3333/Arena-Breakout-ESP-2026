("Hello! Starting script workflow...");

// Fast, low-ceremony file writing
string path = "log.txt";
string content = $"Log entry created at: {DateTime.Now}";

File.WriteAllText(path, content);
Console.WriteLine($"File successfully written to {path}");

