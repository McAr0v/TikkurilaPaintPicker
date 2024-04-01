using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens.PaintLayers;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class LayerPages: ContentPage
{
    // Изначальная переменная, которую будем постепенно заполнять
    // и передавать между экранами
    
    PaintClass paint;

    // Стаки для самой страницы и для элементов виджета с вопросами

    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = new Thickness(20, 10) };
    ScrollView primaryScrollForPage = new ScrollView();
    

    // Кнопки

    Button nextButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "Следующий шаг >>", TextColor = CustomColors.White };
    Button previousButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "<< Вернуться назад", TextColor = CustomColors.Black };

    // Контейнер для размещения кнопок на одной плоскости

    Grid buttonsGrid = new Grid
    {
        ColumnSpacing = 20,
    };

    // Frame, для красивого отображения вопросов на странице

    Frame answerWidget = new Frame
    {
        HasShadow = true,
        BackgroundColor = CustomColors.White,
        Padding = new Thickness(20),
        CornerRadius = 10
    };

      

    public LayerPages(PaintClass paintFromPreviousScreen, PaintLayerEnum layer)
	{
        InitializeComponent();

        paint = paintFromPreviousScreen;

        // Очищаем нужный элемент в переменной краски
        // Чтобы при возвращении назад через 1 экран сбрасывалось
        // выбранное значение

        ClearPaint(layer);

        // ---- КНОПКИ -----

        // Назначаем действия на кнопки
        previousButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        nextButton.Clicked += async (sender, args) => await GoToNextScreen(paint, layer);
        
        // Добавляем кнопки в 2 колонки
        buttonsGrid.Add(previousButton, 0, 0);
        buttonsGrid.Add(nextButton, 1, 0);

        // ----- РАДИО-КНОПКИ ----
        GenerateAnswersWidget(layer);
        

        // ---- ГЕНЕРИРУМ САМ ЭКРАН ----

        // Добавляем виджет вопроса и ответа
        pageStack.Add (answerWidget);

        // Добавляем кнопки
        pageStack.Add(buttonsGrid);



        // Добавляем наш pageStack в ScrollView на случай, если 
        // мобильное устройство будет маленькое и содержимое pageStack
        // Не будет влазить на весь экран
        primaryScrollForPage.Content = pageStack;

        // Устанавливаем заголовок страницы
        Title = PaintLayer.GetPageHeadline(layer);

        // В качестве контента ставим наш ScrollView
        Content = primaryScrollForPage;

	}

    private void ClearPaint(PaintLayerEnum layer)
    {
        switch (layer)
        {
            case PaintLayerEnum.ObjectEnum: 
                {
                    paint.Objects.Clear(); break;
                }
            case PaintLayerEnum.LocationEnum:
                {
                    paint.Locations.Clear(); break;
                }
            case PaintLayerEnum.MaterialEnum:
                {
                    paint.Materials.Clear(); break;
                }
            case PaintLayerEnum.ColorsEnum:
                {
                    paint.Colors.Clear(); break;
                }
            case PaintLayerEnum.GlossEnum:
                {
                    paint.Gloss.Clear(); break;
                }
            case PaintLayerEnum.WaterbornEnum:
                {
                    paint.Thinner = PaintThinnerEnum.NotChosen; break;
                }
        }
    }

    private void GenerateAnswersWidget(PaintLayerEnum layer) 
    {
        StackLayout answersStack = new StackLayout() { Spacing = 5 };

        Label answerHeadline = CustomTextWidget.CustomText
        (
            text: PaintLayer.GetHeadline(layer),
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center,
            padding: new Thickness(0, 0, 0, 20)
        );

        // Генерируем кнопки и заголовок в Frame
        answersStack.Add(answerHeadline);
        answersStack.Add(GenerateRadioButtons(layer));
        answerWidget.Content = answersStack;

    }

    private StackLayout GenerateRadioButtons(PaintLayerEnum layer) 
    {
        // ---- СПИСКИ ОТВЕТОВ ---

        // Списки, которые нужно сгенерировать в зависимости от предыдущего ответа
        
        List<PaintObjectEnum> paintObjectList = new List<PaintObjectEnum>() { PaintObjectEnum.Windows, PaintObjectEnum.Constructions };
        List<PaintMaterialEnum> paintMaterialList = new List<PaintMaterialEnum> { PaintMaterialEnum.Metal, PaintMaterialEnum.Wood, PaintMaterialEnum.Plasterboard };


        // Списки, которые не надо генерировать

        List<PaintLocationEnum> enumsList = new List<PaintLocationEnum>() { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor };
        List<PaintGlossEnum> paintGlossList = new List<PaintGlossEnum> { PaintGlossEnum.Matt, PaintGlossEnum.Gloss };
        List<PaintThinnerEnum> paintThinnerList = new List<PaintThinnerEnum> { PaintThinnerEnum.Water, PaintThinnerEnum.Solvent1050 };
        List<PaintColorEnum> paintColorsList = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White };

        if (layer == PaintLayerEnum.MaterialEnum) 
        {
            paintMaterialList = PaintMaterial.GetMaterialList(paint.Locations[0]);

        } else if (layer == PaintLayerEnum.ObjectEnum)
        {
            paintObjectList = PaintObject.GetPaintObjectList(paintMaterial: paint.Materials[0], paintLocation: paint.Locations[0]);
        }

        if (paint.Materials.Count > 0 && (paint.Materials[0] == PaintMaterialEnum.Wood || paint.Materials[0] == PaintMaterialEnum.Osb))
        {
            paintColorsList.Add(PaintColorEnum.NoColor);
        }

        StackLayout layout = new StackLayout();

        if (layer == PaintLayerEnum.LocationEnum) 
        {
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
        }
        else if (layer == PaintLayerEnum.ObjectEnum)
        {
            foreach (PaintObjectEnum paintObject in paintObjectList)
            {

                RadioButton radioButton = new RadioButton
                {
                    TextColor = CustomColors.Black,
                    Content = PaintObject.GetPaintObjectName(paintObject),
                    IsChecked = false,
                    BorderColor = CustomColors.Black,
                    Margin = 0,
                    Padding = 0
                };

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) // Если радиокнопка выбрана
                    {
                        paint.Objects = new List<PaintObjectEnum> { paintObject };
                    }
                };

                layout.Children.Add(radioButton);
            }
        }

        else if (layer == PaintLayerEnum.MaterialEnum)
        {
            foreach (PaintMaterialEnum paintMaterial in paintMaterialList)
            {

                RadioButton radioButton = new RadioButton
                {
                    TextColor = CustomColors.Black,
                    Content = PaintMaterial.GetPaintMaterialName(paintMaterial),
                    IsChecked = false,
                    BorderColor = CustomColors.Black,
                    Margin = 0,
                    Padding = 0
                };

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) // Если радиокнопка выбрана
                    {
                        paint.Materials = new List<PaintMaterialEnum> { paintMaterial };
                    }
                };

                layout.Children.Add(radioButton);
            }
        }

        else if (layer == PaintLayerEnum.ColorsEnum)
        {
            foreach (PaintColorEnum paintColor in paintColorsList)
            {

                RadioButton radioButton = new RadioButton
                {
                    TextColor = CustomColors.Black,
                    Content = PaintColor.GetPaintColorAnswer(paintColor),
                    IsChecked = false,
                    BorderColor = CustomColors.Black,
                    Margin = 0,
                    Padding = 0
                };

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) // Если радиокнопка выбрана
                    {
                        paint.Colors = new List<PaintColorEnum> { paintColor };
                    }
                };

                layout.Children.Add(radioButton);
            }
        }

        else if (layer == PaintLayerEnum.GlossEnum)
        {
            foreach (PaintGlossEnum paintGloss in paintGlossList)
            {

                RadioButton radioButton = new RadioButton
                {
                    TextColor = CustomColors.Black,
                    Content = PaintGloss.GetGlossName(paintGloss),
                    IsChecked = false,
                    BorderColor = CustomColors.Black,
                    Margin = 0,
                    Padding = 0
                };

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) // Если радиокнопка выбрана
                    {
                        paint.Gloss = new List<PaintGlossEnum> { paintGloss };
                    }
                };

                layout.Children.Add(radioButton);
            }
        }

        else if (layer == PaintLayerEnum.WaterbornEnum)
        {
            foreach (PaintThinnerEnum thinner in paintThinnerList)
            {

                RadioButton radioButton = new RadioButton
                {
                    TextColor = CustomColors.Black,
                    Content = thinner == PaintThinnerEnum.Solvent1050 ? "Можно на растворителях" : "Да, краска должна быть без запаха",
                    IsChecked = false,
                    BorderColor = CustomColors.Black,
                    Margin = 0,
                    Padding = 0
                };

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) // Если радиокнопка выбрана
                    {
                        paint.Thinner = thinner;
                    }
                };

                layout.Children.Add(radioButton);
            }
        }


        return layout;
    }

    private async Task GoToNextScreen(PaintClass paint, PaintLayerEnum layer) 
    {

        if (PaintLayer.CheckAnswer(layer: layer, paint: paint))
        {
            if (layer != PaintLayerEnum.WaterbornEnum) 
            {
                await Navigation.PushAsync(new LayerPages(paint, PaintLayer.GetNextPage(layer)));
            }
            else
            {
                //PickerResultPage

                await Navigation.PushAsync(new PickerResultPage(paint));
            }

        }
        else
        {
            await DisplayAlert("Переход невозможен!", "Вы не ответили на вопрос!", "Ок, сейчас отвечу");
        }
    }
}