using System;
using System.Collections.Generic;
using System.Linq;

namespace PirateCat.Extensions
{
    public static class ListExtensions
    {
        private static Random random = new Random();

        /// <summary>
        /// Shuffle the list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="seed"></param>
        /// <typeparam name="T"></typeparam>
        public static void Shuffle<T>(this IList<T> list, int seed = 0)
        {
            if (seed != 0) {
                random = new Random(seed);
            }

            if (list.Count <= 1) return;

            for (int i = list.Count - 1; i >= 0; i--) {
                T tmp = list[i];
                int randomIndex = random.Next(i + 1);

                list[i] = list[randomIndex];
                list[randomIndex] = tmp;
            }
        }

        /// <summary>
        /// Check if other is a subset of list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsSubsetOf<T>(this IList<T> list, IList<T> other)
        {
            return other.All(element => list.Contains(element));
        }

        /// <summary>
        /// Convert to a HasSet
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
        {
            return new HashSet<T>(source);
        }
    }
}
