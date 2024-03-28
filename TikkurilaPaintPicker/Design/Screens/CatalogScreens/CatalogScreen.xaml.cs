using TikkurilaPaintPicker.Design.Font;

namespace TikkurilaPaintPicker.Design.Screens.CatalogScreens;

public partial class CatalogScreen : ContentPage
{

    Grid grid = new Grid
    {
        Padding = new Thickness(10),
        ColumnSpacing = 10,
        RowSpacing = 10,
    };

    public CatalogScreen()
	{
		InitializeComponent();

        Title = "Каталог";

        AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/water_paints.jpg", text: "Водоэмульсионные краски", page: new WaterBornPaints());
        AddToGrid(column: 1, row: 0, image: "Images/CategoriesImages/exterier_paint.jpg", text: "Фасадные краски", page: new WaterBornPaints());
        AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/septik.jpg", text: "Пропитки для дерева", page: new WaterBornPaints());
        AddToGrid(column: 1, row: 1, image: "Images/CategoriesImages/lackuer.jpg", text: "Лаки", page: new WaterBornPaints());
        AddToGrid(column: 0, row: 2, image: "Images/CategoriesImages/primers.jpg", text: "Грунтовки", page: new WaterBornPaints());
        AddToGrid(column: 1, row: 2, image: "Images/CategoriesImages/maailn.jpg", text: "Эмали", page: new WaterBornPaints());
        AddToGrid(column: 0, row: 3, image: "Images/CategoriesImages/thinners.jpg", text: "Растворители", page: new WaterBornPaints());
        AddToGrid(column: 1, row: 3, image: "Images/CategoriesImages/wash_products.jpg", text: "Моющие средства и добавки", page: new WaterBornPaints());

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