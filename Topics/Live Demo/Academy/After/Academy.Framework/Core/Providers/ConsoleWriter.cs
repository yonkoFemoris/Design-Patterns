﻿using Academy.Core.Contracts;
using System;

namespace Academy.Core.Providers
{
    public class ConsoleWriter : IWriter
    {
        public ConsoleWriter()
        {

        }

        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
