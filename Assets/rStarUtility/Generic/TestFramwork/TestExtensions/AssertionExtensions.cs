#region

using FluentAssertions;
using FluentAssertions.Numeric;
using FluentAssertions.Primitives;
using rStarUtility.Util.Extensions.CSharp;

#endregion

namespace rStarUtility.Generic.TestExtensions
{
    public static class AssertionExtensions
    {
    #region Public Methods

        public static AndConstraint<BooleanAssertions> ShouldBe(
                this bool actualValue , bool expected , string because = "" , params object[] becauseArgs)
        {
            return actualValue.Should().Be(expected , because , becauseArgs);
        }

        public static AndConstraint<ObjectAssertions> ShouldBe(
                this object actualValue , object expected , string because = "" , params object[] becauseArgs)
        {
            return actualValue.Should().Be(expected , because , becauseArgs);
        }

        public static AndConstraint<NumericAssertions<float>> ShouldBe(
                this float actualValue , float expected , float precision , string because = "" , params object[] becauseArgs)
        {
            return actualValue.Should().BeApproximately(expected , precision , because , becauseArgs);
        }

        public static AndConstraint<NumericAssertions<float>> ShouldBe(
                this float actualValue , float expected , string because = "" , params object[] becauseArgs)
        {
            return actualValue.ShouldBe(expected , 0.01f , because , becauseArgs);
        }

        public static AndConstraint<ObjectAssertions> ShouldBeEquivalentTo(
                this object actualValue , object expected , string because = "" , params object[] becauseArgs)
        {
            return actualValue.Should().BeEquivalentTo(expected , because , becauseArgs);
        }

        public static AndConstraint<BooleanAssertions> ShouldBeNull(
                this object actualValue , string because = "" , params object[] becauseArgs)
        {
            return actualValue.IsNull().ShouldTrue(because , becauseArgs);
            // return actualValue.Should().BeNull(because , becauseArgs);
        }

        public static AndConstraint<BooleanAssertions> ShouldFalse(
                this bool actualValue , string because = "" , params object[] becauseArgs)
        {
            return actualValue.ShouldBe(false , because , becauseArgs);
        }

        public static AndConstraint<ObjectAssertions> ShouldNotBe(
                this object actualValue , object expected , string because = "" , params object[] becauseArgs)
        {
            return actualValue.Should().NotBe(expected , because , becauseArgs);
        }

        public static AndConstraint<BooleanAssertions> ShouldNotBeNull(
                this object actualValue , string because = "" , params object[] becauseArgs)
        {
            return actualValue.IsNotNull().ShouldTrue(because , becauseArgs);
            // return actualValue.Should().NotBeNull(because , becauseArgs);
        }

        public static AndConstraint<BooleanAssertions> ShouldTrue(
                this bool actualValue , string because = "" , params object[] becauseArgs)
        {
            return actualValue.ShouldBe(true , because , becauseArgs);
        }

    #endregion
    }
}