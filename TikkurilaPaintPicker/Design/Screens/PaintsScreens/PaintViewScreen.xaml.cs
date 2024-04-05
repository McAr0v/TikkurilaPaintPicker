using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintsScreens;

public partial class PaintViewScreen : ContentPage
{
    // ���������� ��� �������� �������� ������������
    // ���������� ������
    int paintCount = 0;

    // ������� ��� �������� �� �������� ���������
    public delegate Task NavigateToPageDelegate(CategoryEnums categoryEnum);

    // ������� ��� �������� �� �������� ���������
    private async Task OnLabelTapped(CategoryEnums categoryEnum)
    {
        await Navigation.PushAsync(new CategoryPage(categoryEnum, CategoryClass.GetChildrenCategoriesList(categoryEnum)));
    }

    // ������ ��� ��� ������������

    Frame calcFrame = new Frame
    {
        
        HasShadow = true, 
        BackgroundColor = CustomColors.White,
        Padding = new Thickness(20),
        CornerRadius = 10 
    };

    // ����� ���� ��������, ���� ���������� ��� ��������

    StackLayout pageStack = new StackLayout() 
    {
        Margin = new Thickness(20),
        Spacing = 20,
    };

    // �������������� ��������, ����� ������������ �����
    // �� ���������

    ScrollView pageScroll = new ScrollView();

    // ������

    Button buttonToMainPage = CustomWidgets.CustomButton("��������� �� ������� �����", ButtonState.Primary);
    Button calcButton = CustomWidgets.CustomButton("���������� ���������� ������", ButtonState.Primary);

    // ���� ��� ������������

    StackLayout calcStack = new StackLayout() {Spacing = 20 };

    // ����� ����� ��� ������������, ����� ������ �������

    Entry squareEntry = new Entry()
    {
        Keyboard = Keyboard.Numeric,
        Placeholder = "������� �������",
        TextColor = CustomColors.Black
    };

    // ����� � ������������ ���������� ������������

    Label countOfPaint = CustomWidgets.CustomText
            (
                text: "���������:",
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
                horizontalAligment: TextAlignment.Start
            );

	public PaintViewScreen(PaintClass paint)
	{
		InitializeComponent();

        calcButton.Clicked += async (sender, args) => await GetPaintCountAsync(paint);
        buttonToMainPage.Clicked += async (sender, args) => await Navigation.PopToRootAsync();

        // ���������� �����������

        GenerateCalc();

        // ��������� ���� ������� �������� � pageStack
        AddContentToPageStack(inputPaint:  paint);

        // �������� pageStack � �������������� ��������
        pageScroll.Content = pageStack;

        // ������������� �������������� �������� � ��������
        // ��������� �������� ��������
        Content = pageScroll;

        Title = paint.Name;

    }


    /// <summary>
    /// ������� ���������� ����� �������� �������� � pageStack. 
    /// ��������� �� ���� ������ inputPaint
    /// </summary>
    /// <param name="inputPaint"></param>
    private void AddContentToPageStack(PaintClass inputPaint)
    {
        Image image = new Image
        {
            Source = $"Images/PaintImages/{inputPaint.GenerateImageName()}.png",
            Aspect = Aspect.AspectFit,
            HeightRequest = 300,
        };

        Label paintName = CustomWidgets.CustomText
            (
                text: inputPaint.Name,
                textColor: CustomColors.Black,
                textState: TextState.HeadlineMedium
            );

        Label paintDesc = CustomWidgets.CustomText
            (
                text: inputPaint.Description,
                textColor: CustomColors.Graphite,
                textState: TextState.BodySmall
            );

        pageStack.Add(image);
        pageStack.Add(paintName);
        pageStack.Add(paintDesc);
        pageStack.Add(calcFrame);

        // ���������� � ��������� ������ ������� ������
        pageStack.Add(inputPaint.GetProductOptionsFrame(OnLabelTapped));
        
        pageStack.Add(buttonToMainPage);

    }

    /// <summary>
    /// ������� �������� ��������� � ������ � �������
    /// </summary>
    /// <param name="paintName"></param>
    /// <returns></returns>
    private async Task SendWhatsapp(string paintName)
    {

        string uri = $"https://wa.me/77018039220?text=������������,%20����������%20����%20������%20{paintName}";

        bool supportsUri = await Launcher.Default.CanOpenAsync(uri);
        if (supportsUri)
            await Launcher.Default.OpenAsync(uri);

        else
            await DisplayAlert("������", "�� ����������� ���������� Whatsapp", "OK");

    }


    /// <summary>
    /// ������� ��������� ����������� ������������
    /// </summary>
    private void GenerateCalc() 
    {
         
        StackLayout headlineDesc = new StackLayout() { Spacing = 5 };

        headlineDesc.Add(
            CustomWidgets.CustomText(
                text: "����������� �������",
                textColor: CustomColors.Black,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Start
                )
            );

        headlineDesc.Add(
            CustomWidgets.CustomText(
                text: "������� ���� ������� ����������� � ������� ������ '����������'. ",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start
                )
            );

        calcStack.Add(headlineDesc);

        // ��������� ����� ����� �������
        calcStack.Add(squareEntry);

        calcStack.Add(calcButton);

        // ��������� ��������� ������ ������
        calcStack.Add(countOfPaint);

        // ��������� �� Frame ������������ ��� �������
        calcFrame.Content = calcStack;
    }

    /// <summary>
    /// ������� ��� ����������� ��������� ����� "����" � �����������
    /// �� ���������� ������
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private string GetCorrectWord(int number)
    {
        if (number % 10 == 1 && number % 100 != 11)
        {
            return "����";
        }
        else if ((number % 10 == 2 || number % 10 == 3 || number % 10 == 4) && (number % 100 != 12 && number % 100 != 13 && number % 100 != 14))
        {
            return "�����";
        }
        else
        {
            return "������";
        }
    }

    /// <summary>
    /// ������� ���������� ������������ ���������� ������
    /// </summary>
    /// <param name="paint"></param>
    /// <returns></returns>
    private async Task GetPaintCountAsync(PaintClass paint)
    {
        if (squareEntry.Text != null && squareEntry.Text != "") 
        {
            // ��������� - ���� �� ������������ ����� ��� ���

            if (int.TryParse(squareEntry.Text, out int count))
            {
                // ���� ������� ������ 5 ��.�, �� �������������
                // ����������� ����� ������ - 1�
                if (int.Parse(squareEntry.Text) < 5)
                {
                    paintCount = 1;
                }
                // ����� ��������� �� �������
                // ������� �������� �� 2 ���� � ����� �� ������
                // �� 2 ���� ��������, ������ ��� �� �������� ������� ���������� ����� ����������� � 2 ����
                else 
                {
                    paintCount = int.Parse(squareEntry.Text) * 2 / paint.Consumption;
                }
                
                // ������������� ��������� � ����������
                countOfPaint.Text = $"���������: ����� {paintCount} {GetCorrectWord(paintCount)} ������ {paint.Name}";

            }

            // ���� ��� �� ���� ������ �� �����, �� ������� ���������
            
            else 
            {
                await DisplayAlert("������", "�� ����� �� �����!", "OK");
            }
            
        }
        else
        {
            await DisplayAlert("������", "�� �� ����� �������!", "OK");
        }

        // �������������� ���������� � ����������� ������������
        SemanticScreenReader.Announce(countOfPaint.Text);
    }
}