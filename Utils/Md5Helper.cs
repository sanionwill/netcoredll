using System.Text;
using System.Security.Cryptography;

public class Md5Helper
{
    /// <summary>
    /// 32位字符串MD5加密
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Compute(string str)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(str);

        #region Net6.0
        bytes = MD5.Create().ComputeHash(bytes);
        #endregion

        StringBuilder sb = new StringBuilder();
        foreach (byte num in bytes)
        {
            sb.AppendFormat("{0:x2}", num);
        }
        return sb.ToString().ToUpper();
    }
}