using UnityEngine;
using UnityEngine.UIElements;
using System;

namespace UniFlexLayout
{
    /// <summary>
    /// FlexLayout provides a chainable Flexbox layout API for Unity UI Toolkit
    /// Reference: https://github.com/layoutBox/FlexLayout
    /// </summary>
    public readonly struct FlexLayout<T> where T : VisualElement
    {
        private readonly T _element;

        public FlexLayout(T element)
        {
            _element = element ?? throw new ArgumentNullException(nameof(element));
        }

        #region 1. Layout

        /// <summary>
        /// Set the layout direction
        /// </summary>
        public FlexLayout<T> Direction(FlexDirection direction)
        {
            _element.style.flexDirection = direction;
            return this;
        }

        /// <summary>
        /// Set the wrap mode
        /// </summary>
        public FlexLayout<T> Wrap(Wrap wrap)
        {
            _element.style.flexWrap = wrap;
            return this;
        }

        /// <summary>
        /// Set the main axis alignment
        /// </summary>
        public FlexLayout<T> JustifyContent(Justify justify)
        {
            _element.style.justifyContent = justify;
            return this;
        }

        /// <summary>
        /// Set the cross axis alignment
        /// </summary>
        public FlexLayout<T> AlignItems(Align align)
        {
            _element.style.alignItems = align;
            return this;
        }

        /// <summary>
        /// Set the self alignment
        /// </summary>
        public FlexLayout<T> AlignSelf(Align align)
        {
            _element.style.alignSelf = align;
            return this;
        }

        /// <summary>
        /// Set the multiline alignment
        /// </summary>
        public FlexLayout<T> AlignContent(Align align)
        {
            _element.style.alignContent = align;
            return this;
        }

        #endregion

        #region 2. Size

        /// <summary>
        /// Set the width
        /// </summary>
        public FlexLayout<T> Width(float value)
        {
            _element.style.width = value;
            return this;
        }

        /// <summary>
        /// Set the width (percentage)
        /// </summary>
        public FlexLayout<T> Width(FPercent percent)
        {
            _element.style.width = percent;
            return this;
        }

        /// <summary>
        /// Set the width (StyleLength)
        /// </summary>
        public FlexLayout<T> Width(StyleLength length)
        {
            _element.style.width = length;
            return this;
        }

        /// <summary>
        /// Set the height
        /// </summary>
        public FlexLayout<T> Height(float value)
        {
            _element.style.height = value;
            return this;
        }

        /// <summary>
        /// Set the height (percentage)
        /// </summary>
        public FlexLayout<T> Height(FPercent percent)
        {
            _element.style.height = percent;
            return this;
        }

        /// <summary>
        /// Set the height (StyleLength)
        /// </summary>
        public FlexLayout<T> Height(StyleLength length)
        {
            _element.style.height = length;
            return this;
        }

        /// <summary>
        /// Set both width and height
        /// </summary>
        public FlexLayout<T> Size(float value)
        {
            _element.style.width = value;
            _element.style.height = value;
            return this;
        }

        /// <summary>
        /// Set both width and height
        /// </summary>
        public FlexLayout<T> Size(float width, float height)
        {
            _element.style.width = width;
            _element.style.height = height;
            return this;
        }

        /// <summary>
        /// Set the minimum width
        /// </summary>
        public FlexLayout<T> MinWidth(float value)
        {
            _element.style.minWidth = value;
            return this;
        }

        /// <summary>
        /// Set the minimum height
        /// </summary>
        public FlexLayout<T> MinHeight(float value)
        {
            _element.style.minHeight = value;
            return this;
        }

        /// <summary>
        /// Set the maximum width
        /// </summary>
        public FlexLayout<T> MaxWidth(float value)
        {
            _element.style.maxWidth = value;
            return this;
        }

        /// <summary>
        /// Set the maximum height
        /// </summary>
        public FlexLayout<T> MaxHeight(float value)
        {
            _element.style.maxHeight = value;
            return this;
        }

        #endregion

        #region 3. Flex Properties

        /// <summary>
        /// Set the flex grow
        /// </summary>
        public FlexLayout<T> Grow(float value)
        {
            _element.style.flexGrow = value;
            return this;
        }

        /// <summary>
        /// Set the flex shrink
        /// </summary>
        public FlexLayout<T> Shrink(float value)
        {
            _element.style.flexShrink = value;
            return this;
        }

        /// <summary>
        /// Set the flex basis
        /// </summary>
        public FlexLayout<T> Basis(float value)
        {
            _element.style.flexBasis = value;
            return this;
        }

        /// <summary>
        /// Set the flex basis (percentage)
        /// </summary>
        public FlexLayout<T> Basis(FPercent percent)
        {
            _element.style.flexBasis = percent;
            return this;
        }

        /// <summary>
        /// Set the flex basis to auto
        /// </summary>
        public FlexLayout<T> BasisAuto()
        {
            _element.style.flexBasis = StyleKeyword.Auto;
            return this;
        }

        #endregion

        #region 4. Position

        /// <summary>
        /// Set the position type
        /// </summary>
        public FlexLayout<T> Position(Position position)
        {
            _element.style.position = position;
            return this;
        }

        /// <summary>
        /// Set the left offset
        /// </summary>
        public FlexLayout<T> Left(float value)
        {
            _element.style.left = value;
            return this;
        }

        /// <summary>
        /// Set the top offset
        /// </summary>
        public FlexLayout<T> Top(float value)
        {
            _element.style.top = value;
            return this;
        }

        /// <summary>
        /// Set the right offset
        /// </summary>
        public FlexLayout<T> Right(float value)
        {
            _element.style.right = value;
            return this;
        }

        /// <summary>
        /// Set the bottom offset
        /// </summary>
        public FlexLayout<T> Bottom(float value)
        {
            _element.style.bottom = value;
            return this;
        }

        #endregion

        #region 5. Margin

        /// <summary>
        /// Set all margins
        /// </summary>
        public FlexLayout<T> Margin(float value)
        {
            _element.style.marginTop = value;
            _element.style.marginRight = value;
            _element.style.marginBottom = value;
            _element.style.marginLeft = value;
            return this;
        }

        /// <summary>
        /// Set vertical and horizontal margins
        /// </summary>
        public FlexLayout<T> Margin(float vertical, float horizontal)
        {
            _element.style.marginTop = vertical;
            _element.style.marginBottom = vertical;
            _element.style.marginLeft = horizontal;
            _element.style.marginRight = horizontal;
            return this;
        }

        /// <summary>
        /// Set all margins (top, right, bottom, left)
        /// </summary>
        public FlexLayout<T> Margin(float top, float right, float bottom, float left)
        {
            _element.style.marginTop = top;
            _element.style.marginRight = right;
            _element.style.marginBottom = bottom;
            _element.style.marginLeft = left;
            return this;
        }

        /// <summary>
        /// Set the top margin
        /// </summary>
        public FlexLayout<T> MarginTop(float value)
        {
            _element.style.marginTop = value;
            return this;
        }

        /// <summary>
        /// Set the top margin (percentage)
        /// </summary>
        public FlexLayout<T> MarginTop(FPercent percent)
        {
            _element.style.marginTop = percent;
            return this;
        }

        /// <summary>
        /// Set the right margin
        /// </summary>
        public FlexLayout<T> MarginRight(float value)
        {
            _element.style.marginRight = value;
            return this;
        }

        /// <summary>
        /// Set the right margin (percentage)
        /// </summary>
        public FlexLayout<T> MarginRight(FPercent percent)
        {
            _element.style.marginRight = percent;
            return this;
        }

        /// <summary>
        /// Set the bottom margin
        /// </summary>
        public FlexLayout<T> MarginBottom(float value)
        {
            _element.style.marginBottom = value;
            return this;
        }

        /// <summary>
        /// Set the bottom margin (percentage)
        /// </summary>
        public FlexLayout<T> MarginBottom(FPercent percent)
        {
            _element.style.marginBottom = percent;
            return this;
        }

        /// <summary>
        /// Set the left margin
        /// </summary>
        public FlexLayout<T> MarginLeft(float value)
        {
            _element.style.marginLeft = value;
            return this;
        }

        /// <summary>
        /// Set the left margin (percentage)
        /// </summary>
        public FlexLayout<T> MarginLeft(FPercent percent)
        {
            _element.style.marginLeft = percent;
            return this;
        }

        /// <summary>
        /// Set the horizontal margins
        /// </summary>
        public FlexLayout<T> MarginHorizontal(float value)
        {
            _element.style.marginLeft = value;
            _element.style.marginRight = value;
            return this;
        }

        /// <summary>
        /// Set the vertical margins
        /// </summary>
        public FlexLayout<T> MarginVertical(float value)
        {
            _element.style.marginTop = value;
            _element.style.marginBottom = value;
            return this;
        }

        #endregion

        #region 6. Padding

        /// <summary>
        /// Set all paddings
        /// </summary>
        public FlexLayout<T> Padding(float value)
        {
            _element.style.paddingTop = value;
            _element.style.paddingRight = value;
            _element.style.paddingBottom = value;
            _element.style.paddingLeft = value;
            return this;
        }

        /// <summary>
        /// Set vertical and horizontal paddings
        /// </summary>
        public FlexLayout<T> Padding(float vertical, float horizontal)
        {
            _element.style.paddingTop = vertical;
            _element.style.paddingBottom = vertical;
            _element.style.paddingLeft = horizontal;
            _element.style.paddingRight = horizontal;
            return this;
        }

        /// <summary>
        /// Set all paddings (top, right, bottom, left)
        /// </summary>
        public FlexLayout<T> Padding(float top, float right, float bottom, float left)
        {
            _element.style.paddingTop = top;
            _element.style.paddingRight = right;
            _element.style.paddingBottom = bottom;
            _element.style.paddingLeft = left;
            return this;
        }

        /// <summary>
        /// Set the top padding
        /// </summary>
        public FlexLayout<T> PaddingTop(float value)
        {
            _element.style.paddingTop = value;
            return this;
        }

        /// <summary>
        /// Set the right padding
        /// </summary>
        public FlexLayout<T> PaddingRight(float value)
        {
            _element.style.paddingRight = value;
            return this;
        }

        /// <summary>
        /// Set the bottom padding
        /// </summary>
        public FlexLayout<T> PaddingBottom(float value)
        {
            _element.style.paddingBottom = value;
            return this;
        }

        /// <summary>
        /// Set the left padding
        /// </summary>
        public FlexLayout<T> PaddingLeft(float value)
        {
            _element.style.paddingLeft = value;
            return this;
        }

        /// <summary>
        /// Set the horizontal paddings
        /// </summary>
        public FlexLayout<T> PaddingHorizontal(float value)
        {
            _element.style.paddingLeft = value;
            _element.style.paddingRight = value;
            return this;
        }

        /// <summary>
        /// Set the vertical paddings
        /// </summary>
        public FlexLayout<T> PaddingVertical(float value)
        {
            _element.style.paddingTop = value;
            _element.style.paddingBottom = value;
            return this;
        }

        #endregion

        #region 7. Visual Properties

        /// <summary>
        /// Set the background color
        /// </summary>
        public FlexLayout<T> BackgroundColor(Color color)
        {
            _element.style.backgroundColor = color;
            return this;
        }

        /// <summary>
        /// Set the background image
        /// </summary>
        public FlexLayout<T> BackgroundImage(Texture2D tex)
        {
            _element.style.backgroundImage = Background.FromTexture2D(tex);
            return this;
        }

        /// <summary>
        /// Set the background image
        /// </summary>
        public FlexLayout<T> BackgroundImage(RenderTexture rt)
        {
            _element.style.backgroundImage = Background.FromRenderTexture(rt);
            return this;
        }

        /// <summary>
        /// Set the background image
        /// </summary>
        public FlexLayout<T> BackgroundImage(VectorImage vi)
        {
            _element.style.backgroundImage = Background.FromVectorImage(vi);
            return this;
        }

        /// <summary>
        /// Set the background image
        /// </summary>
        public FlexLayout<T> BackgroundImage(Sprite sprite)
        {
            _element.style.backgroundImage = Background.FromSprite(sprite);
            return this;
        }

        /// <summary>
        /// Set the border
        /// </summary>
        public FlexLayout<T> Border(float width, Color color)
        {
            _element.style.borderTopWidth = width;
            _element.style.borderRightWidth = width;
            _element.style.borderBottomWidth = width;
            _element.style.borderLeftWidth = width;
            _element.style.borderTopColor = color;
            _element.style.borderRightColor = color;
            _element.style.borderBottomColor = color;
            _element.style.borderLeftColor = color;
            return this;
        }

        /// <summary>
        /// Set the border radius
        /// </summary>
        public FlexLayout<T> BorderRadius(float radius)
        {
            _element.style.borderTopLeftRadius = radius;
            _element.style.borderTopRightRadius = radius;
            _element.style.borderBottomLeftRadius = radius;
            _element.style.borderBottomRightRadius = radius;
            return this;
        }

        /// <summary>
        /// Set the opacity
        /// </summary>
        public FlexLayout<T> Opacity(float opacity)
        {
            _element.style.opacity = opacity;
            return this;
        }

        /// <summary>
        /// Set the visibility
        /// </summary>
        public FlexLayout<T> Visibility(Visibility visibility)
        {
            _element.style.visibility = visibility;
            return this;
        }

        /// <summary>
        /// Set the display type
        /// </summary>
        public FlexLayout<T> Display(DisplayStyle display)
        {
            _element.style.display = display;
            return this;
        }

        /// <summary>
        /// Set the overflow handling
        /// </summary>
        public FlexLayout<T> Overflow(Overflow overflow)
        {
            _element.style.overflow = overflow;
            return this;
        }

        #endregion

        #region 8. Child Management

        /// <summary>
        /// Add a child element 
        /// </summary>
        public FlexLayout<T> AddElement(T child)
        {
            _element.Add(child);
            return child.Flex();
        }

        /// <summary>
        /// Add a child element
        /// </summary>
        public FlexLayout<VisualElement> AddElement()
        {
            var child = new VisualElement();
            _element.Add(child);
            return child.Flex();
        }

        /// <summary>
        /// Add a child element of specified type (returns child's FlexLayout)
        /// </summary>
        public FlexLayout<T> AddElement<T>() where T : VisualElement, new()
        {
            var child = new T();
            _element.Add(child);
            return child.Flex();
        }

        /// <summary>
        /// Define elements layout
        /// </summary>
        public FlexLayout<T> Define(Action<FlexLayout<T>> configure)
        {
            configure(this);
            return this;
        }

        #endregion

        #region 9. Utility Methods

        /// <summary>
        /// Get the underlying Element
        /// </summary>
        public T Element => _element;

        /// <summary>
        /// Conditional execution
        /// </summary>
        public FlexLayout<T> If(bool condition, Action<FlexLayout<T>> configure)
        {
            if (condition)
            {
                configure(this);
            }
            return this;
        }

        /// <summary>
        /// Add a style class
        /// </summary>
        public FlexLayout<T> AddClass(string className)
        {
            _element.AddToClassList(className);
            return this;
        }

        /// <summary>
        /// Remove a style class
        /// </summary>
        public FlexLayout<T> RemoveClass(string className)
        {
            _element.RemoveFromClassList(className);
            return this;
        }

        /// <summary>
        /// Set the name
        /// </summary>
        public FlexLayout<T> Name(string name)
        {
            _element.name = name;
            return this;
        }

        #endregion
    }
}