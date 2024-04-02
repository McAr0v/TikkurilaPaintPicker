using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintsScreens;

public partial class PaintViewScreen : ContentPage
{

    int paintCount = 0;

    // ������� ��� �������� �� �������� ���������
    public delegate Task NavigateToPageDelegate(CategoryEnums categoryEnum);

    // ������� ��� �������� �� �������� ���������
    private async Task OnLabelTapped(CategoryEnums categoryEnum)
    {
        await Navigation.PushAsync(new CategoryPage(categoryEnum, CategoryTranslator.GetCategoriesList(categoryEnum)));
    }

    Frame calcFrame = new Frame
    {
        
        HasShadow = true, // �������� ����
        BackgroundColor = CustomColors.White,
        Padding = new Thickness(20),
        CornerRadius = 10 // ��������� ���������� ����� �� �������
    };

    Button button = new Button() {BackgroundColor = CustomColors.TikkurilaRed, TextColor = CustomColors.White };
    Button whatsappButton = new Button() {BackgroundColor = CustomColors.TikkurilaRed, TextColor = CustomColors.White };

    StackLayout calcStack = new StackLayout() {Spacing = 20 };

    Entry squareEntry = new Entry()
    {
        Keyboard = Keyboard.Numeric,
        Placeholder = "������� �������",
        TextColor = CustomColors.Black
    };

    Button calcButton = new Button() 
    {
        Text = "���������� ���������� ������",
        TextColor = CustomColors.White,
        BackgroundColor = CustomColors.TikkurilaRed
    };

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

        whatsappButton.Clicked += async (sender, args) => await SendWhatsapp(paint.Name);

        GenerateCalc();

        button.Text = "��������� �� ������� �����";

        whatsappButton.Text = "�������� ����� ����� Whatsapp";

        button.Clicked += async (sender, args) => await NavigateToMainPage();

        Title = paint.Name;

        Content = new ScrollView
        {
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Spacing = 20,
                Children =
            {
                new Image
                {
                    Source = $"Images/PaintImages/{paint.Name}.png",
                    Aspect = Aspect.AspectFit,
                    HeightRequest = 300,
                },

                new Label
                {
                    Text = paint.Name,
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold,
                },

                whatsappButton,

                new Label
                {
                    Text = paint.Description,
                },

                calcFrame,

                paint.GetProductOptionsFrame(OnLabelTapped),

                

                button

                // ���� �������������� ��������, ���� ��� ����

            }
            }
        };

    }

    private async Task SendWhatsapp(string paintName)
    {

        string uri = $"https://wa.me/77018039220?text=������������,%20����������%20����%20������%20{paintName}";



        bool supportsUri = await Launcher.Default.CanOpenAsync(uri);
        if (supportsUri)
            await Launcher.Default.OpenAsync(uri);

        else
            await DisplayAlert("������", "�� ����������� ���������� Whatsapp", "OK");

    }

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

        calcStack.Add(squareEntry);

        calcStack.Add(calcButton);

        calcStack.Add(countOfPaint);

        calcFrame.Content = calcStack;
    }

    private async Task NavigateToMainPage()
    {
        await Navigation.PopToRootAsync();

        //var previousPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
        //Navigation.RemovePage(previousPage);
    }

    public string GetCorrectWord(int number)
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

    private async Task GetPaintCountAsync(PaintClass paint)
    {
        if (squareEntry.Text != null && squareEntry.Text != "") 
        {
            if (int.TryParse(squareEntry.Text, out int count))
            {
                if (int.Parse(squareEntry.Text) < 5)
                {
                    paintCount = 1;
                }
                else 
                {
                    paintCount = int.Parse(squareEntry.Text) * 2 / paint.Consumption;
                }
                

                countOfPaint.Text = $"���������: ����� {paintCount} {GetCorrectWord(paintCount)} ������ {paint.Name}";

                
            }
            else 
            {
                await DisplayAlert("������", "�� ����� �� �����!", "OK");
            }
            
        }
        else
        {
            await DisplayAlert("������", "�� �� ����� �������!", "OK");
        }

        SemanticScreenReader.Announce(countOfPaint.Text);
    }
}