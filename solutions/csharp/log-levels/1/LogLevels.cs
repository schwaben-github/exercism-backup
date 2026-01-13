using System;
using System.Text.RegularExpressions;

public static class LogLine
{
    public static string Message(string logLine)
    {
        var messageMatch = Regex.Match(logLine, @"\]:\s*(.*)");
        return messageMatch.Groups[1].Value.Trim();
    }

    public static string LogLevel(string logLine)
    {
        var levelMatch = Regex.Match(logLine, @"\[(.*?)\]");
        return levelMatch.Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);
        return $"{message} ({logLevel})";
    }
}