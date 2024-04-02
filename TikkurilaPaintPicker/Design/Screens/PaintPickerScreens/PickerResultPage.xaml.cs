
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.PaintWidgets;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Screens.PaintsScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;
using TikkurilaPaintPicker.Paint.PaintLists;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class PickerResultPage : ContentPage
{
    StackLayout pageStack = new StackLayout() { Spacing = 20, Padding = 20 };
    StackLayout paintsStack = new StackLayout() { Spacing = 20};
    ScrollView primaryScrollForPage = new ScrollView();

    Button catalogButton = CustomWidgets.CustomButton("Перейти в каталог красок >>", ButtonState.Secondary);
    Button backButton = CustomWidgets.CustomButton("<< Вернуться назад и изменить ответы", ButtonState.Secondary);
    Button mainPageButton = CustomWidgets.CustomButton("<< Вернуться на главный экран", ButtonState.Primary);

    List<PaintClass> paintsResultList = new List<PaintClass>();

    PaintRepository paintRepository = new PaintRepository();

    public PickerResultPage(PaintClass paint)
	{
		InitializeComponent();

        backButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        mainPageButton.Clicked += async (sender, args) => await Navigation.PopToRootAsync();
        mainPageButton.Margin = new Thickness(0, 20, 0, 0);
        catalogButton.Clicked += async (sender, args) => await Navigation.PushAsync(new CatalogScreen());

        // Получаем список красок, удовлетворяющих условиям ответов из пикера
        paintsResultList = paintRepository.GetPaintsListFromPickerResult(paint);

        // Добавляем виджет с ответами на вопросы в пикере
        pageStack.Add(paint.GetAllAnswers());


        if (paintsResultList.Count > 0) 
        {
            pageStack.Add
                (
                    CustomWidgets.CustomText
                    (
                        text: $"Мы подобрали для вас {GetCountPaintString(paintsResultList.Count)}:",
                        textColor: CustomColors.Black,
                        textState: TextState.HeadlineMedium
                    )
                ); ;

            AddAllPaints();
        }
        else
        {
            WidgetForEmptyList();
        }

        // Добавляем в стак страницы краски или текст что красок не найдено
        pageStack.Add(paintsStack);

        // Добавляем встак страницы кнопки
        pageStack.Add(backButton);
        pageStack.Add(mainPageButton);
        pageStack.Add(catalogButton);

        // Оборачиваем стак страницы в ScrollStack
        primaryScrollForPage.Content = pageStack;

        // Устанавливаем в качестве контента наш прокручиваемый стак
        Content = primaryScrollForPage;

        // Заголовок страницы
        Title = "Результат подбора";

    }

    private string GetCountPaintString(int count) 
    {
        // Для чисел, оканчивающихся на 11, 12, 13 и 14, всегда используем форму "красок"
        if (count % 100 >= 11 && count % 100 <= 14)
        {
            return $"{count} красок";
        }

        // Для остальных чисел используем правила склонения
        switch (count % 10)
        {
            case 1:
                return $"{count} краску";
            case 2:
            case 3:
            case 4:
                return $"{count} краски";
            default:
                return $"{count} красок";
        }
    }

    private void AddAllPaints()
    {
        // Для каждой краски из списка генерируем виджет 
        // и добавляем в paintsStack

        foreach (PaintClass childPaint in paintsResultList)
        {
            paintsStack.Add(PaintItemInList.PaintItemWidgetInList(
                paint: childPaint,
                categoryAction: async () =>
                {
                    await Navigation.PushAsync(new CategoryPage(childPaint.Categories[0], CategoryTranslator.GetCategoriesList(childPaint.Categories[0])));
                },
                paintAction: async () =>
                {
                    await Navigation.PushAsync(new PaintViewScreen(paint: childPaint));
                }
                )
            );
        }
    }

    private void WidgetForEmptyList() 
    {
        Label label = CustomWidgets.CustomText(
                text: "Красок с такими свойствами не найдено :(",
                textColor: CustomColors.TikkurilaRed,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Center
            );

        Label desc = CustomWidgets.CustomText(
            text: "Увы, но ни одна краска не удовлетворяет условиям ваших ответов. " +
            "\r\n\r\nПопробуйте вернуться назад и изменить некоторые ответы",
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Center
        );

        paintsStack.Add(label);
        paintsStack.Add(desc);
    }

}