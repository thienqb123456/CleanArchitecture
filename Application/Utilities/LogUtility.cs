namespace Application.Utilities;

public class LogUtility
{
    private static readonly ILogger<LogUtility> Logger = CreateLogger<LogUtility>();

    public static string Message(string message, params object?[] @params)
    {
        var result = "";
        try
        {
            result += $"({@params.Where(param => param != null).Aggregate("", (current, param) => current + (string.IsNullOrEmpty(current) ? "" : ",") + param.ToJson())})";
            if (!string.IsNullOrEmpty(message)) result += Environment.NewLine + message;
        }
        catch (Exception exception)
        {
            Logger.LogError(exception, "LogUtility.Message");
        }
        return result;
    }
}