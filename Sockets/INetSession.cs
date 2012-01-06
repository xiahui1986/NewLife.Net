﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace NewLife.Net.Sockets
{
    /// <summary>网络服务会话接口</summary>
    public interface INetSession : IDisposable2
    {
        /// <summary>编号</summary>
        Int32 ID { get; set; }
        
        /// <summary>Socket服务器。当前通讯所在的Socket服务器，其实是TcpServer/UdpServer</summary>
        ISocketServer Server { get; set; }

        /// <summary>客户端。跟客户端通讯的那个Socket，其实是服务端TcpClientX/UdpServer</summary>
        ISocketSession Session { get; set; }

        /// <summary>客户端远程IP终结点</summary>
        EndPoint ClientEndPoint { get; set; }
    }
}