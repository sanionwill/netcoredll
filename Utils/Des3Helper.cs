using System;
using System.IO;
using System.Web;
using System.Net;
using System.Text;
using System.Security.Cryptography;

public class DES3Helper
{
    string iv = "abcd1234";//加密解密矢量，只有在CBC模式下才适用

    public string DES3Encrypt(string plainText, string key = "UKMXGTWRACINFGCFOJTNYZNV")  //key表示加密解密秘钥
    {
        string result = "";
        //加密
        try
        {
            #region Net6.0
            var des = TripleDES.Create();
            des.Key = Encoding.UTF8.GetBytes(key);
            des.Mode = CipherMode.CBC;
            des.Padding = PaddingMode.PKCS7;
            #endregion

            des.IV = Encoding.UTF8.GetBytes(iv);

            var desEncrypt = des.CreateEncryptor();
            byte[] buffer = Encoding.UTF8.GetBytes(plainText);
            result = Convert.ToBase64String(desEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));
        }
        catch (Exception)
        {
            result = string.Empty;
        }

        Console.WriteLine("CAL=" + result);
        return result;
    }
}