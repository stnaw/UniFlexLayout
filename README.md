# UniFlexLayout

---

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-blue)](https://unity.com/)[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

**UniFlexLayout** provides a nice C# interface to Unity UI Toolkit's flexbox implementation. Concise, intuitive & chainable syntax for Unity developers.

## ✨ Features

- 🔗 **Chainable Syntax**: Fluent API similar to CSS-in-JS libraries
- 📱 **Flexbox Support**: Complete flexbox layout system for Unity UI Toolkit
- 🔄 **Percentage Support**: Easy percentage values with `.Percent()` and `.P()` extensions
- 🎨 **Visual Properties**: Built-in support for colors, borders, and styling

### Before (Manual Unity UI)
```csharp
var container = new VisualElement();
container.style.flexDirection = FlexDirection.Column;
container.style.justifyContent = Justify.Center;
container.style.width = Length.Percent(100);
container.style.padding = 20;

var child = new VisualElement();
child.style.width = 200;
child.style.height = 100;
child.style.backgroundColor = Color.blue;
container.Add(child);
```

### After (UniFlexLayout)
```csharp
var container = new VisualElement();
container.Flex()
    .Direction(FlexDirection.Column)
    .JustifyContent(Justify.Center)
    .Width(100.Percent())
    .Padding(20)
    .AddItem()
    .Width(200)
    .Height(100)
    .BackgroundColor(Color.blue);
```

## 🚀 Quick Start

### Basic Usage

```csharp
using UniFlexLayout;

// Create a container with flexbox layout
var container = new VisualElement();
container.Flex()
    .Direction(FlexDirection.Column)
    .JustifyContent(Justify.Center)
    .AlignItems(Align.Center)
    .Width(100.Percent())
    .Height(100.Percent())
    .Padding(20)
    .BackgroundColor(Color.gray);
```

### Adding Child Elements

```csharp
// Method 1: Direct child configuration
container.Flex().Define(flex => {
    // Add child elements
    flex.AddItem()
        .Width(200)
        .Height(100)
        .BackgroundColor(Color.blue)
        .MarginBottom(10);
    
    flex.AddItem<Button>()
        .Width(150)
        .Height(40)
        .BorderRadius(5);
});

// Method 2: Individual element creation
var header = container.Flex()
    .AddItem()
    .Width(100.Percent())
    .Height(60)
    .BackgroundColor(Color.darkBlue);
```

### Responsive Layout Example

```csharp
// Create a responsive layout with percentage-based columns
var row = new VisualElement();
row.Flex()
    .Direction(FlexDirection.Row)
    .Width(100.Percent())
    .Define(flex => {
        // 25% width sidebar
        flex.AddItem()
            .Width(25.Percent())
            .BackgroundColor(Color.lightGray)
            .Padding(10);
        
        // 50% width main content  
        flex.AddItem()
            .Width(50.Percent())
            .BackgroundColor(Color.white)
            .Padding(20)
            .Grow(1);
        
        // 25% width right panel
        flex.AddItem()
            .Width(25.Percent())
            .BackgroundColor(Color.lightGray)
            .Padding(10);
    });
```

## 📚 API Reference

### Layout Properties

| Method | Description | Example |
|--------|-------------|---------|
| `Direction()` | Set flex direction | `.Direction(FlexDirection.Row)` |
| `JustifyContent()` | Main axis alignment | `.JustifyContent(Justify.Center)` |
| `AlignItems()` | Cross axis alignment | `.AlignItems(Align.Stretch)` |
| `Wrap()` | Flex wrap behavior | `.Wrap(Wrap.Wrap)` |

### Size Properties

| Method | Description | Example |
|--------|-------------|---------|
| `Width()` | Set width | `.Width(200)` or `.Width(50.Percent())` |
| `Height()` | Set height | `.Height(100)` or `.Height(25.P())` |
| `Size()` | Set both dimensions | `.Size(200, 100)` |
| `MinWidth()`/`MaxWidth()` | Min/max constraints | `.MaxWidth(300)` |

### Flex Properties

| Method | Description | Example |
|--------|-------------|---------|
| `Grow()` | Flex grow factor | `.Grow(1)` |
| `Shrink()` | Flex shrink factor | `.Shrink(0)` |
| `Basis()` | Flex basis | `.Basis(200)` or `.Basis(50.Percent())` |

### Spacing

| Method | Description | Example |
|--------|-------------|---------|
| `Margin()` | Set margins | `.Margin(10)` or `.Margin(10, 20)` |
| `Padding()` | Set padding | `.Padding(15)` or `.Padding(10, 20, 10, 20)` |
| `MarginTop()`/`PaddingLeft()` | Individual spacing | `.MarginTop(5).PaddingLeft(10)` |

### Visual Styling

| Method | Description | Example |
|--------|-------------|---------|
| `BackgroundColor()` | Background color | `.BackgroundColor(Color.red)` |
| `Border()` | Border styling | `.Border(2, Color.black)` |
| `BorderRadius()` | Rounded corners | `.BorderRadius(10)` |
| `Opacity()` | Transparency | `.Opacity(0.8f)` |

### Child Management

| Method | Description | Example |
|--------|-------------|---------|
| `AddItem()` | Add child element | `.AddItem().Width(100)` |
| `AddItem<T>()` | Add typed element | `.AddItem<Button>().Width(80)` |
| `Define()` | Structure layout code | `.Define(flex => { ... })` |

## 💡 Core Concepts

### Chainable API Design

UniFlexLayout uses a fluent interface that allows you to chain method calls:

```csharp
element.Flex()
    .Direction(FlexDirection.Row)
    .JustifyContent(Justify.SpaceBetween)
    .Width(100.Percent())
    .Padding(20)
    .BackgroundColor(Color.white);
```

### AddItem Returns Child

The `AddItem()` method returns the **child's** FlexLayout instance, allowing immediate configuration:

```csharp
container.Flex().Define(flex => {
    // This returns the child's FlexLayout for immediate styling
    flex.AddItem()
        .Width(100)
        .Height(50)
        .BackgroundColor(Color.blue);
    
    // Chain multiple children
    flex.AddItem<Label>()
        .Width(200)
        .Height(30)
        .MarginTop(10);
});
```

### Percentage Support

Multiple ways to specify percentage values:

```csharp
// Method 1: .Percent() extension
.Width(50.Percent())

// Method 2: .P() shorthand
.Width(25.P())

// Both create FPercent structs that convert to Unity's StyleLength
```

## 🎯 Comparison with CSS Flexbox

UniFlexLayout provides a familiar API for web developers:

| CSS | UniFlexLayout |
|-----|---------------|
| `display: flex` | *(automatic with VisualElement)* |
| `flex-direction: row` | `.Direction(FlexDirection.Row)` |
| `justify-content: center` | `.JustifyContent(Justify.Center)` |
| `align-items: stretch` | `.AlignItems(Align.Stretch)` |
| `width: 50%` | `.Width(50.Percent())` |
| `margin: 10px 20px` | `.Margin(10, 20)` |

## 🛠 Installation

### Method 1: Via Package Manager

1. Open Unity Editor
2. Open **Package Manager** (Window → Package Manager)
3. Click the **+** button in the top-left corner
4. Select **Add package from git URL...**
5. Enter the following URL:
   ```
   https://github.com/stnaw/UniFlexLayout.git?path=Runtime/
   ```
6. Click **Add** and wait for installation to complete

### Method 2: Manual Installation

1. **Copy the UniFlexLayout folder** to your Unity project's `Assets` directory

### Usage

After installation (either method), add the using statement in your scripts:
```csharp
using UniFlexLayout;
```

Then you can **start using** the `.Flex()` extension on any `VisualElement`.

### Requirements

- Unity 2022.3 or later
- UI Toolkit package (usually included by default)

## 🔍 Advanced Examples

### Complex Layout Structure

```csharp
public class ComplexLayoutExample : MonoBehaviour
{
    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        
        // Main app layout
        root.Flex()
            .Direction(FlexDirection.Column)
            .Width(100.Percent())
            .Height(100.Percent())
            .Define(flex => {
                // Header
                flex.AddItem()
                    .Width(100.Percent())
                    .Height(60)
                    .BackgroundColor(Color.blue);
                
                // Content area with sidebar
                flex.AddItem()
                    .Direction(FlexDirection.Row)
                    .Grow(1)
                    .Define(contentFlex => {
                        // Sidebar
                        contentFlex.AddItem()
                            .Width(250)
                            .BackgroundColor(Color.lightGray)
                            .Padding(15);
                        
                        // Main content
                        contentFlex.AddItem()
                            .Grow(1)
                            .BackgroundColor(Color.white)
                            .Padding(20);
                    });
                
                // Footer
                flex.AddItem()
                    .Width(100.Percent())
                    .Height(40)
                    .BackgroundColor(Color.darkGray);
            });
    }
}
```

### Conditional Styling

```csharp
bool isCompact = Screen.width < 768;

container.Flex()
    .Direction(isCompact ? FlexDirection.Column : FlexDirection.Row)
    .If(isCompact, flex => flex.Padding(10))
    .If(!isCompact, flex => flex.Padding(20));
```

## 🙏 Acknowledgments

UniFlexLayout is heavily inspired by the excellent [**FlexLayout**](https://github.com/layoutBox/FlexLayout) library for iOS by layoutBox. FlexLayout's elegant API design and comprehensive feature set served as the blueprint for this Unity adaptation.

**Key inspirations from FlexLayout:**
- Chainable/fluent API design
- `addItem()` returning child instances for immediate configuration  
- `define()` method for structuring layout code
- Comprehensive flexbox property coverage
- Percentage value handling

Special thanks to the FlexLayout team for creating such a well-designed and documented library that made this Unity port possible! 🎉

## 📄 License

This library is under the MIT License.

---

**Made with ❤️ for the Unity community**