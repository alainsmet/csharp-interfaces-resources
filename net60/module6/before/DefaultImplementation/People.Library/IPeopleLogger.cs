﻿namespace People.Library;

public enum PeopleLogLevel
{
    Critical,
    Error,
    Warning,
    Information,
    Debug,
    Trace
}

public interface IPeopleLogger
{
    public void Log(PeopleLogLevel level, string message);
    public void LogException(Exception ex)
    {
        Log(PeopleLogLevel.Error, ex.Message);
    }
}
