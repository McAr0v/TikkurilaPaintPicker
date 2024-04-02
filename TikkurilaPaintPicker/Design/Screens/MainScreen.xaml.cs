using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;

namespace TikkurilaPaintPicker.Design.Screens;

public partial class MainScreen : ContentPage
{
    // �������������� �������� ��������
    ScrollView pageScroll = new ScrollView();

    // �������� ���� ��������� ��������
    StackLayout pageStack = new StackLayout()
    {
        Margin = new Thickness(20),
        Spacing = 10,
    };

    // ������
    Button catalogButton = CustomWidgets.CustomButton(text: "������� � �������", ButtonState.Secondary);
    Button pickerButton = CustomWidgets.CustomButton(text: "��������� ������", ButtonState.Primary);

    Label label = CustomWidgets.CustomText(
            text: "����� ���������� � ���������� Tikkurila!",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center
            );

    Label desc = CustomWidgets.CustomText(
            text: "�� ���� ������ ��� � ����� ����������! " +
                    "� ��� �� ������ ������������ � ������ ��������. " +
                    "\r\n\r\n�������������� ����������� ������ ��� ���������, ����� ����� ���������� ������ ��� �������!",
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Center
            );

    Image tikkurilaLogo = new Image
    {
        Source = $"Images/tikkurila_logo.png",
        Aspect = Aspect.AspectFit,
        HeightRequest = 100,
        HorizontalOptions = LayoutOptions.Center,
    };

    // �������� ��� ������������ ������ � 2 �������

    Grid buttonsGrid = new Grid
    {
        ColumnSpacing = 20,
        Margin = new Thickness(0, 20),
    };

    public MainScreen()
	{
		InitializeComponent();

        catalogButton.Clicked += async (sender, args) => await Navigation.PushAsync(new CatalogScreen());
        pickerButton.Clicked += async (sender, args) => await Navigation.PushAsync(new PickerPage());

        // ��������� ������ � 2 �������

        buttonsGrid.Add(catalogButton, 0, 0);
        buttonsGrid.Add(pickerButton, 1, 0);

        Title = "";

        // ��������� ���� ������� � pageStack
        AddContent();

        // ��������� pageStack � �������������� ��������
        pageScroll.Content = pageStack;

        // � �������� �������� �������� �������������
        // �������������� ��������
        Content = pageScroll;

    }

    /// <summary>
    /// ������� ���������� �������� �������� � 
    /// �������� pageStack
    /// </summary>
    private void AddContent()
    {
        pageStack.Add(tikkurilaLogo);
        pageStack.Add(label);
        pageStack.Add(desc);
        pageStack.Add(buttonsGrid);
    }
}