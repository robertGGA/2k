using Microsoft.Build.Framework;
using TaskTracker.Core.Entities;

namespace TaskTracker.Core.Middlewares;

public class LoggerMiddleware
{
    public void LogFile(string log)
    {
        File.AppendAllText("./log.txt", log);
    }
    
}