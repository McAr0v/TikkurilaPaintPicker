using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint.Enums;

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

    ScrollView scrollView = new ScrollView();

    // Переопределяем функцию на нажатие кнопки назад
    // Для того, чтобы при переходе с пикера красок на этот экран
    // человек возвращался на главную страницу, а не в стак экранов

    protected override bool OnBackButtonPressed()
    {
        // Ваша функция для обработки нажатия кнопки "назад"
        // Например, переход на предыдущую страницу в стеке навигации
        Navigation.PopToRootAsync();

        // Возвращаем true, чтобы предотвратить выполнение стандартного обработчика
        return true;
    }

    public CatalogScreen()
	{
		InitializeComponent();

        scrollView.Content = stackLayout;

        BackgroundColor = CustomColors.WhiteGrey;

        Title = "Каталог";

        AddToStack(
            CategoryEnums.WaterbornePaints,
            CategoryTranslator.GetCategoriesList(CategoryEnums.WaterbornePaints));

        AddToStack(
            CategoryEnums.FacadePaints,
            CategoryTranslator.GetCategoriesList(CategoryEnums.FacadePaints));
        AddToStack(
            CategoryEnums.WoodPreservatives,
            CategoryTranslator.GetCategoriesList(CategoryEnums.WoodPreservatives));
        AddToStack(
            CategoryEnums.Varnishes,
            CategoryTranslator.GetCategoriesList(CategoryEnums.Varnishes));

        AddToStack(
            CategoryEnums.Enamels,
            CategoryTranslator.GetCategoriesList(CategoryEnums.Enamels));

        AddToStack(
            CategoryEnums.Primers,
            CategoryTranslator.GetCategoriesList(CategoryEnums.Primers));
        
        AddToStack(
            CategoryEnums.Solvents,
            CategoryTranslator.GetCategoriesList(CategoryEnums.Solvents));
        AddToStack(
            CategoryEnums.CleaningAgentsAndAdditives,
            CategoryTranslator.GetCategoriesList(CategoryEnums.CleaningAgentsAndAdditives));


        //AddToGrid(column: 0, row: 0, image: "Images/CategoriesImages/water_paints.png", text: "Водоэмульсионные краски", page: new WaterBornPaints());
        //AddToGrid(column: 1, row: 0, image: "Images/CategoriesImages/exterier_paint.png", text: "Фасадные краски", page: new FasadePaintsScreen());
        //AddToGrid(column: 0, row: 1, image: "Images/CategoriesImages/septik.png", text: "Пропитки для дерева", page: new WoodOilsScreen());
        //AddToGrid(column: 1, row: 1, image: "Images/CategoriesImages/lackuer.png", text: "Лаки", page: new LackuersScreens());
        //AddToGrid(column: 0, row: 2, image: "Images/CategoriesImages/primers.png", text: "Грунтовки", page: new PrimersScreen());
        //AddToGrid(column: 1, row: 2, image: "Images/CategoriesImages/maailn.png", text: "Эмали", page: new WaterBornPaints());
        //AddToGrid(column: 0, row: 3, image: "Images/CategoriesImages/thinners.png", text: "Растворители", page: new PaintListScreen());
        //AddToGrid(column: 1, row: 3, image: "Images/CategoriesImages/wash_products.png", text: "Моющие средства и добавки", page: new PaintListScreen());

        //Content = grid;

        Content = scrollView;
    }

    private void AddToStack(CategoryEnums headlineEnum, List<CategoryEnums> items) 
    {
        StackLayout stack = new StackLayout();

        stack.Spacing = 10;

        StackLayout itemsAfterHeadline = getItems(items);

        itemsAfterHeadline.Spacing = 5;

        Label headline = CustomWidgets.CustomText(
            text: CategoryTranslator.Translate(headlineEnum),
            textColor: CustomColors.Black,
            textState: TextState.HeadlineSmall,
            horizontalAligment: TextAlignment.Start
            );

        headline.TextDecorations = TextDecorations.Underline;
        

        headline.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(async () =>
            {
                await NavigateInCatalog(new CategoryPage(headlineEnum, items));

            })
        });

        Label desc = CustomWidgets.CustomText(
            text: CategoryTranslator.GetDescription(headlineEnum),
            textColor: CustomColors.Black,
            textState: TextState.DescMedium,
            horizontalAligment: TextAlignment.Start
            );

        stack.Add(headline);

        stack.Add(desc);

        stack.Add(itemsAfterHeadline);

        Frame frame = new Frame
        {
            Content = stack, 
            HasShadow = true, 
            BackgroundColor = CustomColors.White,
            Padding = new Thickness(20),
            Margin = new Thickness(20, 10),
            CornerRadius = 10 
        };

        stackLayout.Add(frame);


    }

    StackLayout getItems(List<CategoryEnums> itemsNames) 
    {
        StackLayout items = new StackLayout();
        items.Spacing = 3;

        foreach (CategoryEnums item in itemsNames) 
        {
            Label headline = CustomWidgets.CustomText(
            text: CategoryTranslator.Translate(item),
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Start
            );

            headline.TextDecorations = TextDecorations.Underline;


            headline.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    await NavigateInCatalog(new CategoryPage(item, new List<CategoryEnums>()));

                })
            });

            items.Add(headline);
        }

        return items;

    }

    private void AddToGrid(int column, int row, string image, string text, ContentPage page) 
    {      

        Label label = CustomWidgets.CustomText(
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