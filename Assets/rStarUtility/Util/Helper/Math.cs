#region

using System;
using UnityEngine;
using UnityEngine.Assertions;

#endregion

namespace rStarUtility.Util.Helper
{
    public class Math
    {
    #region Public Methods

        public static float Abs(float value)
        {
            return Mathf.Abs(value);
        }

        public static float Clamp_0_To_Max(float current , float max)
        {
            return Mathf.Clamp(current , 0 , max);
        }

        /// <summary>
        ///     max will be float.MaxValue
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public static float Clamp_0_To_Max(float current)
        {
            return Mathf.Clamp(current , 0 , float.MaxValue);
        }

        /// <summary>
        ///     max will be float.MaxValue
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public static int Clamp_0_To_Max(int current)
        {
            return Mathf.Clamp(current , 0 , int.MaxValue);
        }

        public static int Clamp_0_To_Max(int current , int max)
        {
            return Mathf.Clamp(current , 0 , max);
        }

        public static float GetRoundPercent(float current , float max , int digits = 3)
        {
            Assert.IsTrue(max >= 0 , $"Max {max} is less than zero.");
            var percent      = current / max;
            var roundPercent = GetRoundValue(percent , digits);
            return roundPercent;
        }

        public static float GetRoundValue(float value , int digits)
        {
            var roundPercent = MathF.Round(value , digits , MidpointRounding.AwayFromZero);
            return roundPercent;
        }

        public static int GetRoundValueInt(float value , int digits = 1)
        {
            var roundValue = MathF.Round(value , digits , MidpointRounding.AwayFromZero);
            return (int)roundValue;
        }

    #endregion
    }
}