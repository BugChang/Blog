using System.Security.Cryptography;
using System.Text;

namespace Blog.Utility
{
    public static class HashHelper
    {
        public static string ComputeSha256Hash(string input)
        {
            using var sha256 = SHA256.Create();
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var hashBytes = sha256.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("x2")); // Convert byte to hexadecimal
            }
            return sb.ToString();
        }
    }
}
