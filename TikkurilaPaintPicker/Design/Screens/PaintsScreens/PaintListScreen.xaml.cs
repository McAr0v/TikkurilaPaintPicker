using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.PaintLists;

namespace TikkurilaPaintPicker.Design.Screens.PaintsScreens;

public partial class PaintListScreen : ContentPage
{
    List<PaintClass> allPaints = PaintRepository.GetAllPaints();
    public PaintListScreen()
	{
		InitializeComponent();

        StackLayout stackLayout = new StackLayout
        {
            Spacing = 20
        };

        Button button = new Button();

        button.Text = "Go";
        //button.Clicked += NavigateToSecondPage_Clicked;

        foreach (PaintClass paint in allPaints)
        {

            Label label = new Label
            {
                Text = paint.Name
            };

            label.BindingContext = paint;

            label.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    // Получаем объект Paint из BindingContext метки
                    PaintClass selectedPaint = label.BindingContext as PaintClass;
                    if (selectedPaint != null)
                    {
                        await NavigateToPaintPage(selectedPaint);
                    }
                })
            });

            stackLayout.Children.Add(label);
        }

        Content = stackLayout;
    }

    private async Task NavigateToPaintPage(PaintClass paint)
    {
        await Navigation.PushAsync(new PaintViewScreen(paint: paint));

        //var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
        //Navigation.RemovePage(previousPage);
    }
}