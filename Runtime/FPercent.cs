using UnityEngine.UIElements;

namespace UniFlexLayout
{
    /// <summary>
    /// Percentage value structure
    /// </summary>
    public readonly struct FPercent
    {
        public readonly float Value;

        public FPercent(float value)
        {
            Value = value;
        }

        public static implicit operator StyleLength(FPercent percent)
        {
            return new StyleLength(new Length(percent.Value, LengthUnit.Percent));
        }

        public override string ToString()
        {
            return $"{Value}%";
        }
    }

    /// <summary>
    /// Percentage extension methods
    /// </summary>
    public static class PercentExtensions
    {
        /// <summary>
        /// Convert float to percentage
        /// </summary>
        public static FPercent Percent(this float value)
        {
            return new FPercent(value);
        }

        /// <summary>
        /// Convert int to percentage
        /// </summary>
        public static FPercent Percent(this int value)
        {
            return new FPercent(value);
        }

        /// <summary>
        /// Shorthand percentage syntax, supports 25.P()
        /// </summary>
        public static FPercent P(this float value)
        {
            return new FPercent(value);
        }

        /// <summary>
        /// Shorthand percentage syntax, supports 25.P()
        /// </summary>
        public static FPercent P(this int value)
        {
            return new FPercent(value);
        }
    }
}