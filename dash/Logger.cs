﻿namespace Dash
{
    using System;
    using System.IO;
    using System.Text;

    public class Logger
    {
        public static void Log(string message)
        {
            var logFile = Environment.CurrentDirectory + "\\crash_log.txt";
            var sb = new StringBuilder();

            sb.Append(message);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.StackTrace);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            File.AppendAllText(logFile, sb.ToString());
        }
    }
}