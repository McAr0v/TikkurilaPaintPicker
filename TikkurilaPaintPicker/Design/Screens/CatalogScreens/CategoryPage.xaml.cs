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

    public CategoryPage(CategoryEnums categoryEnum, List<CategoryEnums> childrenCategories)
	{
		InitializeComponent();

        categoryDesc = CutomTextWidget.CustomText(
                text: CategoryTranslator.GetDescription(categoryEnum),
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
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

        AddPaints();


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
                    await NavigateInCatalog(new CategoryPage(headlineEnum, new List<CategoryEnums>()));

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