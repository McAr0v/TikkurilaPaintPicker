using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class LocationLayer : ContentPage
{
    // Изначальная переменная, которую будем постепенно заполнять
    // и передавать между экранами
    
    PaintClass paint = PaintClass.GetEmptyPaint();

    // Стаки для самой страницы и для элементов виджета с вопросами

    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    ScrollView primaryScrollForPage = new ScrollView();
    

    // Кнопки

    Button nextButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "Следующий шаг", TextColor = CustomColors.White };
    Button previousButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "Вернуться назад", TextColor = CustomColors.Black };

    // Контейнер для размещения кнопок на одной плоскости

    Grid buttonsGrid = new Grid
    {
        ColumnSpacing = 20,
        Margin = new Thickness(0, 20),
    };

    // Frame, для красивого отображения вопросов на странице

    Frame answerWidget = new Frame
    {
        HasShadow = true,
        BackgroundColor = CustomColors.White,
        Padding = new Thickness(20),
        Margin = new Thickness(0, 10),
        CornerRadius = 10
    };

    // Список ответов

    List<PaintLocationEnum> enumsList = new List<PaintLocationEnum>() { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor };    

    public LocationLayer()
	{
		InitializeComponent();

        // ---- КНОПКИ -----

        // Назначаем действия на кнопки
        previousButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        nextButton.Clicked += async (sender, args) => await GoToNextScreen(paint);
        
        // Добавляем кнопки в 2 колонки
        buttonsGrid.Add(previousButton, 0, 0);
        buttonsGrid.Add(nextButton, 1, 0);

        // ----- РАДИО-КНОПКИ ----
        GenerateAnswersWidget();
        

        // ---- ГЕНЕРИРУМ САМ ЭКРАН ----

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

        // Добавляем виджет вопроса и ответа
        pageStack.Add (answerWidget);

        // Добавляем кнопки
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

    private void GenerateAnswersWidget() 
    {
        StackLayout answersStack = new StackLayout() { Spacing = 5 };

        Label answerHeadline = CustomTextWidget.CustomText
        (
            text: "Где вы планируете красить?",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center,
            padding: new Thickness(0, 0, 0, 20)
        );

        // Генерируем кнопки и заголовок в Frame
        answersStack.Add(answerHeadline);
        answersStack.Add(GenerateRadioButtons());
        answerWidget.Content = answersStack;

    }

    private void GenerateHeadlineAndDesc() 
    {
        // Заголовок и описание страницы

        Label pageHeadline = CustomTextWidget.CustomText
            (
            text: "Подборщик красок",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center
            );

        Label pageDesc = CustomTextWidget.CustomText
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

    private StackLayout GenerateRadioButtons() 
    {

        StackLayout layout = new StackLayout();

        foreach (PaintLocationEnum location in enumsList)
        {

            RadioButton radioButton = new RadioButton
            {
                TextColor = CustomColors.Black,
                Content = PaintLocation.GetPaintLocationString(location),
                IsChecked = false,
                BorderColor = CustomColors.Black,
                Margin = 0,
                Padding = 0
            };

            radioButton.CheckedChanged += (sender, e) =>
            {
                if (e.Value) // Если радиокнопка выбрана
                {
                    paint.Locations = new List<PaintLocationEnum> { location };
                }
            };

            layout.Children.Add(radioButton);
        }

        return layout;
    }

    private async Task GoToNextScreen(PaintClass paint) 
    {
        if (paint.Locations.Count > 0)
        {
            await Navigation.PushAsync(new ObjectsLayer(paint));
        }
        else 
        {
            await DisplayAlert("Переход невозможен!", "Вы не ответили на вопрос!", "Ок, сейчас отвечу");
        }
    }
}