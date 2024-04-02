using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class PickerPage : ContentPage
{

    PaintClass paint = PaintClass.GetEmptyPaint();

    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    ScrollView primaryScrollForPage = new ScrollView();

    Button nextButton = CustomWidgets.CustomButton(text: "Начинаем >>", buttonState: ButtonState.Primary);
    Button previousButton = CustomWidgets.CustomButton(text: "<< Вернуться назад", buttonState: ButtonState.Secondary);

    Grid buttonsGrid = new Grid
    {
        ColumnSpacing = 20,
        Margin = new Thickness(0, 20),
    };

    public PickerPage()
	{
		InitializeComponent();

        previousButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        nextButton.Clicked += async (sender, args) => await Navigation.PushAsync(new LayerPages(paint, PaintLayers.PaintLayerEnum.LocationEnum));

        // Добавляем кнопки в 2 колонки
        buttonsGrid.Add(previousButton, 0, 0);
        buttonsGrid.Add(nextButton, 1, 0);

        // Добавляем картинку 
        pageStack.Add
            (
                new Image
                {
                    Source = $"Images/tikkurila_logo.png",
                    Aspect = Aspect.AspectFit,
                    HeightRequest = 100,
                    HorizontalOptions = LayoutOptions.Center,
                }

            );

        // Добавляем заголовок и описание экрана
        GenerateHeadlineAndDesc();

        pageStack.Add(buttonsGrid);

        // Добавляем наш pageStack в ScrollView на случай, если 
        // мобильное устройство будет маленькое и содержимое pageStack
        // Не будет влазить на весь экран
        primaryScrollForPage.Content = pageStack;

        // Устанавливаем заголовок страницы
        Title = "Подборщик красок";

        // В качестве контента ставим наш ScrollView
        Content = primaryScrollForPage;




    }

    private void GenerateHeadlineAndDesc()
    {
        // Заголовок и описание страницы

        Label pageHeadline = CustomWidgets.CustomText
            (
            text: "Подборщик красок",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center
            );

        Label pageDesc = CustomWidgets.CustomText
            (
            text: "В этом разделе вы сможете самостоятельно подобрать краску, просто отвечая по порядку на простые вопросы" +
            "\r\n\r\n Давайте приступим к делу и ответим на первый вопрос!",
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Center
            );

        pageStack.Add(pageHeadline);
        pageStack.Add(pageDesc);
    }
}