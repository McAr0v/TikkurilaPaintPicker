using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum PaintLocationEnum
    {
        Indoor,
        Outdoor,
        ForWetRooms,
        ForDryRooms
    }

    public static class PaintLocation 
    {
        public static string GetPaintLocationString(PaintLocationEnum location) 
        {
            switch (location) 
            {
                case PaintLocationEnum.Indoor: return "Внутри помещений";
                case PaintLocationEnum.Outdoor: return "Снаружи помещений";
                case PaintLocationEnum.ForWetRooms: return "Для влажных помещений";
                case PaintLocationEnum.ForDryRooms: return "Для сухих помещений";
                default: return "Не найдено";
            }
        }
    }
}
