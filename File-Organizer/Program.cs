if (args.Length == 0)
{
    Console.WriteLine("No argument is provided.");
    return;
}

if (args.Length > 1)
{
    Console.WriteLine("Exactly one argument is required.");
    return;
}

var dirPath = args[0];
if (Directory.Exists(dirPath))
{
    var path = new DirectoryInfo(dirPath);
    var files = path.GetFiles();
    foreach (var file in files)
    {
        Console.WriteLine(file.Name + " - " + file.Extension + " - " + file.Length);
    }
}
else
{
    Console.WriteLine("Directory does not exist!");
}