using Microsoft.Maui.Graphics;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;

namespace TikkurilaPaintPicker.Design.Screens;

public partial class MainScreen : ContentPage
{

    Button catalogButton = new Button();
    Button pickerButton = new Button();

    Label label;
    Label desc;

	public MainScreen()
	{
		InitializeComponent();

        label = CustomWidgets.CustomText(
            text: "Добро пожаловать в приложение Tikkurila!", 
            textColor: CustomColors.Black, 
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center
            );

        desc = CustomWidgets.CustomText(
            text: "Мы рады видеть Вас в нашем приложении! " +
                    "В нем вы можете ознакомиться с нашими красками. " +
                    "\r\n\r\nВоспользуйтесь подборщиком красок или каталогом, чтобы найти подходящую краску для ремонта!",
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Center
            );

        catalogButton.Text = "Перейти в каталог";
        catalogButton.Clicked += async (sender, args) => await NavigateToCatalogPage();

        pickerButton.Text = "Подборщик красок";
        pickerButton.Clicked += async (sender, args) => await NavigateToPickerPage();

        Grid grid = new Grid
        {
            ColumnSpacing = 20,
            Margin = new Thickness(0, 20),
        };

        grid.Add(catalogButton, 0, 0);
        grid.Add(pickerButton, 1, 0);

        Title = "Главная страница";

        Content = new ScrollView
        {
           
            VerticalOptions = LayoutOptions.Center,
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

    private async Task NavigateToCatalogPage()
    {

        await Navigation.PushAsync(new CatalogScreen());

    }

    private async Task NavigateToPickerPage()
    {

        await Navigation.PushAsync(new PickerPage());

    }
}