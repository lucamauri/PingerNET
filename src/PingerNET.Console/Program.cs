// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SynthesisCode.PingerNET;
using System.Net;

//TEST for calculator
IPCalculator IPCalc = new();
Console.WriteLine(IPCalc.GetNetworkAddress(IPAddress.Parse("192.168.1.15"), IPAddress.Parse("255.255.255.0")));

//TEST for pinger
Pinger networkHelper = new Pinger();
string[] ips = { "192.168.1.1", "192.168.1.2", "192.168.1.3" };
var replies = await networkHelper.PingIpsAsync(ips);
Console.WriteLine(String.Format("|{0,40}|{1,15}|{2,30}|{3,17}|", "DNS", "Address", "Status", "Round trip time"));
Console.WriteLine(new String('=', 107));
foreach (var reply in replies)
{
    Console.WriteLine(String.Format("|{0,40}|{1,15}|{2,30}|{3,17}|", Dns.GetHostEntry(reply.Address).HostName, reply.Address, reply.Status, reply.RoundtripTime));
}