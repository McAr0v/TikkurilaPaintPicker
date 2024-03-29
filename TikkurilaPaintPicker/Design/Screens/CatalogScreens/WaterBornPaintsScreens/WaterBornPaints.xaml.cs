using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;

namespace TikkurilaPaintPicker.Design.Screens.CatalogScreens;

public partial class WaterBornPaints : ContentPage
{
    Grid grid = new Grid
    {
        Padding = new Thickness(10),
        ColumnSpacing = 10,
        RowSpacing = 10,
    };

    public WaterBornPaints()
	{
		InitializeComponent();

        Title = "Водоэмульсионные краски";

        AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/WaterPaints/for_dry_rooms.png", text: "Для сухих помещений", page: new PaintListScreen());
        AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/WaterPaints/for_wet_rooms.png", text: "Для влажных помещений", page: new PaintListScreen());

        Content = grid;
    }

    private void AddToGrid(int column, int row, string image, string text, ContentPage page)
    {

        Label label = CutomTextWidget.CustomText(
            text: text,
            textColor: CustomColors.White,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Start
            );

        label.HorizontalOptions = LayoutOptions.Start;
        label.VerticalOptions = LayoutOptions.End;
        label.TextDecorations = TextDecorations.Underline;
        label.Padding = new Thickness(20, 20);

        label.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(async () =>
            {
                await NavigateInCatalog(page);

            })
        });

        grid.Add(new BoxView
        {
            Color = CustomColors.Black,
        }, column, row);

        grid.Add(new Image
        {
            Source = image,
            Aspect = Aspect.AspectFill,
            Opacity = 0.5
        }, column, row);

        grid.Add(label, column, row);
    }

    private async Task NavigateInCatalog(ContentPage page)
    {

        await Navigation.PushAsync(page);

    }
}