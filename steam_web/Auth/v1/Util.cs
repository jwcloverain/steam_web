﻿namespace SteamWeb.Auth.v1;
internal class Util
{
    public static int GetSystemUnixTime() => (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

    public static byte[] HexStringToByteArray(string hex)
    {
        int hexLen = hex.Length;
        byte[] ret = new byte[hexLen / 2];
        for (int i = 0; i < hexLen; i += 2)
        {
            ret[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }
        return ret;
    }
}
