using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;

namespace TikkurilaPaintPicker.Design.Screens.CatalogScreens;

public partial class WoodOilsScreen : ContentPage
{
    Grid grid = new Grid
    {
        Padding = new Thickness(10),
        ColumnSpacing = 10,
        RowSpacing = 10,
    };

    public WoodOilsScreen()
    {
        InitializeComponent();

        Title = "�������� ��� ������";

        AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/WoodOilsPaints/sauna.png", text: "�������� ��� �����", page: new PaintListScreen());
        AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/WoodOilsPaints/outside.png", text: "�������� ��� �������� �����", page: new PaintListScreen());
        AddToGrid(column: 0, row: 2, image: "Images/CategoriesImages/WoodOilsPaints/inside.png", text: "�������� ��� ��������� �����", page: new PaintListScreen());

        Content = grid;
    }

    private void AddToGrid(int column, int row, string image, string text, ContentPage page)
    {

        Label label = CutomTextWidget.CustomText(
            text: text,
            textColor: Colors.White,
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
            Color = Colors.Black,
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