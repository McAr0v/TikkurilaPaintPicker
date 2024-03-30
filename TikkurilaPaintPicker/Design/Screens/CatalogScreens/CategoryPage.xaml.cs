using Microsoft.Maui.Graphics;
using System.Data.Common;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;
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

        categoryDesc = CutomTextWidget.CustomText(
                text: CategoryTranslator.GetDescription(categoryEnum),
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
                horizontalAligment: TextAlignment.Start
                );

        paintsHeadline = CutomTextWidget.CustomText(
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

        //AddPaints();

        AddPaintsTwo();

        scrollView.Content = stackLayout;

        Content = scrollView;



    }

    private void AddPaints()
    {
        foreach (PaintClass paint in paints)
        {

            Label label = new Label
            {
                Text = paint.Name
            };

            label.BindingContext = paint;

            label.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    // Получаем объект Paint из BindingContext метки
                    PaintClass selectedPaint = label.BindingContext as PaintClass;
                    if (selectedPaint != null)
                    {
                        await NavigateToPaintPage(selectedPaint);
                    }
                })
            });

            stackLayout.Children.Add(label);
        }
    }

    private void AddPaintsTwo()
    {
        foreach(PaintClass paint in paints)
{
            Grid grid = new Grid
            {
                //Padding = new Thickness(10),
                ColumnSpacing = 10,
                RowSpacing = 10,
            };

            StackLayout stack = new StackLayout()
            {
                Spacing = 10
            };

            // Первая колонка, занимающая 1/3 ширины экрана
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // Вторая колонка, занимающая оставшуюся часть ширины
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            Image image = new Image
            {
                Source = $"Images/PaintImages/{paint.Name}.png",
                Aspect = Aspect.AspectFill,
            };

            Label label = CutomTextWidget.CustomText(
                text: paint.Name,
                textColor: CustomColors.Black,
                textState: TextState.HeadlineSmall,
                horizontalAligment: TextAlignment.Start
            );

            Label paintDesc = CutomTextWidget.CustomText(
                text: paint.Description,
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start
            );

            Label textButton = CutomTextWidget.CustomText(
                text: "Подробнее",
                textColor: CustomColors.TikkurilaRed,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start,
                underline: TextDecorations.Underline
            );

            paintDesc.LineBreakMode = LineBreakMode.WordWrap;
            paintDesc.MaxLines = 3;

            label.BindingContext = paint;

            

            stack.Children.Add(label);
            stack.Children.Add(paintDesc);
            stack.Children.Add(textButton);

            grid.Add(image, 0, 0);
            grid.Add(stack, 1, 0); 

            Frame frame = new Frame
            {
                Content = grid, 
                HasShadow = true, 
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10 
            };

            frame.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    // Получаем объект Paint из BindingContext метки
                    PaintClass selectedPaint = label.BindingContext as PaintClass;
                    if (selectedPaint != null)
                    {
                        await NavigateToPaintPage(selectedPaint);
                    }
                })
            });


            stackLayout.Children.Add(frame); // Добавляем Grid в StackLayout
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

            Label headline = CutomTextWidget.CustomText(
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

            Label desc = CutomTextWidget.CustomText(
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
                //Margin = new Thickness(0, 10),
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