namespace rStarUtility.Util.Extensions.CSharp
{
    public static class BoolExtensions
    {
    #region Public Methods

        public static bool IsFalse(this bool value)
        {
            return value == false;
        }

        public static bool IsTrue(this bool value)
        {
            return value;
        }

    #endregion
    }
}