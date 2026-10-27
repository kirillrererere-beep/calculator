namespace VakhrushevCalculatorLib.Infrastructure;

internal static class AppPaths
{
    private const string AppFolderName = "PocketCalc";

    public static string GetFilePath(string fileName)
    {
        var baseDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        return Path.Combine(baseDir, AppFolderName, fileName);
    }
}
