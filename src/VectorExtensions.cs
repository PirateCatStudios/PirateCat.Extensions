
using UnityEngine;

namespace PirateCat.Extensions
{
    public static class VectorExtensions
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static bool IsZero(this Vector3 vector)
        {
            return vector == Vector3.zero;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float Distance(this Vector3 vector, Vector3 to)
        {
            return Vector3.Distance(vector, to);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float Distance2D(this Vector3 vector, Vector3 to)
        {
            vector = vector.To2D();
            to = to.To2D();
            return Vector3.Distance(vector, to);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        /// <remarks>This is not going to turn the Vector3 into a Vector2, just 0 out the y.</remarks>
        public static Vector3 To2D(this Vector3 vector)
        {
            vector.y = 0f;
            return vector;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Vector3 GetNormalized2D(this Vector3 vector)
        {
            vector.y = 0f;
            return vector.normalized;
        }

        /// <summary>
        /// Round a vector3 to the nearest int values.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector3 Round(this Vector3 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            v.z = Mathf.Round(v.z);

            return v;
        }

        /// <summary>
        /// Round a Vector3 based on a variable grid size.
        /// </summary>
        /// <param name="v">The <see cref="Vector3"/></param>
        /// <param name="size">The grid size</param>
        /// <returns></returns>
        public static Vector3 Round(this Vector3 v, float size)
        {
            return (v / size) * size;
        }

        /// <summary>
        /// Cast a Vector3Int to a Vector3
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Vector3 ToVector3(this Vector3Int vector) {
            return (Vector3)(vector);
        }
    }
}
