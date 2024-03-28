using TikkurilaPaintPicker.Paint;

namespace TikkurilaPaintPicker;

public partial class SecondPage : ContentPage
{
	public SecondPage(PaintClass paint)
	{
		InitializeComponent();

		Title = paint.Name;

		Content = new StackLayout 
		{
			Children = 
			{
				new Label
				{
					Text = paint.Name,
				},

			}
		};
	}
}