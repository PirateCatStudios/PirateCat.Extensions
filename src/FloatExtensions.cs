using UnityEngine;

namespace PirateCat.Extensions
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Same as the Vector3.Round but for floats
        /// </summary>
        /// <param name="f"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static float Round(this float f, float size)
        {
            return Mathf.Round(f / size) * size;
        }
    }
}
