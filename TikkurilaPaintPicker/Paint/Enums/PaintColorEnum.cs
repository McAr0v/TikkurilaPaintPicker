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
        Blue,
        Red
    }

    public static class PaintColor
    {
        public static string GetPaintColorName(PaintColorEnum color)
        {
            switch (color) 
            {
                case PaintColorEnum.LightShades: return "Колеровка в светлые оттенки";
                case PaintColorEnum.DarkShades: return "Колеровка в темные оттенки";
                case PaintColorEnum.White: return "Белый";
                case PaintColorEnum.Blue: return "Синий";
                case PaintColorEnum.Red: return "Красный";
                default: return "Цвет не найден";
            }
        }
    }
}
