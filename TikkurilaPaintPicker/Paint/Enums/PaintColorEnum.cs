namespace TikkurilaPaintPicker.Paint.Enums
{

    /// <summary>
    /// enum видов цветов красок
    /// </summary>
    public enum PaintColorEnum
    {
        LightShades,
        DarkShades,
        White,
        NoColor,
        Transparent
    }

    /// <summary>
    /// Класс, хранящий функции цветов красок
    /// </summary>
    public static class PaintColor
    {

        /// <summary>
        /// Функция сравнения - содержит ли краска переданный цвет
        /// </summary>
        /// <param name="paint"></param>
        /// <param name="paintColor"></param>
        /// <returns></returns>
        public static bool CheckPaintColor(PaintClass paint, PaintColorEnum paintColor)
        {
            foreach (PaintColorEnum paintColorEnum in paint.Colors)
            {
                if (paintColorEnum == paintColor)
                {
                    return true;
                }
            }

            return false;

        }

        /// <summary>
        /// Функция получения названия цвета на русском языке
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>

        public static string GetPaintColorName(PaintColorEnum color)
        {
            switch (color) 
            {
                case PaintColorEnum.LightShades: return "Колеровка в светлые оттенки";
                case PaintColorEnum.DarkShades: return "Колеровка в темные оттенки";
                case PaintColorEnum.White: return "Белый";
                case PaintColorEnum.NoColor: return "Прозрачный цвет или колеровка в полупрозрачный древесный оттенок";
                case PaintColorEnum.Transparent: return "Прозрачный";
                default: return "Цвет не найден";
            }
        }

        /// <summary>
        /// Функция получения ответа о цвете в PaintPicker'е
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string GetPaintColorAnswer(PaintColorEnum color)
        {
            switch (color)
            {
                case PaintColorEnum.LightShades: return "Нужна краска светлого оттенка";
                case PaintColorEnum.DarkShades: return "Нужна краска темного или яркого оттенка";
                case PaintColorEnum.White: return "Нужна белая краска";
                case PaintColorEnum.NoColor: return "Нужен лак/пропитка прозрачного или древесного оттенка";
                default: return "Цвет не найден";
            }
        }
    }
}
