﻿using JT808.Protocol;
using log4net;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Text;
using Protocol.Common.Extensions;

namespace GPS.Gateway.JT808SuperSocketServer
{
    public class JT808RequestInfo : IRequestInfo
    {
        public string Key => "JT808";

        public JT808Package JT808Package { get; }

        public JT808RequestInfo(byte[] buffer)
        {
            try
            {
                JT808Package = MessagePack.MessagePackSerializer.Deserialize<JT808Package>(buffer);
            }
            catch (Exception ex)
            {
                JT808Package = null ;
            }
        }
    }
}
