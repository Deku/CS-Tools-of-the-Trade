using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace TooT
{
    public static class StringUtils
    {
        private const string FORMAT_ARGS_PATTERN = @"(?<!\{)(?>\{\{)*\{\d(.*?)";

        public static bool IsStringFormat(string str)
        {
            return Regex.Matches(str, FORMAT_ARGS_PATTERN).Count > 0;
        }

        /// <summary>
        /// Returns the number of unique parameters required by the format string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountFormatArgs(string str)
        {
            MatchCollection ms = Regex.Matches(str, FORMAT_ARGS_PATTERN);

            if (ms.Count > 1)
                return ms.Cast<Match>().Select(m => m.Value).Distinct().Count();

            return ms.Count;
        }

        /// <summary>
        /// Retorna una cadena aleatoria del tamaño indicado, de forma rápida. NO utilizar para temas
        /// de seguridad, ya que las cadenas podrían repetirse más de una vez.
        /// </summary>
        /// <param name="size">Tamaño de la cadena</param>
        /// <returns></returns>
        public static string GetRandomString(int size)
        {
            var pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = new char[size];
            var random = new Random();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = pool[random.Next(pool.Length)];
            }

            return chars.ToString().Substring(0, size);
        }

        /// <summary>
        /// Retorna una cadena aleatoria del tamaño indicado. Es más confiable que
        /// el método GenerateRandomString() pero toma más tiempo en procesar.
        /// </summary>
        /// <param name="size">Tamaño de la cadena</param>
        /// <returns></returns>
        public static string GetSecureRandomString(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            Byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff).Substring(0, size);
        }
    }
}
