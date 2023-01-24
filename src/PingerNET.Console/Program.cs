// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SynthesisCode.PingerNET;
using System.Net;

IPCalculator IPCalc = new IPCalculator();


Console.WriteLine(IPCalc.GetNetworkAddress(IPAddress.Parse("192.168.1.15"), IPAddress.Parse("255.255.255.0")));