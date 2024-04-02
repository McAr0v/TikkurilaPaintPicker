using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.PaintWidgets;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens.PaintLayers;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class LayerPages: ContentPage
{
    // Изначальная переменная краски, которую будем постепенно заполнять
    // и рекурсивно передавать между экранами
    
    PaintClass paint;

    // Стак для всего контента страницы
    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = new Thickness(20, 10) };

    // Прокручиваемая разметка, на случай, если содержимое не будет влазить в размеры экрана
    ScrollView primaryScrollForPage = new ScrollView();
    

    // Кнопки
    Button nextButton = CustomWidgets.CustomButton
        (
            text: "Следующий шаг >>", 
            buttonState: ButtonState.Primary
        );
    Button previousButton = CustomWidgets.CustomButton
        (
            text: "<< Вернуться назад", 
            buttonState: ButtonState.Secondary
        );

    // Контейнер для размещения кнопок в 2 колонки

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

        // В качестве контента страницы ставим наш ScrollView
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

        Label answerHeadline = CustomWidgets.CustomText
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

        List<PaintLocationEnum> paintLocationList = new List<PaintLocationEnum>() { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor };
        List<PaintGlossEnum> paintGlossList = new List<PaintGlossEnum> { PaintGlossEnum.Matt, PaintGlossEnum.Gloss };
        List<PaintThinnerEnum> paintThinnerList = new List<PaintThinnerEnum> { PaintThinnerEnum.Water, PaintThinnerEnum.Solvent1050 };
        List<PaintColorEnum> paintColorsList = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White };

        // ---- ГЕНЕРИРУЕМ СПИСКИ ОТВЕТОВ ----

        if (layer == PaintLayerEnum.MaterialEnum) 
        {
            paintMaterialList = PaintMaterial.GetMaterialList(paint.Locations[0]);

        } else if (layer == PaintLayerEnum.ObjectEnum)
        {
            paintObjectList = PaintObject.GetPaintObjectList(paintMaterial: paint.Materials[0], paintLocation: paint.Locations[0]);
        }

        // Если выбрали в качестве материала окраски дерево, то нужно добавить в цвета
        // полупрозрачный цвет лаков и пропиток

        if (paint.Materials.Count > 0 && (paint.Materials[0] == PaintMaterialEnum.Wood || paint.Materials[0] == PaintMaterialEnum.Osb))
        {
            paintColorsList.Add(PaintColorEnum.NoColor);
        }

        StackLayout radioButtonsLayout = new StackLayout();

        // ---- ГЕНЕРИРУЕМ ОТВЕТЫ -----

        // В зависимости от вопроса (PaintLayer) генерируем ответы,
        // программируем действие на нажатие элемента,
        // и добавляем в стак ответов

        // "Круг" вопроса о локации окраски 
        if (layer == PaintLayerEnum.LocationEnum) 
        {
            foreach (PaintLocationEnum location in paintLocationList)
            {

                RadioButton radioButton = CustomWidgets.CustomRadioButton(text: PaintLocation.GetPaintLocationString(location));

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) 
                    {
                        paint.Locations = new List<PaintLocationEnum> { location };
                    }
                };

                radioButtonsLayout.Children.Add(radioButton);
            }
        }
        // "Круг" вопроса об объекте окраски 
        else if (layer == PaintLayerEnum.ObjectEnum)
        {
            foreach (PaintObjectEnum paintObject in paintObjectList)
            {
                RadioButton radioButton = CustomWidgets.CustomRadioButton(text: PaintObject.GetPaintObjectName(paintObject));

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) 
                    {
                        paint.Objects = new List<PaintObjectEnum> { paintObject };
                    }
                };

                radioButtonsLayout.Children.Add(radioButton);
            }
        }
        // "Круг" вопроса об окрашиваемом материале 
        else if (layer == PaintLayerEnum.MaterialEnum)
        {
            foreach (PaintMaterialEnum paintMaterial in paintMaterialList)
            {
                RadioButton radioButton = CustomWidgets.CustomRadioButton(text: PaintMaterial.GetPaintMaterialName(paintMaterial));

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) 
                    {
                        paint.Materials = new List<PaintMaterialEnum> { paintMaterial };
                    }
                };

                radioButtonsLayout.Children.Add(radioButton);
            }
        }
        // "Круг" вопроса о желаемом цвете краски 
        else if (layer == PaintLayerEnum.ColorsEnum)
        {
            foreach (PaintColorEnum paintColor in paintColorsList)
            {
                RadioButton radioButton = CustomWidgets.CustomRadioButton(text: PaintColor.GetPaintColorAnswer(paintColor));

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) 
                    {
                        paint.Colors = new List<PaintColorEnum> { paintColor };
                    }
                };

                radioButtonsLayout.Children.Add(radioButton);
            }
        }
        // "Круг" вопроса о желаемом блеске материала
        else if (layer == PaintLayerEnum.GlossEnum)
        {
            foreach (PaintGlossEnum paintGloss in paintGlossList)
            {
                RadioButton radioButton = CustomWidgets.CustomRadioButton(text: PaintGloss.GetGlossName(paintGloss));

                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value) 
                    {
                        paint.Gloss = new List<PaintGlossEnum> { paintGloss };
                    }
                };

                radioButtonsLayout.Children.Add(radioButton);
            }
        }
        // "Круг" вопроса о предпочтении заказчика о краске на водной основе 
        else if (layer == PaintLayerEnum.WaterbornEnum)
        {
            foreach (PaintThinnerEnum thinner in paintThinnerList)
            {
                RadioButton radioButton = CustomWidgets.CustomRadioButton
                    (
                        text: thinner == PaintThinnerEnum.Solvent1050 ? 
                        "Можно на растворителях" 
                        : "Да, краска должна быть без запаха"
                    );
                
                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (e.Value)
                    {
                        paint.Thinner = thinner;
                    }
                };

                radioButtonsLayout.Children.Add(radioButton);
            }
        }

        return radioButtonsLayout;
    }

    private async Task GoToNextScreen(PaintClass paint, PaintLayerEnum layer) 
    {
        // Если человек ответил на вопрос

        if (PaintLayer.CheckAnswer(layer: layer, paint: paint))
        {
            // Если это не последний вопрос
            if (layer != PaintLayerEnum.WaterbornEnum) 
            {
                // Рекурсивно переходим на эту же страницу вопросов,
                // но уже со следующим вопросом

                await Navigation.PushAsync(new LayerPages(paint, PaintLayer.GetNextPage(layer)));
            }
            // Если вопрос последний
            else
            { 
                // Переходим на страницу результатов

                await Navigation.PushAsync(new PickerResultPage(paint));
            }

        }
        // Если человек не ответил на вопрос
        else
        {
            // Выводим сообщение

            await DisplayAlert("Переход невозможен!", "Вы не ответили на вопрос!", "Ок, сейчас отвечу");
        }
    }
}