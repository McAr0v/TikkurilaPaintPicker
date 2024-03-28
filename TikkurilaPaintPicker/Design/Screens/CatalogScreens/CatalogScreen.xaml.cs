using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;

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

        Title = "�������";

        AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/water_paints.png", text: "���������������� ������", page: new WaterBornPaints());
        AddToGrid(column: 1, row: 0, image: "Images/CategoriesImages/exterier_paint.png", text: "�������� ������", page: new FasadePaintsScreen());
        AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/septik.png", text: "�������� ��� ������", page: new WoodOilsScreen());
        AddToGrid(column: 1, row: 1, image: "Images/CategoriesImages/lackuer.png", text: "����", page: new LackuersScreens());
        AddToGrid(column: 0, row: 2, image: "Images/CategoriesImages/primers.png", text: "���������", page: new PrimersScreen());
        AddToGrid(column: 1, row: 2, image: "Images/CategoriesImages/maailn.png", text: "�����", page: new WaterBornPaints());
        AddToGrid(column: 0, row: 3, image: "Images/CategoriesImages/thinners.png", text: "������������", page: new PaintListScreen());
        AddToGrid(column: 1, row: 3, image: "Images/CategoriesImages/wash_products.png", text: "������ �������� � �������", page: new PaintListScreen());

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