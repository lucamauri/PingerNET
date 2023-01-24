using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisCode.PingerNET;

public class Pinger
{
    public async Task<PingReply[]> PingIpsAsync(string[] ips)
    {
        var pingTasks = ips.Select(ip => new Ping().SendPingAsync(ip)).ToArray();
        return await Task.WhenAll(pingTasks);
    }
}