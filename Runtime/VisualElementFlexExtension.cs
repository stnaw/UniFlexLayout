using UnityEngine.UIElements;

namespace UniFlexLayout
{
    /// <summary>
    /// VisualElement extension methods
    /// </summary>
    public static class VisualElementFlexExtensions
    {
        public static FlexLayout<T> Flex<T>(this T element) where T : VisualElement
        {
            return new FlexLayout<T>(element);
        }
    }
}