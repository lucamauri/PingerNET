using System.Net;

namespace SynthesisCode.PingerNET;

public class IPCalculator
{
    public IPAddress GetNetworkAddress(IPAddress address, IPAddress subnetMask)
    {
        byte[] ipAdressBytes = address.GetAddressBytes();
        byte[] subnetMaskBytes = subnetMask.GetAddressBytes();

        if (ipAdressBytes.Length != subnetMaskBytes.Length)
        {
            throw new ArgumentException("Lengths of IP address and subnet mask do not match.");
        }

        byte[] networkAddressBytes = new byte[ipAdressBytes.Length];
        for (int i = 0; i < ipAdressBytes.Length; i++)
        {
            networkAddressBytes[i] = (byte)(ipAdressBytes[i] & subnetMaskBytes[i]);
        }

        return new IPAddress(networkAddressBytes);
    }
}