﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsolServer
{
    class Program
    {
        static int Main(string[] args)
        {
            AsynchronousSocketListener.StartListening();
            return 0;
        }

    }
}
