using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RSASignatureApplication2
{
    public class SocketInteractor
    {
        public int Change;
        private readonly IPEndPoint _remoteEndPoint;
        private readonly TcpClient _client;
        public string Data;
        
        public SocketInteractor()
        {
            Change = 0;
            var ipHostInfo = Dns.GetHostEntry("127.0.0.1");
            var ipAddress = ipHostInfo.AddressList[0];
            _remoteEndPoint = new IPEndPoint(ipAddress, 11000);
            _client = new TcpClient(ipAddress.AddressFamily);
        }
        
        public void Connect()
        {
            _client.Connect(_remoteEndPoint);
        }

        public async Task Listen()
        {
            var buffer = new byte[1024];
            var stream = _client.GetStream();
            var receivedBytes = await stream.ReadAsync(buffer, 0, buffer.Length);
            Data = Encoding.ASCII.GetString(buffer, 0, receivedBytes);
            if (Data.StartsWith("3"))
            { 
                Change = 1;    
            }
        }

        public void Close()
        {
            _client.Close();
        }
    }
}