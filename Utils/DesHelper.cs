
using System.Text;
using System.Security.Cryptography;

public class DesHelper
{
    private static byte[] IV_Keys = { 0xCD, 0xED, 0x39, 0x88, 0x90, 0x56, 0x10, 0x12 };
    public string DESEncrypt(string sourceStr, string key)
    {
        try
        {
            byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, 8));
            byte[] rgbIV = IV_Keys;
            byte[] inputByteArray = Encoding.UTF8.GetBytes(sourceStr);

            #region  Net5.0及以下
            // DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();//.net6.0会报SYSLIB0021警告
            // using (MemoryStream mStream = new MemoryStream())
            // {
            //     using (CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write))////.net6.0会报SYSLIB0021警告
            //     {
            //         cStream.Write(inputByteArray, 0, inputByteArray.Length);
            //         cStream.FlushFinalBlock();
            //         return Convert.ToBase64String(mStream.ToArray());
            //     }
            // }
            #endregion

            #region  Net6.0
            using (MemoryStream mStream = new MemoryStream())
            {
                using (CryptoStream cStream = new CryptoStream(mStream, DES.Create().CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write))////.net6.0会报SYSLIB0021警告
                {
                    cStream.Write(inputByteArray, 0, inputByteArray.Length);
                    cStream.FlushFinalBlock();
                    return Convert.ToBase64String(mStream.ToArray());
                }
            }
            #endregion
        }
        catch
        {
            return sourceStr;
        }
    }
}