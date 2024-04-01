using Microsoft.Maui;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.PaintLists;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class PickerResultPage : ContentPage
{
    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    ScrollView primaryScrollForPage = new ScrollView();

    Button catalogButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "Перейти в каталог красок >>", TextColor = CustomColors.White };
    Button backButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "<< Вернуться назад", TextColor = CustomColors.Black };
    Button mainPageButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "Вернуться на главный экран >>", TextColor = CustomColors.Black };

    List<PaintClass> paintsResultList = new List<PaintClass>();

    PaintRepository paintRepository = new PaintRepository();

    public PickerResultPage(PaintClass paint)
	{
		InitializeComponent();

        backButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        mainPageButton.Clicked += async (sender, args) => await NavigateToMainPage();
        catalogButton.Clicked += async (sender, args) => await Navigation.PushAsync(new CatalogScreen());

        paintsResultList = paintRepository.GetPaintsListFromPickerResult(paint);

        pageStack.Add(catalogButton);
        pageStack.Add(backButton);
        pageStack.Add(mainPageButton);

        primaryScrollForPage.Content = pageStack;

        Content = primaryScrollForPage;

        Title = "Результат подбора";

    }

    private async Task NavigateToMainPage()
    {
        await Navigation.PopToRootAsync();
    }

    
}