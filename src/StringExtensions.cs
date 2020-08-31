namespace PirateCat.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        /// <remarks>Taken from Unity FPS sample</remarks>
        public static string AfterFirst(this string str, string sub)
        {
            var idx = str.IndexOf(sub);
            return idx < 0 ? "" : str.Substring(idx + sub.Length);
        }

        /// <summary>
        /// Get the position after the last match of substring
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        /// <remarks>Taken from Unity FPS sample</remarks>
        public static string AfterLast(this string str, string sub)
        {
            var idx = str.LastIndexOf(sub);
            return idx < 0 ? "" : str.Substring(idx + sub.Length);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        /// <remarks>Taken from Unity FPS sample</remarks>
        public static string BeforeFirst(this string str, string sub)
        {
            var idx = str.IndexOf(sub);
            return idx < 0 ? "" : str.Substring(0, idx);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        /// <remarks>Taken from Unity FPS sample</remarks>
        public static string BeforeLast(this string str, string sub)
        {
            var idx = str.LastIndexOf(sub);
            return idx < 0 ? "" : str.Substring(0, idx);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <remarks>
        /// Taken from uMMORPG codebase
        /// string.GetHashCode is not guaranteed to be the same on all machines, but
        /// we need one that is the same on all machines. simple and stupid.
        /// </remarks>
        public static int GetStableHashCode(this string text)
        {
            unchecked {
                int hash = 23;
                foreach (char c in text)
                    hash = hash * 31 + c;

                return hash;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        /// <remarks>Taken from Unity FPS sample</remarks>
        public static int PrefixMatch(this string str, string prefix)
        {
            int l = 0, slen = str.Length, plen = prefix.Length;
            while (l < slen && l < plen) {
                if (str[l] != prefix[l])
                    break;
                l++;
            }
            return l;
        }
    }
}
