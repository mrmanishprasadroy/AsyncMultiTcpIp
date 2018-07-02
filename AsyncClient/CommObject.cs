using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AsyncClient
{
    public class CommObject
    {
        public Socket m_WorkScoket = null;
        /// <summary>
        ///  Size of recieve Buffer
        /// </summary>
        public const int BufferSize = 1024;

        /// <summary>
        /// Receive Buffer 
        /// </summary>
        public byte[] buffer = new byte[BufferSize];

    }
}
