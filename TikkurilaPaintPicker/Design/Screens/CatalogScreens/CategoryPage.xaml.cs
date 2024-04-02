using Microsoft.Maui.Graphics;
using System.Data.Common;
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
    StackLayout stackLayout = new StackLayout() { Spacing = 20};

    ScrollView scrollView = new ScrollView() {Padding = 20 };

    List<PaintClass> paints = new List<PaintClass>();

    PaintRepository paintRepository = new PaintRepository();

    Label categoryDesc;

    Label paintsHeadline;

    public CategoryPage(CategoryEnums categoryEnum, List<CategoryEnums> childrenCategories)
	{
		InitializeComponent();

        categoryDesc = CustomWidgets.CustomText(
                text: CategoryTranslator.GetDescription(categoryEnum),
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
                horizontalAligment: TextAlignment.Start
                );

        paintsHeadline = CustomWidgets.CustomText(
                text: $"Все краски категории {CategoryTranslator.Translate(categoryEnum)}:",
                textColor: CustomColors.Black,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Start
                );

        paints = paintRepository.GetPaintsInCategory(categoryEnum);

        scrollView.Content = stackLayout;

        BackgroundColor = CustomColors.WhiteGrey;

        Title = CategoryTranslator.Translate(category: categoryEnum);

        stackLayout.Add(categoryDesc);

        if (childrenCategories.Count != 0) 
        {
            AddToStack(childrenCategories);
        }

        stackLayout.Add(paintsHeadline);

        AddAllPaints();

        scrollView.Content = stackLayout;

        Content = scrollView;



    }

    private void AddAllPaints()
    {
        foreach (PaintClass childPaint in paints)
        {
            stackLayout.Add(PaintItemInList.PaintItemWidgetInList(
                paint: childPaint,
                categoryAction: async () =>
                {
                    await Navigation.PushAsync(new CategoryPage(childPaint.Categories[0], CategoryTranslator.GetCategoriesList(childPaint.Categories[0])));
                },
                paintAction: async () =>
                {
                    await NavigateToPaintPage(childPaint);
                }
                )
            );
        }
    }

    private async Task NavigateToPaintPage(PaintClass paint)
    {
        await Navigation.PushAsync(new PaintViewScreen(paint: paint));

        //var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
        //Navigation.RemovePage(previousPage);
    }

    private void AddToStack(List<CategoryEnums> childrenCategories)
    {
        

        foreach(CategoryEnums headlineEnum in childrenCategories) 
        {
            StackLayout stack = new StackLayout();

            stack.Spacing = 10;

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
                    await NavigateInCatalog(new CategoryPage(headlineEnum, CategoryTranslator.GetCategoriesList(headlineEnum)));

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

            Frame frame = new Frame
            {
                Content = stack, // Ваш StackLayout
                HasShadow = true, // Включить тень
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10 // Настройте скругление углов по желанию
            };

            stackLayout.Add(frame);
        }
    }

    private async Task NavigateInCatalog(ContentPage page)
    {

        await Navigation.PushAsync(page);

    }
}