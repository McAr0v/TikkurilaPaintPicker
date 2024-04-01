using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum PaintColorEnum
    {
        LightShades,
        DarkShades,
        White,
        NoColor
    }

    public static class PaintColor
    {

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

        public static string GetPaintColorName(PaintColorEnum color)
        {
            switch (color) 
            {
                case PaintColorEnum.LightShades: return "Колеровка в светлые оттенки";
                case PaintColorEnum.DarkShades: return "Колеровка в темные оттенки";
                case PaintColorEnum.White: return "Белый";
                case PaintColorEnum.NoColor: return "Прозрачный цвет или колеровка в полупрозрачный древесный оттенок";
                default: return "Цвет не найден";
            }
        }

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
