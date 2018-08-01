﻿using System;

public class Application
{
    public static void Main()
    {
        var logger = Logger.GetLogger();
    }
}

public class Logger
{
    private static Logger instance = null;

	private Logger()
	{
	}

    public static Logger GetLogger()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public string Info(string infomsg)
    {
        return infomsg;
    }

    public string Exception(string excmsg)
    {
        return excmsg;
    }

    public string Warning(string warnmsg)
    {
        return warnmsg;
    }

}
