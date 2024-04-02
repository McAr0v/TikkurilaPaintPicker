using Microsoft.Maui.Graphics;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;

namespace TikkurilaPaintPicker.Design.Screens;

public partial class MainScreen : ContentPage
{

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

	public MainScreen()
	{
		InitializeComponent();

        catalogButton.Clicked += async (sender, args) => await Navigation.PushAsync(new CatalogScreen());

        pickerButton.Clicked += async (sender, args) => await Navigation.PushAsync(new PickerPage());

        Grid grid = new Grid
        {
            ColumnSpacing = 20,
            Margin = new Thickness(0, 20),
        };

        grid.Add(catalogButton, 0, 0);
        grid.Add(pickerButton, 1, 0);

        Title = "������� ��������";

        Content = new ScrollView
        {
           
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center,
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(20),
                Spacing = 10,
                Children =
                {
                    new Image
                    {
                        Source = $"Images/tikkurila_logo.png",
                        Aspect = Aspect.AspectFit,
                        HeightRequest = 100,
                        HorizontalOptions = LayoutOptions.Center,
                    },

                    label,

                    desc,

                    grid

                }
            }
        };

    }
}