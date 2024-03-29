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

    StackLayout stackLayout = new StackLayout();

    ScrollView scrollView = new ScrollView() 
    {
        Padding = new Thickness (20),
        
    };

    

    public CatalogScreen()
	{
		InitializeComponent();

        scrollView.Content = stackLayout;



        Title = "�������";

        AddToStack("�������� ������", new List<string> { "��� ������", "��� ����������� ������������" });

        //AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/water_paints.png", text: "���������������� ������", page: new WaterBornPaints());
        //AddToGrid(column: 1, row: 0, image: "Images/CategoriesImages/exterier_paint.png", text: "�������� ������", page: new FasadePaintsScreen());
        //AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/septik.png", text: "�������� ��� ������", page: new WoodOilsScreen());
        //AddToGrid(column: 1, row: 1, image: "Images/CategoriesImages/lackuer.png", text: "����", page: new LackuersScreens());
        //AddToGrid(column: 0, row: 2, image: "Images/CategoriesImages/primers.png", text: "���������", page: new PrimersScreen());
        //AddToGrid(column: 1, row: 2, image: "Images/CategoriesImages/maailn.png", text: "�����", page: new WaterBornPaints());
        //AddToGrid(column: 0, row: 3, image: "Images/CategoriesImages/thinners.png", text: "������������", page: new PaintListScreen());
        //AddToGrid(column: 1, row: 3, image: "Images/CategoriesImages/wash_products.png", text: "������ �������� � �������", page: new PaintListScreen());

        //Content = grid;
        Content = stackLayout;
    }

    private void AddToStack(string headlineText, List<string> items) 
    {
        StackLayout stack = new StackLayout();

        stack.Spacing = 10;

        StackLayout itemsAfterHeadline = getItems(items);

        itemsAfterHeadline.Spacing = 5;

        Label headline = CutomTextWidget.CustomText(
            text: headlineText,
            textColor: Colors.Black,
            textState: TextState.HeadlineSmall,
            horizontalAligment: TextAlignment.Start
            );

        headline.TextDecorations = TextDecorations.Underline;
        

        headline.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(async () =>
            {
                //await NavigateInCatalog(page);

            })
        });

        Label desc = CutomTextWidget.CustomText(
            text: "��� ������ ����������� ��� ������� ���� ������� ���������",
            textColor: Colors.Black,
            textState: TextState.DescMedium,
            horizontalAligment: TextAlignment.Start
            );

        stack.Add(headline);

        stack.Add(desc);

        stack.Add(itemsAfterHeadline);

        Frame frame = new Frame
        {
            Content = stack, // ��� StackLayout
            HasShadow = true, // �������� ����
            BackgroundColor = Colors.LightGray,
            Padding = new Thickness(20),
            Margin = new Thickness(20, 10),
            CornerRadius = 10 // ��������� ���������� ����� �� �������
        };

        stackLayout.Add(frame);


    }

    StackLayout getItems(List<string> itemsNames) 
    {
        StackLayout items = new StackLayout();
        items.Spacing = 3;

        foreach (string item in itemsNames) 
        {
            Label headline = CutomTextWidget.CustomText(
            text: item,
            textColor: Colors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Start
            );

            headline.TextDecorations = TextDecorations.Underline;


            headline.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    //await NavigateInCatalog(page);

                })
            });

            items.Add(headline);
        }

        return items;

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