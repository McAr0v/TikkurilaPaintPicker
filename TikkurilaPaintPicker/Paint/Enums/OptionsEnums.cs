using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum OptionsEnums 
    {
        PaintColors,
        PaintGloss,
        PaintLocation,
        PaintMaterials,
        PaintObjects,
        PaintThinner,
        PaintConsumption,
        PaintCategories
    }


    public static class OptionsClass 
    {
        public static string GetOptionsName(OptionsEnums option)
        {
            switch (option) 
            {
                case OptionsEnums.PaintColors: return "Цвета";
                case OptionsEnums.PaintGloss: return "Блеск";
                case OptionsEnums.PaintLocation: return "Область применения";
                case OptionsEnums.PaintMaterials: return "Поверхности для окраски";
                case OptionsEnums.PaintObjects: return "Объекты окраски";
                case OptionsEnums.PaintThinner: return "Растворитель";
                case OptionsEnums.PaintConsumption: return "Расход";
                case OptionsEnums.PaintCategories: return "Категория";
                default: return "Опция не найдена";
            }
        }
    }

}
