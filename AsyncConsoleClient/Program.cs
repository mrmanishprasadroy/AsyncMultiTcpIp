﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsoleClient
{
    class Program
    {
        static int Main(string[] args)
        {
            AsynchronousClient.StartClient();
            return 0;
        }
    }
}
