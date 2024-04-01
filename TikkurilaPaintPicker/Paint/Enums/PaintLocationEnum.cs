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
        Outdoor
    }

    public static class PaintLocation 
    {

        public static bool CheckPaintLocation(PaintClass paint, PaintLocationEnum paintLocation)
        {
            foreach (PaintLocationEnum locationEnum in paint.Locations)
            {
                if (locationEnum == paintLocation)
                {
                    return true;
                }
            }

            return false;

        }

        public static string GetPaintLocationString(PaintLocationEnum location) 
        {
            switch (location) 
            {
                case PaintLocationEnum.Indoor: return "Внутри помещений";
                case PaintLocationEnum.Outdoor: return "Снаружи помещений";
                default: return "Не найдено";
            }
        }
    }
}
