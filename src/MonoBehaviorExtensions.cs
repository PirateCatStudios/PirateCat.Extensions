using System;
using System.Collections;
using UnityEngine;

namespace PirateCat.Extensions
{
    public static class MonoBehaviorExtensions
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="monoBehaviour"></param>
        /// <param name="action"></param>
        /// <param name="delay"></param>
        public static void Invoke(this MonoBehaviour monoBehaviour, Action action, float delay = 0f)
        {
            if (delay == 0f) {
                action?.Invoke();
            } else {
                monoBehaviour.StartCoroutine(DelayedInvoke(action, delay));
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="monoBehaviour"></param>
        /// <param name="action"></param>
        /// <param name="arg"></param>
        /// <param name="delay"></param>
        /// <typeparam name="T"></typeparam>
        public static void Invoke<T>(this MonoBehaviour monoBehaviour, Action<T> action, T arg, float delay = 0f)
        {
            if (delay == 0f) {
                action?.Invoke(arg);
            } else {
                monoBehaviour.StartCoroutine(DelayedInvoke(action, arg, delay));
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="action"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        private static IEnumerator DelayedInvoke(Action action, float delay)
        {
            yield return new WaitForSeconds(delay);
            action?.Invoke();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="action"></param>
        /// <param name="arg"></param>
        /// <param name="delay"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static IEnumerator DelayedInvoke<T>(Action<T> action, T arg, float delay)
        {
            yield return new WaitForSeconds(delay);
            action?.Invoke(arg);
        }
    }
}
