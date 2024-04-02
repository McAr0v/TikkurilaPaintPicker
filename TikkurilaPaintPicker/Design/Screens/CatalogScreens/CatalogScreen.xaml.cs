using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.CatalogScreens;

public partial class CatalogScreen : ContentPage
{

    StackLayout pageStack = new StackLayout();

    ScrollView pageScrollView = new ScrollView();

    /// <summary>
    /// ������ ���� ������� ���������
    /// </summary>
    readonly List<CategoryEnums> categories = new List<CategoryEnums>() 
    { 
        CategoryEnums.WaterbornePaints,
        CategoryEnums.FacadePaints,
        CategoryEnums.WoodPreservatives,
        CategoryEnums.Varnishes,
        CategoryEnums.Enamels,
        CategoryEnums.Primers,
        CategoryEnums.Solvents,
        CategoryEnums.CleaningAgentsAndAdditives
    };

    /// <summary>
    /// ����� ������ �������� ������ �� ����� �����������
    /// � ��������������.
    /// ����� ��� ����������� ������
    /// </summary>
    public CatalogScreen()
	{
		InitializeComponent();

        pageScrollView.Content = pageStack;

        BackgroundColor = CustomColors.WhiteGrey;

        Title = "�������";

        foreach(CategoryEnums categoryEnum in categories)
        {
            AddToStack
                (
                categoryEnum,
                CategoryClass.GetChildrenCategoriesList(categoryEnum)
                );
        }

        Content = pageScrollView;
    }

    // �������������� ������� �� ������� ������ �����
    // ��� ����, ����� ��� �������� � ������ ������ �� ���� �����
    // ������� ����������� �� ������� ��������, � �� � ���� �������

    protected override bool OnBackButtonPressed()
    {
        Navigation.PopToRootAsync();

        return true;
    }

    /// <summary>
    /// ������� �������� �������� ��������� � ������������
    /// � �������� ������ CatalogScreen()
    /// </summary>
    /// <param name="headlineEnum"></param>
    /// <param name="items"></param>
    private void AddToStack(CategoryEnums headlineEnum, List<CategoryEnums> items) 
    {
        StackLayout stack = new StackLayout() {Spacing = 10 };

        StackLayout itemsAfterHeadline = GetItems(items);

        itemsAfterHeadline.Spacing = 5;

        Label headline = CustomWidgets.CustomText(
            text: CategoryClass.Translate(headlineEnum),
            textColor: CustomColors.Black,
            textState: TextState.HeadlineSmall,
            horizontalAligment: TextAlignment.Start,
            underline: TextDecorations.Underline
            );       

        headline.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(async () =>
            {
                await NavigateToPage(new CategoryPage(headlineEnum, items));

            })
        });

        Label desc = CustomWidgets.CustomText(
            text: CategoryClass.GetDescription(headlineEnum),
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

        pageStack.Add(frame);

    }

    /// <summary>
    /// ������� ��������� ����� ������������ ��� �������� ���������
    /// </summary>
    /// <param name="itemsNames"></param>
    /// <returns></returns>
    StackLayout GetItems(List<CategoryEnums> itemsNames) 
    {
        StackLayout items = new StackLayout();
        items.Spacing = 3;

        foreach (CategoryEnums item in itemsNames) 
        {
            Label headline = CustomWidgets.CustomText(
            text: CategoryClass.Translate(item),
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Start,
            underline: TextDecorations.Underline
            );

            headline.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    await NavigateToPage(new CategoryPage(item, new List<CategoryEnums>()));

                })
            });

            items.Add(headline);
        }

        return items;

    }

    
    /// <summary>
    /// ������� �������� �� ������������ ��������
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    private async Task NavigateToPage(ContentPage page)
    {

        await Navigation.PushAsync(page);

    }
}