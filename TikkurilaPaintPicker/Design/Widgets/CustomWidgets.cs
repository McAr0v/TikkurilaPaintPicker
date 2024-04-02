using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;

namespace TikkurilaPaintPicker.Design.Widgets
{
    /// <summary>
    /// Класс для хранения кастомных виджетов
    /// </summary>
    public static class CustomWidgets
    {
        /// <summary>
        /// Виджет кастомной кнопки
        /// </summary>
        /// <param name="text"></param>
        /// <param name="buttonState"></param>
        /// <returns></returns>
        public static Button CustomButton(string text, ButtonState buttonState)
        {
            return new Button() 
            { 
                BackgroundColor = SwitchButtonColor(buttonState), 
                Text = text, 
                TextColor = SwitchButtonTextColor(buttonState)
            };
        }

        /// <summary>
        /// Виджет кастомного текста
        /// </summary>
        /// <param name="text">Отображаемый текст</param>
        /// <param name="textColor">Цвет текста</param>
        /// <param name="textState">Определяет стиль текста - заголовок, обычный текст, подпись</param>
        /// <param name="underline">Подчеркивание текста</param>
        /// <param name="horizontalAligment">Выравнивание по горизонтали</param>
        /// <param name="padding">Отступы</param>
        /// <returns></returns>

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

        /// <summary>
        /// Функция для получения веса шрифта в зависимости от 
        /// типа текста - заголовок, обычный текст, подпись
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция для получения размера шрифта в зависимости
        /// от типа текста
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция для отрисовки виджета Радио-кнопки
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения цвета кнопки в зависимости
        /// от состояния кнопки
        /// </summary>
        /// <param name="buttonState"></param>
        /// <returns></returns>
        private static Color SwitchButtonColor(ButtonState buttonState)
        {
            switch (buttonState) 
            {
                case ButtonState.Primary: return CustomColors.TikkurilaRed;
                case ButtonState.Secondary: return CustomColors.GreyLight;
                default: return CustomColors.TikkurilaRed;
            }
        }

        /// <summary>
        /// Функция получения цвета текста кнопки в зависимости
        /// от состояния кнопки
        /// </summary>
        /// <param name="buttonState"></param>
        /// <returns></returns>
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
