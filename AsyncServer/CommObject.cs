using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AsyncServer
{
    public class CommObject
    {
        public Socket m_CurrentSocket = null;
        /// <summary>
        ///  Size of recieve Buffer
        /// </summary>
        public const int BufferSize = 1024;

        /// <summary>
        /// Receive Buffer 
        /// </summary>
        public byte[] dataBuffer = new byte[BufferSize];

        // Received data string.  
        public StringBuilder sb = new StringBuilder();

    }
}
