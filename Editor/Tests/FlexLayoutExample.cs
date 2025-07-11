using UnityEngine;
using UnityEngine.UIElements;
using UniFlexLayout;

/// <summary>
/// FlexLayout Example
/// 
/// Key API Description:
/// 1. AddItem() - Add child element and return child's FlexLayout for chaining child properties
/// 2. AddItem(VisualElement) - Add existing element and return its FlexLayout
/// 3. AddItem<T>() - Add child element of specified type and return its FlexLayout
/// 4. Define(Action<FlexLayout>) - Define container's child layout, callback parameter is container's FlexLayout
/// 
/// Usage Pattern:
/// container.Flex().Define(flex => {
///     // Add child elements here
///     flex.AddItem().Width(100).Height(50);  // Returns child's FlexLayout
///     flex.AddItem<Button>().Width(80);      // Returns button's FlexLayout
/// });
/// </summary>
[RequireComponent(typeof(UIDocument))]
public class FlexLayoutExample : MonoBehaviour
{
    private void Start()
    {
        // Get UIDocument
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        // Create main container
        var container = new VisualElement();
        container.Flex()
            .Direction(FlexDirection.Column)
            .JustifyContent(Justify.Center)
            .AlignItems(Align.Center)
            .Width(100.Percent())
            .Height(100.Percent())
            .BackgroundColor(Color.gray)
            .Padding(20);

        // Add header
        var header = new Label("FlexLayout Example");
        header.Flex()
            .Width(100.Percent())
            .Height(60)
            .BackgroundColor(Color.blue)
            .MarginBottom(20)
            .BorderRadius(10)
            .JustifyContent(Justify.Center)
            .AlignItems(Align.Center);

        // Add content area
        var content = new VisualElement();
        content.Flex()
            .Direction(FlexDirection.Row)
            .JustifyContent(Justify.SpaceBetween)
            .Width(100.Percent())
            .Grow(1)
            .BackgroundColor(Color.white)
            .Padding(15)
            .BorderRadius(8)
            .Define(flex =>
            {
                // Left sidebar
                flex.AddItem()
                    .Width(200)
                    .Height(100.Percent())
                    .BackgroundColor(Color.lightGray)
                    .MarginRight(20)
                    .BorderRadius(5);

                // Main content
                flex.AddItem()
                    .Grow(1)
                    .BackgroundColor(Color.cyan)
                    .BorderRadius(5)
                    .Padding(20);
            });

        // Add footer
        var footer = new VisualElement();
        footer.Flex()
            .Direction(FlexDirection.Row)
            .JustifyContent(Justify.Center)
            .Width(100.Percent())
            .Height(40)
            .BackgroundColor(Color.darkGray)
            .MarginTop(20)
            .BorderRadius(5)
            .Define(flex =>
            {
                // Add buttons
                for (int i = 0; i < 3; i++)
                {
                    var index = i;
                    flex.AddItem<Button>()
                        .Width(80)
                        .Height(30)
                        .MarginHorizontal(5)
                        .BorderRadius(3)
                        .BackgroundColor(Color.blue);
                }
            });

        // Build complete layout
        container.Add(header);
        container.Add(content);
        container.Add(footer);
        root.Add(container);

        // Responsive layout example
        CreateResponsiveLayout(root);
    }

    private void CreateResponsiveLayout(VisualElement root)
    {
        var responsive = new VisualElement();
        responsive.Flex()
            .Direction(FlexDirection.Column)
            .Width(100.Percent())
            .MarginTop(20)
            .Define(flex =>
            {
                // Create responsive grid using percentages
                var row1 = new VisualElement();
                row1.Flex()
                    .Direction(FlexDirection.Row)
                    .Width(100.Percent())
                    .Height(100)
                    .MarginBottom(10)
                    .Define(rowFlex =>
                    {
                        rowFlex.AddItem()
                            .Width(25.Percent())
                            .Height(100.Percent())
                            .BackgroundColor(Color.red)
                            .MarginRight(10);

                        rowFlex.AddItem()
                            .Width(50.Percent())
                            .Height(100.Percent())
                            .BackgroundColor(Color.green)
                            .MarginRight(10);

                        rowFlex.AddItem()
                            .Width(25.Percent())
                            .Height(100.Percent())
                            .BackgroundColor(Color.blue);
                    });

                flex.AddItem(row1);
            });

        root.Add(responsive);
    }
}