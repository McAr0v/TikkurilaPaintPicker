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
            Grid grid = new Grid
            {
                ColumnSpacing = 10,
                RowSpacing = 10,
            };

            StackLayout stack = new StackLayout()
            {
                Spacing = 10
            };

            // Первая колонка, занимающая 1/3 ширины экрана
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // Вторая колонка, занимающая оставшуюся часть ширины
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            Image image = new Image
            {
                Source = $"Images/PaintImages/{paint.GenerateImageName()}.png",
                Aspect = Aspect.AspectFill,
            };

            Label label = CustomWidgets.CustomText(
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

            Label paintCategory = CustomWidgets.CustomText(
                text: CategoryTranslator.Translate(paint.Categories[0]),
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

            paintDesc.LineBreakMode = LineBreakMode.WordWrap;
            paintDesc.MaxLines = 2;

            label.BindingContext = paint;



            stack.Children.Add(label);
            stack.Children.Add(paintDesc);
            stack.Children.Add(paintCategory);
            stack.Children.Add(textButton);

            grid.Add(image, 0, 0);
            grid.Add(stack, 1, 0);

            Frame frame = new Frame
            {
                Content = grid,
                HasShadow = true,
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10
            };

            frame.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    await paintAction();
                })
            });

            return frame;
        }

    }
}
