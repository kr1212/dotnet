﻿using System;

namespace Nagarro.BookReadingEvent.Data
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine("EF Message: {0} ", message);
        }
    }
}
