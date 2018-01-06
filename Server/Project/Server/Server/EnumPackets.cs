using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    // sent from server to client;
    public enum ServerPackets
    {
        SConnectionOK = 1,
    }

    // from client to server
    // server has to listen to this
    public enum ClientPackets
    {
        CThankYou = 1,
    }
}
