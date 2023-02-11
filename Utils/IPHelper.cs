
using System.Collections.Generic;
using System.Net;

class IPVModel
{
    public static string IPv4 = "InterNetwork";
    public static string IPv6 = "InterNetworkV6";
}

class IPHelper
{
    public List<string> GetLocalIp(string ipv)
    {
        List<string> listIP = new List<string>();
        string AddressIP = string.Empty;
        foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
        {
            if (_IPAddress.AddressFamily.ToString() == ipv)
            {
                listIP.Add(_IPAddress.ToString());
            }
        }
        return listIP;
    }
}