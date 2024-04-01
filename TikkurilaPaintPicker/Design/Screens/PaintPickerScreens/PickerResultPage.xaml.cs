using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.PaintLists;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class PickerResultPage : ContentPage
{
    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    StackLayout paintsStack = new StackLayout() { Spacing = 20};
    ScrollView primaryScrollForPage = new ScrollView();

    Button catalogButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "Перейти в каталог красок >>", TextColor = CustomColors.Black, };
    Button backButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "<< Вернуться назад и изменить ответы", TextColor = CustomColors.Black };
    Button mainPageButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "<< Вернуться на главный экран", TextColor = CustomColors.White, Margin = new Thickness(0, 20, 0, 0) };

    List<PaintClass> paintsResultList = new List<PaintClass>();

    PaintRepository paintRepository = new PaintRepository();

    

    public PickerResultPage(PaintClass paint)
	{
		InitializeComponent();

        backButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        mainPageButton.Clicked += async (sender, args) => await NavigateToMainPage();
        catalogButton.Clicked += async (sender, args) => await Navigation.PushAsync(new CatalogScreen());

        paintsResultList = paintRepository.GetPaintsListFromPickerResult(paint);

        pageStack.Add(paint.GetAllAnswers());

        if (paintsResultList.Count > 0) 
        {
            pageStack.Add
                (
                    CustomTextWidget.CustomText
                    (
                        text: $"Мы подобрали для вас {GetCountPaintString(paintsResultList.Count)}:",
                        textColor: CustomColors.Black,
                        textState: TextState.HeadlineMedium
                    )
                ); ;

            AddPaintsWidgets();
        }
        else
        {
            WidgetForEmptyList();
        }

        pageStack.Add(paintsStack);

        pageStack.Add(backButton);
        pageStack.Add(mainPageButton);
        pageStack.Add(catalogButton);

        primaryScrollForPage.Content = pageStack;

        Content = primaryScrollForPage;

        Title = "Результат подбора";

    }

    private string GetCountPaintString(int count) 
    {
        // Для чисел, оканчивающихся на 11, 12, 13 и 14, всегда используем форму "красок"
        if (count % 100 >= 11 && count % 100 <= 14)
        {
            return $"{count} красок";
        }

        // Для остальных чисел используем правила склонения
        switch (count % 10)
        {
            case 1:
                return $"{count} краску";
            case 2:
            case 3:
            case 4:
                return $"{count} краски";
            default:
                return $"{count} красок";
        }
    }

    private async Task NavigateToMainPage()
    {
        await Navigation.PopToRootAsync();
    }

    private void AddPaintsWidgets()
    {
        foreach (PaintClass paint in paintsResultList)
        {
            Grid grid = new Grid
            {
                //Padding = new Thickness(10),
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
                Source = $"Images/PaintImages/{paint.Name}.png",
                Aspect = Aspect.AspectFill,
            };

            Label label = CustomTextWidget.CustomText(
                text: paint.Name,
                textColor: CustomColors.Black,
                textState: TextState.HeadlineSmall,
                horizontalAligment: TextAlignment.Start
            );

            Label paintDesc = CustomTextWidget.CustomText(
                text: paint.Description,
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start
            );

            Label textButton = CustomTextWidget.CustomText(
                text: "Подробнее",
                textColor: CustomColors.TikkurilaRed,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start,
                underline: TextDecorations.Underline
            );

            paintDesc.LineBreakMode = LineBreakMode.WordWrap;
            paintDesc.MaxLines = 3;

            label.BindingContext = paint;



            stack.Children.Add(label);
            stack.Children.Add(paintDesc);
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
                    // Получаем объект Paint из BindingContext метки
                    PaintClass selectedPaint = label.BindingContext as PaintClass;
                    if (selectedPaint != null)
                    {
                        await NavigateToPaintPage(selectedPaint);
                    }
                })
            });


            paintsStack.Children.Add(frame); // Добавляем Grid в StackLayout
        }
    }

    private void WidgetForEmptyList() 
    {
        Label label = CustomTextWidget.CustomText(
                text: "Красок с такими свойствами не найдено :(",
                textColor: CustomColors.TikkurilaRed,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Center
            );

        Label desc = CustomTextWidget.CustomText(
            text: "Увы, но ни одна краска не удовлетворяет условиям ваших ответов. " +
            "\r\n\r\nПопробуйте вернуться назад и изменить некоторые ответы",
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Center
        );

        paintsStack.Add(label);
        paintsStack.Add(desc);
    }

    private async Task NavigateToPaintPage(PaintClass paint)
    {
        await Navigation.PushAsync(new PaintViewScreen(paint: paint));

        //var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
        //Navigation.RemovePage(previousPage);
    }


}