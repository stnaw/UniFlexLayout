using UnityEngine.UIElements;

namespace UniFlexLayout
{
    /// <summary>
    /// VisualElement extension methods
    /// </summary>
    public static class VisualElementFlexExtensions
    {
        /// <summary>
        /// Get FlexLayout instance
        /// </summary>
        public static FlexLayout Flex(this VisualElement element)
        {
            return new FlexLayout(element);
        }
    }
}