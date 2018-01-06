using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class TCPHandler
    {
        private delegate void Packet_(int index, byte[] data);
        private static Dictionary<int, Packet_> packets;

        public static void InitializeTCPHandler()
        {
            Console.WriteLine("Initializing TCP handler");
            packets = new Dictionary<int, Packet_>
            {
               // {(int)ClientPackets.CThankYou, HandleThankyou }
            };
        }

        public static void HandleNetworkInformation(int index, byte[] data)
        {
            int packetnum; PacketBuffer buffer = new PacketBuffer();
            buffer.WriteBytes(data);
            packetnum = buffer.ReadInteger();
            buffer.Dispose();
            if (packets.TryGetValue(packetnum, out Packet_ Packet))
            {
                Packet.Invoke(index, data);
            }
        }
    }
}
