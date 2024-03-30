using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum PaintObjectEnum
    {
        Furniture,             // Мебель
        MetalConstructions,    // Металлоконструкции
        Walls,                 // Стены
        Ceilings,              // Потолки
        Doors,                 // Двери
        Windows,               // Окна
        Floors,                // Полы
    }

    public static class PaintObject
    {
        public static string GetPaintObjectName(PaintObjectEnum paintObject) 
        {
            switch (paintObject)
            {
                case PaintObjectEnum.Furniture: return "Мебель";
                case PaintObjectEnum.MetalConstructions: return "Металлоконструкции";
                case PaintObjectEnum.Walls: return "Стены";
                case PaintObjectEnum.Ceilings: return "Потолки";
                case PaintObjectEnum.Doors: return "Двери";
                case PaintObjectEnum.Windows: return "Окна";
                case PaintObjectEnum.Floors: return "Полы";
                default: return "Не найден объект";
            }
        }
    }

}
