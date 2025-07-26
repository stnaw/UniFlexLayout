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
using UniFlexLayout;

var container = new VisualElement();
container.Flex()
    .Direction(FlexDirection.Column)
    .JustifyContent(Justify.Center)
    .Width(100.Percent())
    .Padding(20)
    .AddElement()
    .Width(200)
    .Height(100)
    .BackgroundColor(Color.blue);
```

### 

```csharp
using UniFlexLayout;

var container = rootVisualElement.AddElement().Define(flex=>
                {
                    flex.Direction(FlexDirection.Column);
                    flex.JustifyContent(Justify.Center);
                    flex.Width(100.Percent());
                    flex.Padding(20);
                    flex.AddElement().Width(200)
                                     .Height(100)
                                     .BackgroundColor(Color.blue);
                }).Eelement;
```

### 🛠 Installation

### Method 1: Via Package Manager

1. Open Unity Editor
2. Open **Package Manager** (Window → Package Manager)
3. Click the **+** button in the top-left corner
4. Select **Add package from git URL...**
5. Enter the following URL:
   ```
   https://github.com/stnaw/UniFlexLayout.git?path=Runtime
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