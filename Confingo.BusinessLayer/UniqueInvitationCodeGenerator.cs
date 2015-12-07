using System.Security.Cryptography;
using System.Text;

namespace Confingo.BusinessLayer
{
    public class UniqueInvitationCodeGenerator 
    {
        private static readonly int MaxSize = 5;
        private static readonly char[] Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        public string GetUniqueKey()
        {
            var data = new byte[1];
            using (var crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[MaxSize];
                crypto.GetNonZeroBytes(data);
            }
            var result = new StringBuilder(MaxSize);
            foreach (var @byte in data)
            {
                result.Append(Chars[@byte % (Chars.Length)]);
            }
            return result.ToString();
        }
    }
}
