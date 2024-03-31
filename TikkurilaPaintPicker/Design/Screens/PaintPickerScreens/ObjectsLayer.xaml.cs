using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens;

public partial class ObjectsLayer : ContentPage
{
	public ObjectsLayer(PaintClass paint)
	{
		InitializeComponent();

		Content = CustomTextWidget.CustomText
			(
				text: PaintLocation.GetPaintLocationString(paint.Locations[0]),
				textState: TextState.BodySmall,
				textColor: CustomColors.Black
			);
	}
}