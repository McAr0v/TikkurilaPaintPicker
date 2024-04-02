using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.PaintWidgets;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;
using TikkurilaPaintPicker.Paint.PaintLists;

namespace TikkurilaPaintPicker.Design.Screens.CatalogScreens;

public partial class CategoryPage : ContentPage
{
    PaintRepository paintRepository = new PaintRepository();

    ScrollView scrollView = new ScrollView() {Padding = 20 };
    StackLayout stack = new StackLayout() { Spacing = 20};

    List<PaintClass> paints = new List<PaintClass>();

    Label categoryDesc;
    Label paintsHeadline;

    public CategoryPage(CategoryEnums categoryEnum, List<CategoryEnums> childrenCategories)
	{
		InitializeComponent();

        // ��������� �������� ���������

        categoryDesc = CustomWidgets.CustomText(
                text: CategoryClass.GetDescription(categoryEnum),
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
                horizontalAligment: TextAlignment.Start
                );

        stack.Add(categoryDesc);

        // ��������� ������������

        if (childrenCategories.Count != 0) 
        {
            AddToStack(childrenCategories);
        }

        // ��������� ��������� ���������

        paintsHeadline = CustomWidgets.CustomText(
                text: $"��� ������ ��������� {CategoryClass.Translate(categoryEnum)}:",
                textColor: CustomColors.Black,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Start
                );

        stack.Add(paintsHeadline);

        // �������� ��� ������, ������� ��������� � ���� ���������

        paints = paintRepository.GetPaintsInCategory(categoryEnum);

        // ��������� ��� ������ �� ������

        AddAllPaints();

        // ������������� ���� ������� � ����������� ��������,
        // �� ������, ���� ������� �� ������ �� ��� ������ ������

        scrollView.Content = stack;

        // ������������� ����������� �������� ��� �������� ������� ��������

        Content = scrollView;

        // ��������� ���� ���� ��� �������� � ���������
        BackgroundColor = CustomColors.WhiteGrey;
        Title = CategoryClass.Translate(category: categoryEnum);


    }

    /// <summary>
    /// ������� ���������� ���� ������ � ���� �� ������ ������
    /// </summary>
    private void AddAllPaints()
    {
        foreach (PaintClass childPaint in paints)
        {
            stack.Add(PaintItemInList.PaintItemWidgetInList(
                paint: childPaint,
                categoryAction: async () =>
                {
                    await Navigation.PushAsync(new CategoryPage(childPaint.Categories[0], CategoryClass.GetChildrenCategoriesList(childPaint.Categories[0])));
                },
                paintAction: async () =>
                {
                    await NavigateToPaintPage(childPaint);
                }
                )
            );
        }
    }

    /// <summary>
    /// ������� �������� �� �������� � ������������� � ������
    /// </summary>
    /// <param name="paint"></param>
    /// <returns></returns>
    private async Task NavigateToPaintPage(PaintClass paint)
    {
        await Navigation.PushAsync(new PaintViewScreen(paint: paint));

    }

    /// <summary>
    /// ������� ���������� � ���� �������� � �����������
    /// </summary>
    /// <param name="childrenCategories"></param>
    private void AddToStack(List<CategoryEnums> childrenCategories)
    {

        foreach(CategoryEnums headlineEnum in childrenCategories) 
        {
            StackLayout categoryStack = new StackLayout() { Spacing = 10};

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
                    await NavigateToCategory(new CategoryPage(headlineEnum, CategoryClass.GetChildrenCategoriesList(headlineEnum)));

                })
            });

            categoryStack.Add(headline);

            Label desc = CustomWidgets.CustomText(
                text: CategoryClass.GetDescription(headlineEnum),
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start
                );

            categoryStack.Add(desc);

            Frame categoryFrame = new Frame
            {
                Content = categoryStack,
                HasShadow = true,
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10 
            };

            stack.Add(categoryFrame);
        }
    }

    /// <summary>
    /// ������� ��� �������� �� �������� ���������
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    private async Task NavigateToCategory(ContentPage page)
    {

        await Navigation.PushAsync(page);

    }
}