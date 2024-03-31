using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Design.Font
{
    public static class CustomTextWidget
    {
        public static Label CustomText(
            string text, 
            Color textColor, 
            TextState textState,
            TextDecorations underline = TextDecorations.None,
            TextAlignment horizontalAligment = TextAlignment.Start
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
    }
}
