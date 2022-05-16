using System.Security.Cryptography;
using System.Text;

namespace SuperHelper.Utils
{
    public class CryptographyUtil
    {
        public static string MD5Encrypt(string str)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = Encoding.UTF8.GetBytes(str);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            var sTemp = "";
            for (var i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            str = sTemp.ToLower();
            return str;
        }
    }
}
