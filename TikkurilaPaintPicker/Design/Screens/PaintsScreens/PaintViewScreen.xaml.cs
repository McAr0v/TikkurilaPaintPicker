using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintsScreens;

public partial class PaintViewScreen : ContentPage
{

    // Делегат для перехода на страницу категории
    public delegate Task NavigateToPageDelegate(CategoryEnums categoryEnum);

    // Функция для перехода на страницу категории
    private async Task OnLabelTapped(CategoryEnums categoryEnum)
    {
        await Navigation.PushAsync(new CategoryPage(categoryEnum, CategoryTranslator.GetCategoriesList(categoryEnum)));
    }

    Button button = new Button();

	public PaintViewScreen(PaintClass paint)
	{
		InitializeComponent();

        button.Text = "GoBack";

        button.Clicked += async (sender, args) => await NavigateToSecondPage();

        Title = paint.Name;

        Content = new ScrollView
        {
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Spacing = 20,
                Children =
            {
                new Image
                {
                    Source = $"Images/PaintImages/{paint.Name}.png",
                    Aspect = Aspect.AspectFit,
                    HeightRequest = 300,
                },

                new Label
                {
                    Text = paint.Name,
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold,
                },

                new Label
                {
                    Text = paint.Description,
                },

                paint.GetProductOptionsFrame(OnLabelTapped),

                button

                // Ваши дополнительные элементы, если они есть

            }
            }
        };

    }

    private async Task NavigateToSecondPage()
    {
        await Navigation.PopToRootAsync();

        //var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
        //Navigation.RemovePage(previousPage);
    }
}