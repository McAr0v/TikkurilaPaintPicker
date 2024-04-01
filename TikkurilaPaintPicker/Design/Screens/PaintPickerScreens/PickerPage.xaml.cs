using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Paint;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class PickerPage : ContentPage
{

    PaintClass paint = PaintClass.GetEmptyPaint();

    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    ScrollView primaryScrollForPage = new ScrollView();

    Button nextButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "�������� >>", TextColor = CustomColors.White };
    Button previousButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "<< ��������� �����", TextColor = CustomColors.Black };

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

        // ��������� ������ � 2 �������
        buttonsGrid.Add(previousButton, 0, 0);
        buttonsGrid.Add(nextButton, 1, 0);

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
}