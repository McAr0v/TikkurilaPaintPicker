using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;

namespace TikkurilaPaintPicker.Design.Screens.CatalogScreens;

public partial class LackuersScreens : ContentPage
{
    Grid grid = new Grid
    {
        Padding = new Thickness(10),
        ColumnSpacing = 10,
        RowSpacing = 10,
    };

    public LackuersScreens()
    {
        InitializeComponent();

        Title = "Лаки";

        AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/LackuerPaints/for_walls.png", text: "Для стен и потолков", page: new PaintListScreen());
        AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/LackuerPaints/for_furniture.png", text: "Для мебели", page: new PaintListScreen());
        AddToGrid(column: 0, row: 2, image: "Images/CategoriesImages/LackuerPaints/for_floor.png", text: "Для полов", page: new PaintListScreen());

        Content = grid;
    }

    private void AddToGrid(int column, int row, string image, string text, ContentPage page)
    {

        Label label = CustomTextWidget.CustomText(
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