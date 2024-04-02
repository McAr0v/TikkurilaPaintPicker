using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.PaintWidgets
{
    public static class PaintItemInList
    {
        public static Frame PaintItemWidgetInList(PaintClass paint, Func<Task> categoryAction, Func<Task> paintAction)
        {
            Grid imageAndTextGrid = new Grid
            {
                ColumnSpacing = 10,
                RowSpacing = 10,
            };

            StackLayout textStack = new StackLayout(){Spacing = 10};

            imageAndTextGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            imageAndTextGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            Image paintImage = new Image
            {
                Source = $"Images/PaintImages/{paint.GenerateImageName()}.png",
                Aspect = Aspect.AspectFill,
            };

            Label paintName = CustomWidgets.CustomText(
                text: paint.Name,
                textColor: CustomColors.Black,
                textState: TextState.HeadlineSmall,
                horizontalAligment: TextAlignment.Start
            );

            Label paintDesc = CustomWidgets.CustomText(
                text: paint.Description,
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start
            );

            paintDesc.LineBreakMode = LineBreakMode.WordWrap;
            paintDesc.MaxLines = 2;

            Label paintCategory = CustomWidgets.CustomText(
                text: CategoryClass.Translate(paint.Categories[0]),
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start,
                underline: TextDecorations.Underline
            );

            paintCategory.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    await categoryAction();

                })
            });

            Label textButton = CustomWidgets.CustomText(
                text: "Подробнее",
                textColor: CustomColors.TikkurilaRed,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start,
                underline: TextDecorations.Underline
            );

            textStack.Children.Add(paintName);
            textStack.Children.Add(paintDesc);
            textStack.Children.Add(paintCategory);
            textStack.Children.Add(textButton);

            imageAndTextGrid.Add(paintImage, 0, 0);
            imageAndTextGrid.Add(textStack, 1, 0);

            Frame paintWidgetFrame = new Frame
            {
                Content = imageAndTextGrid,
                HasShadow = true,
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10
            };

            paintWidgetFrame.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    await paintAction();
                })
            });

            return paintWidgetFrame;
        }

    }
}
