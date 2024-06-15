#region

using UnityEngine;

#endregion

namespace rStarUtility.Util.Helper
{
    public static class VectorHelper
    {
    #region Public Methods

        public static float Distance(this Vector2 point1 , Vector2 point2)
        {
            var distance = (point1 - point2).sqrMagnitude;
            return distance;
        }

        /// <summary>
        ///     判斷兩點接不接近，可調整magnitude數值去判斷兩者距離多近才算
        /// https://www.cnblogs.com/MrZivChu/p/normalclass.html
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="magnitude">向量長度</param>
        /// <returns></returns>
        public static bool IsCloseThePoint(Vector2 point1 , Vector2 point2 , float magnitude)
        {
            var distance = Distance(point1 , point2);
            return distance <= magnitude;
        }

        public static Vector2 MultiplyX(this Vector2 vector2 , float x)
        {
            vector2.x *= x;
            return vector2;
        }

        public static Vector2 MultiplyY(this Vector2 vector2 , float y)
        {
            vector2.y *= y;
            return vector2;
        }

        public static Vector2 SetX(this Vector2 vector2 , float x)
        {
            vector2.x = x;
            return vector2;
        }

        public static Vector2 SetY(this Vector2 vector2 , float y)
        {
            vector2.y = y;
            return vector2;
        }

    #endregion
    }
}