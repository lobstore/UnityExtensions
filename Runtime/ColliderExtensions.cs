using UnityEngine;

namespace LOGIYGames.Extensions
{
    public static class ColliderExtensions
    {
        /// <summary>
        /// Returns distance from center to lower collider bounds point 
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        static public float LowerHalfHeight(this Collider col)
        {
            return Mathf.Abs(col.bounds.center.y) - Mathf.Abs(col.bounds.min.y);
        }
        /// <summary>
        /// Returns distance from top to center collider bounds point 
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        static public float TopHalfHeight(this Collider col)
        {
            return Mathf.Abs(col.bounds.max.y) - Mathf.Abs(col.bounds.center.y);
        }
    }
}
