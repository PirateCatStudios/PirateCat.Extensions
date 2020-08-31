using UnityEngine;

namespace PirateCat.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Check if the GameObject has a component or not.
        /// </summary>
        /// <param name="obj"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool HasComponent<T>(this GameObject obj) where T : Component
        {
            return obj.GetComponent<T>() != null;
        }
    }
}
