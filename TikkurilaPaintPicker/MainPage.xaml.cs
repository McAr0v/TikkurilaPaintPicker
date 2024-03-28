using TikkurilaPaintPicker.Design.Screens.PaintsScreens;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.PaintLists;
namespace TikkurilaPaintPicker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        List<PaintClass> allPaints = PaintRepository.GetAllPaints();

        public MainPage()
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
                            await NavigateToSecondPage(selectedPaint);
                        }
                    })
                });

                stackLayout.Children.Add(label);
            }

            Content = stackLayout;

        }

        private async Task NavigateToSecondPage(PaintClass paint)
        {
            await Navigation.PushAsync(new PaintViewScreen(paint: paint));

            //var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
            //Navigation.RemovePage(previousPage);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
