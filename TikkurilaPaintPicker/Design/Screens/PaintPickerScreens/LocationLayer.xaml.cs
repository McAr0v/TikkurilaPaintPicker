using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class LocationLayer : ContentPage
{
    // ����������� ����������, ������� ����� ���������� ���������
    // � ���������� ����� ��������
    
    PaintClass paint = PaintClass.GetEmptyPaint();

    // ����� ��� ����� �������� � ��� ��������� ������� � ���������

    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    ScrollView primaryScrollForPage = new ScrollView();
    

    // ������

    Button nextButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "��������� ���", TextColor = CustomColors.White };
    Button previousButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "��������� �����", TextColor = CustomColors.Black };

    // ��������� ��� ���������� ������ �� ����� ���������

    Grid buttonsGrid = new Grid
    {
        ColumnSpacing = 20,
        Margin = new Thickness(0, 20),
    };

    // Frame, ��� ��������� ����������� �������� �� ��������

    Frame answerWidget = new Frame
    {
        HasShadow = true,
        BackgroundColor = CustomColors.White,
        Padding = new Thickness(20),
        Margin = new Thickness(0, 10),
        CornerRadius = 10
    };

    // ������ �������

    List<PaintLocationEnum> enumsList = new List<PaintLocationEnum>() { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor };    

    public LocationLayer()
	{
		InitializeComponent();

        // ---- ������ -----

        // ��������� �������� �� ������
        previousButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        nextButton.Clicked += async (sender, args) => await GoToNextScreen(paint);
        
        // ��������� ������ � 2 �������
        buttonsGrid.Add(previousButton, 0, 0);
        buttonsGrid.Add(nextButton, 1, 0);

        // ----- �����-������ ----
        GenerateAnswersWidget();
        

        // ---- ��������� ��� ����� ----

        // ��������� �������� 
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

        // ��������� ��������� � �������� ������
		GenerateHeadlineAndDesc();

        // ��������� ������ ������� � ������
        pageStack.Add (answerWidget);

        // ��������� ������
        pageStack.Add(buttonsGrid);

        // ��������� ��� pageStack � ScrollView �� ������, ���� 
        // ��������� ���������� ����� ��������� � ���������� pageStack
        // �� ����� ������� �� ���� �����
        primaryScrollForPage.Content = pageStack;

        // ������������� ��������� ��������
        Title = "��������� ������";

        // � �������� �������� ������ ��� ScrollView
        Content = primaryScrollForPage;

	}

    private void GenerateAnswersWidget() 
    {
        StackLayout answersStack = new StackLayout() { Spacing = 5 };

        Label answerHeadline = CustomTextWidget.CustomText
        (
            text: "��� �� ���������� �������?",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center,
            padding: new Thickness(0, 0, 0, 20)
        );

        // ���������� ������ � ��������� � Frame
        answersStack.Add(answerHeadline);
        answersStack.Add(GenerateRadioButtons());
        answerWidget.Content = answersStack;

    }

    private void GenerateHeadlineAndDesc() 
    {
        // ��������� � �������� ��������

        Label pageHeadline = CustomTextWidget.CustomText
            (
            text: "��������� ������",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center
            );

        Label pageDesc = CustomTextWidget.CustomText
            (
            text: "� ���� ������� �� ������� �������������� ��������� ������, ������ ������� �� ������� �� ������� �������" +
            "\r\n\r\n ������� ��������� � ���� � ������� �� ������ ������!",
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
                if (e.Value) // ���� ����������� �������
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
            await DisplayAlert("������� ����������!", "�� �� �������� �� ������!", "��, ������ ������");
        }
    }
}