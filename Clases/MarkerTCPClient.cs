using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HMI_25024WE
{
    public class MarkerTCPClient
    {
        private string markerIp;
        private int markerPort;
        private TcpClient tcpClient;
        private NetworkStream stream;

        public MarkerTCPClient(string markerIp, int markerPort)
        {
            this.markerIp = markerIp;
            this.markerPort = markerPort;
        }

        public string SendCommand(string command)
        {
            try
            {
                tcpClient = new TcpClient(markerIp, markerPort);

                byte[] data = Encoding.ASCII.GetBytes(command + '\u000D');

                stream = tcpClient.GetStream();
                stream.ReadTimeout = 120000;
                stream.Write(data, 0, data.Length);
                stream.Flush();

                data = new byte[256];

                stream.Read(data, 0, data.Length);
                stream.Close();

                tcpClient.Close();

                return Encoding.ASCII.GetString(data).Replace('\0', ' ').Trim();
            }
            catch(Exception ex)
            {
                return $"EXCEPTION={ex.Message}";
            }
        }

        public string Ready() {
            return SendCommand("RX,Ready");
        }
    }
}
