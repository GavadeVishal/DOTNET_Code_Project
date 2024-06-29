using System;
using System.Net;

class Program
{
    static void Main()
    {
        
        string ipAddress = GetLocalIPAddress();

        
        Console.WriteLine($"Local machine's IP address: {ipAddress}");
    }

    static string GetLocalIPAddress()
    {
        
        string hostName = Dns.GetHostName();

        
        IPAddress[] addresses = Dns.GetHostAddresses(hostName);


        foreach (IPAddress addr in addresses)
        {
            if (addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !IPAddress.IsLoopback(addr))
            {
                return addr.ToString();
            }
        }

        throw new ApplicationException("No suitable IP address found.");
    }
}
