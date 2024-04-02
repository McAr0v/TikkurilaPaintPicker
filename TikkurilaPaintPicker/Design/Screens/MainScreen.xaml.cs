using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;

namespace TikkurilaPaintPicker.Design.Screens;

public partial class MainScreen : ContentPage
{
    // Прокручиваемая разметка страницы
    ScrollView pageScroll = new ScrollView();

    // Основной стак элементов страницы
    StackLayout pageStack = new StackLayout()
    {
        Margin = new Thickness(20),
        Spacing = 10,
    };

    // Кнопки
    Button catalogButton = CustomWidgets.CustomButton(text: "Перейти в каталог", ButtonState.Secondary);
    Button pickerButton = CustomWidgets.CustomButton(text: "Подборщик красок", ButtonState.Primary);

    Label label = CustomWidgets.CustomText(
            text: "Добро пожаловать в приложение Tikkurila!",
            textColor: CustomColors.Black,
            textState: TextState.HeadlineMedium,
            horizontalAligment: TextAlignment.Center
            );

    Label desc = CustomWidgets.CustomText(
            text: "Мы рады видеть Вас в нашем приложении! " +
                    "В нем вы можете ознакомиться с нашими красками. " +
                    "\r\n\r\nВоспользуйтесь подборщиком красок или каталогом, чтобы найти подходящую краску для ремонта!",
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

    // Разметка для расположения кнопок в 2 колонки

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

        // Добавляем кнопки в 2 колонки

        buttonsGrid.Add(catalogButton, 0, 0);
        buttonsGrid.Add(pickerButton, 1, 0);

        Title = "";

        // Добавляем весь контент в pageStack
        AddContent();

        // Добавляем pageStack в прокручиваемую разметку
        pageScroll.Content = pageStack;

        // В качестве контента страницы устанавливаем
        // прокручиваемую разметку
        Content = pageScroll;

    }

    /// <summary>
    /// Функция добавления контента страницы в 
    /// основной pageStack
    /// </summary>
    private void AddContent()
    {
        pageStack.Add(tikkurilaLogo);
        pageStack.Add(label);
        pageStack.Add(desc);
        pageStack.Add(buttonsGrid);
    }
}