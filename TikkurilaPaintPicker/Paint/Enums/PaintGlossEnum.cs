using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum PaintGlossEnum
    {
        FullMatt,
        Matt,
        SemiMatte,
        SemiGloss,
        Gloss,
        FullGloss
    }

    public static class PaintGloss 
    {
        public static string GetGlossName(PaintGlossEnum gloss) 
        {
            switch (gloss) 
            {
                case PaintGlossEnum.FullMatt: return "Абсолютно матовый";
                case PaintGlossEnum.Matt: return "Матовый";
                case PaintGlossEnum.SemiMatte: return "Полуматовый";
                case PaintGlossEnum.SemiGloss: return "Полуглянцевый";
                case PaintGlossEnum.Gloss: return "Глянцевый";
                case PaintGlossEnum.FullGloss: return "Абсолютно глянцевый";
                default: return "Блеск не найден";
            }
        }
    }
}
