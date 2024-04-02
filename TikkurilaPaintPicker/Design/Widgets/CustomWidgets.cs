using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;

namespace TikkurilaPaintPicker.Design.Widgets
{
    public static class CustomWidgets
    {
        public static Button CustomButton(string text, ButtonState buttonState)
        {
            return new Button() 
            { 
                BackgroundColor = SwitchButtonColor(buttonState), 
                Text = text, 
                TextColor = SwitchButtonTextColor(buttonState)
            };
        }

        public static Label CustomText(
            string text,
            Color textColor,
            TextState textState,
            TextDecorations underline = TextDecorations.None,
            TextAlignment horizontalAligment = TextAlignment.Start,
            Thickness padding = new Thickness()
            )
        {
            return new Label
            {
                Text = text,
                TextColor = textColor,
                FontAttributes = GetFontWeight(state: textState),
                TextDecorations = underline,
                HorizontalTextAlignment = horizontalAligment,
                FontSize = GetFontSize(state: textState),
                Padding = padding
            };
        }

        private static FontAttributes GetFontWeight(TextState state)
        {
            switch (state)
            {
                case TextState.HeadlineBig:
                case TextState.HeadlineMedium:
                case TextState.HeadlineSmall:
                    return FontAttributes.Bold;
                default:
                    return FontAttributes.None;
            }
        }

        private static double GetFontSize(TextState state)
        {
            switch (state)
            {
                case TextState.HeadlineBig:
                    return 45;
                case TextState.HeadlineMedium:
                    return 20;
                case TextState.HeadlineSmall:
                    return 16;
                case TextState.BodyBig:
                    return 18;
                case TextState.BodyMedium:
                    return 16;
                case TextState.BodySmall:
                    return 14;
                case TextState.DescBig:
                    return 14;
                case TextState.DescMedium:
                    return 12;
                case TextState.DescSmall:
                    return 10;
                default:
                    return 16; // Значение по умолчанию
            }
        }

        public static RadioButton CustomRadioButton(string text)
        {
            return new RadioButton
            {
                TextColor = CustomColors.Black,
                Content = text,
                IsChecked = false,
                BorderColor = CustomColors.Black,
                Margin = 0,
                Padding = 0
            };
        }

        private static Color SwitchButtonColor(ButtonState buttonState)
        {
            switch (buttonState) 
            {
                case ButtonState.Primary: return CustomColors.TikkurilaRed;
                case ButtonState.Secondary: return CustomColors.GreyLight;
                default: return CustomColors.TikkurilaRed;
            }
        }

        private static Color SwitchButtonTextColor(ButtonState buttonState)
        {
            switch (buttonState)
            {
                case ButtonState.Primary: return CustomColors.White;
                case ButtonState.Secondary: return CustomColors.Black;
                default: return CustomColors.White;
            }
        }
    }
}
