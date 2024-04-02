
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

    Button catalogButton = CustomWidgets.CustomButton("������� � ������� ������ >>", ButtonState.Secondary);
    Button backButton = CustomWidgets.CustomButton("<< ��������� ����� � �������� ������", ButtonState.Secondary);
    Button mainPageButton = CustomWidgets.CustomButton("<< ��������� �� ������� �����", ButtonState.Primary);

    List<PaintClass> paintsResultList = new List<PaintClass>();

    PaintRepository paintRepository = new PaintRepository();

    public PickerResultPage(PaintClass paint)
	{
		InitializeComponent();

        backButton.Clicked += async (sender, args) => await Navigation.PopAsync();
        mainPageButton.Clicked += async (sender, args) => await Navigation.PopToRootAsync();
        mainPageButton.Margin = new Thickness(0, 20, 0, 0);
        catalogButton.Clicked += async (sender, args) => await Navigation.PushAsync(new CatalogScreen());

        // �������� ������ ������, ��������������� �������� ������� �� ������
        paintsResultList = paintRepository.GetPaintsListFromPickerResult(paint);

        // ��������� ������ � �������� �� ������� � ������
        pageStack.Add(paint.GetAllAnswers());


        if (paintsResultList.Count > 0) 
        {
            pageStack.Add
                (
                    CustomWidgets.CustomText
                    (
                        text: $"�� ��������� ��� ��� {GetCountPaintString(paintsResultList.Count)}:",
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

        // ��������� � ���� �������� ������ ��� ����� ��� ������ �� �������
        pageStack.Add(paintsStack);

        // ��������� ����� �������� ������
        pageStack.Add(backButton);
        pageStack.Add(mainPageButton);
        pageStack.Add(catalogButton);

        // ����������� ���� �������� � ScrollStack
        primaryScrollForPage.Content = pageStack;

        // ������������� � �������� �������� ��� �������������� ����
        Content = primaryScrollForPage;

        // ��������� ��������
        Title = "��������� �������";

    }

    private string GetCountPaintString(int count) 
    {
        // ��� �����, �������������� �� 11, 12, 13 � 14, ������ ���������� ����� "������"
        if (count % 100 >= 11 && count % 100 <= 14)
        {
            return $"{count} ������";
        }

        // ��� ��������� ����� ���������� ������� ���������
        switch (count % 10)
        {
            case 1:
                return $"{count} ������";
            case 2:
            case 3:
            case 4:
                return $"{count} ������";
            default:
                return $"{count} ������";
        }
    }

    private void AddAllPaints()
    {
        // ��� ������ ������ �� ������ ���������� ������ 
        // � ��������� � paintsStack

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
                text: "������ � ������ ���������� �� ������� :(",
                textColor: CustomColors.TikkurilaRed,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Center
            );

        Label desc = CustomWidgets.CustomText(
            text: "���, �� �� ���� ������ �� ������������� �������� ����� �������. " +
            "\r\n\r\n���������� ��������� ����� � �������� ��������� ������",
            textColor: CustomColors.Black,
            textState: TextState.BodySmall,
            horizontalAligment: TextAlignment.Center
        );

        paintsStack.Add(label);
        paintsStack.Add(desc);
    }

}