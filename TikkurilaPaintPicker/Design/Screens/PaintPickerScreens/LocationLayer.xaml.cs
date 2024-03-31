using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class LocationLayer : ContentPage
{

	PaintClass paint = PaintClass.GetEmptyPaint();

	StackLayout stack = new StackLayout() { Spacing = 20, Padding = 20};
	StackLayout answersStack = new StackLayout() { Spacing = 5, Padding = 20};

	Button nextButton = new Button() { BackgroundColor = CustomColors.TikkurilaRed, Text = "��������� ���", TextColor = CustomColors.White};
	Button previousButton = new Button() { BackgroundColor = CustomColors.GreyLight, Text = "��������� �����", TextColor = CustomColors.Black};

	Label pageHeadline = CustomTextWidget.CustomText
		(
		text: "��������� ������",
		textColor: CustomColors.Black,
		textState: TextState.HeadlineMedium,
		horizontalAligment: TextAlignment.Center
		);

    Label pageDesc = CustomTextWidget.CustomText
        (
        text: "� ���� ������� �� ������� �������������� ��������� ������, ������ ������� �� ������� �� ������� �������" +
        "\r\n\r\n ������� ��������� � ���� � ������� �� ������ ������!",
        textColor: CustomColors.Black,
        textState: TextState.BodySmall,
        horizontalAligment: TextAlignment.Center
        );

    PaintLocationEnum selectedLocation = PaintLocationEnum.Indoor;

    Picker picker = new Picker();

    public LocationLayer()
	{
		InitializeComponent();

		stack.Add
			(
				new Image
				{
					Source = $"Images/tikkurila_logo.png",
					Aspect = Aspect.AspectFit,
					HeightRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
				}

            );
		stack.Add(pageHeadline);
		stack.Add(pageDesc);

        foreach (PaintLocationEnum location in Enum.GetValues(typeof(PaintLocationEnum)))
        {

            HorizontalStackLayout horizontalStack = new HorizontalStackLayout() { 
                //Spacing = 20,
                VerticalOptions = LayoutOptions.Center,
                //HorizontalOptions = LayoutOptions.Center
            };

            RadioButton radioButton = new RadioButton
            {

                GroupName = "LocationGroup", // ���������� �����������
                IsChecked = false
            };

            radioButton.CheckedChanged += (sender, e) =>
            {
                if (e.Value) // ���� ����������� �������
                {
                    // ��������� ��������� �������� � ����������
                    selectedLocation = location;
                }
            };

            Label radioText = CustomTextWidget.CustomText
            (
                text: PaintLocation.GetPaintLocationString(location),
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
                horizontalAligment: TextAlignment.Center
            );

            radioText.VerticalOptions = LayoutOptions.Center;

            horizontalStack.Add(radioButton);
            horizontalStack.Add(radioText);


            answersStack.Children.Add(horizontalStack);
        }

            stack.Add (answersStack);

            Title = "��������� ������";

		Content = stack;


	}
}