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
    // ����������� ���������� ������, ������� ����� ���������� ���������
    // � ���������� ���������� ����� ��������
    
    PaintClass paint;

    // ���� ��� ����� �������� ��������
    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = new Thickness(20, 10) };

    // �������������� ��������, �� ������, ���� ���������� �� ����� ������� � ������� ������
    ScrollView primaryScrollForPage = new ScrollView();
    

    // ������
    Button nextButton = CustomWidgets.CustomButton
        (
            text: "��������� ��� >>", 
            buttonState: ButtonState.Primary
        );
    Button previousButton = CustomWidgets.CustomButton
        (
            text: "<< ��������� �����", 
            buttonState: ButtonState.Secondary
        );

    // ��������� ��� ���������� ������ � 2 �������

    Grid buttonsGrid = new Grid
    {
        ColumnSpacing = 20,
    };

    // Frame, ��� ��������� ����������� �������� �� ��������

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

        // ������� ������ ������� � ���������� ������
        // ����� ��� ����������� ����� ����� 1 ����� ������������
        // ��������� ��������

        ClearPaint(layer);

        // ---- ������ -----

        // ��������� �������� �� ������
        previousButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        nextButton.Clicked += async (sender, args) => await GoToNextScreen(paint, layer);
        
        // ��������� ������ � 2 �������
        buttonsGrid.Add(previousButton, 0, 0);
        buttonsGrid.Add(nextButton, 1, 0);

        // ----- �����-������ ----

        GenerateAnswersWidget(layer);
        

        // ---- ��������� ��� ����� ----

        // ��������� ������ ������� � ������
        pageStack.Add (answerWidget);

        // ��������� ������
        pageStack.Add(buttonsGrid);



        // ��������� ��� pageStack � ScrollView �� ������, ���� 
        // ��������� ���������� ����� ��������� � ���������� pageStack
        // �� ����� ������� �� ���� �����
        primaryScrollForPage.Content = pageStack;

        // ������������� ��������� ��������
        Title = PaintLayer.GetPageHeadline(layer);

        // � �������� �������� �������� ������ ��� ScrollView
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

        // ���������� ������ � ��������� � Frame
        answersStack.Add(answerHeadline);
        answersStack.Add(GenerateRadioButtons(layer));
        answerWidget.Content = answersStack;

    }

    private StackLayout GenerateRadioButtons(PaintLayerEnum layer) 
    {
        // ---- ������ ������� ---

        // ������, ������� ����� ������������� � ����������� �� ����������� ������
        
        List<PaintObjectEnum> paintObjectList = new List<PaintObjectEnum>() { PaintObjectEnum.Windows, PaintObjectEnum.Constructions };
        List<PaintMaterialEnum> paintMaterialList = new List<PaintMaterialEnum> { PaintMaterialEnum.Metal, PaintMaterialEnum.Wood, PaintMaterialEnum.Plasterboard };


        // ������, ������� �� ���� ������������

        List<PaintLocationEnum> paintLocationList = new List<PaintLocationEnum>() { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor };
        List<PaintGlossEnum> paintGlossList = new List<PaintGlossEnum> { PaintGlossEnum.Matt, PaintGlossEnum.Gloss };
        List<PaintThinnerEnum> paintThinnerList = new List<PaintThinnerEnum> { PaintThinnerEnum.Water, PaintThinnerEnum.Solvent1050 };
        List<PaintColorEnum> paintColorsList = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White };

        // ---- ���������� ������ ������� ----

        if (layer == PaintLayerEnum.MaterialEnum) 
        {
            paintMaterialList = PaintMaterial.GetMaterialList(paint.Locations[0]);

        } else if (layer == PaintLayerEnum.ObjectEnum)
        {
            paintObjectList = PaintObject.GetPaintObjectList(paintMaterial: paint.Materials[0], paintLocation: paint.Locations[0]);
        }

        // ���� ������� � �������� ��������� ������� ������, �� ����� �������� � �����
        // �������������� ���� ����� � ��������

        if (paint.Materials.Count > 0 && (paint.Materials[0] == PaintMaterialEnum.Wood || paint.Materials[0] == PaintMaterialEnum.Osb))
        {
            paintColorsList.Add(PaintColorEnum.NoColor);
        }

        StackLayout radioButtonsLayout = new StackLayout();

        // ---- ���������� ������ -----

        // � ����������� �� ������� (PaintLayer) ���������� ������,
        // ������������� �������� �� ������� ��������,
        // � ��������� � ���� �������

        // "����" ������� � ������� ������� 
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
        // "����" ������� �� ������� ������� 
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
        // "����" ������� �� ������������ ��������� 
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
        // "����" ������� � �������� ����� ������ 
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
        // "����" ������� � �������� ������ ���������
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
        // "����" ������� � ������������ ��������� � ������ �� ������ ������ 
        else if (layer == PaintLayerEnum.WaterbornEnum)
        {
            foreach (PaintThinnerEnum thinner in paintThinnerList)
            {
                RadioButton radioButton = CustomWidgets.CustomRadioButton
                    (
                        text: thinner == PaintThinnerEnum.Solvent1050 ? 
                        "����� �� �������������" 
                        : "��, ������ ������ ���� ��� ������"
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
        // ���� ������� ������� �� ������

        if (PaintLayer.CheckAnswer(layer: layer, paint: paint))
        {
            // ���� ��� �� ��������� ������
            if (layer != PaintLayerEnum.WaterbornEnum) 
            {
                // ���������� ��������� �� ��� �� �������� ��������,
                // �� ��� �� ��������� ��������

                await Navigation.PushAsync(new LayerPages(paint, PaintLayer.GetNextPage(layer)));
            }
            // ���� ������ ���������
            else
            { 
                // ��������� �� �������� �����������

                await Navigation.PushAsync(new PickerResultPage(paint));
            }

        }
        // ���� ������� �� ������� �� ������
        else
        {
            // ������� ���������

            await DisplayAlert("������� ����������!", "�� �� �������� �� ������!", "��, ������ ������");
        }
    }
}