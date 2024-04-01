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

        public static bool CheckPaintGloss(PaintClass paint, PaintGlossEnum paintGloss)
        {

            foreach (PaintGlossEnum paintGlossEnum in paint.Gloss)
            {
                if (paintGloss == PaintGlossEnum.Matt) 
                {
                    bool tempResult = CheckMattGloss(paintGlossEnum);
                    if (tempResult) { return tempResult; }
                } 
                else 
                {
                    bool tempResult = CheckNotMattGloss(paintGlossEnum);
                    if (tempResult) { return tempResult; }
                }

            }

            return false;

        }

        public static bool CheckMattGloss(PaintGlossEnum paintGloss)
        {
            return paintGloss == PaintGlossEnum.FullMatt || paintGloss == PaintGlossEnum.Matt || paintGloss == PaintGlossEnum.SemiMatte;
        }

        public static bool CheckNotMattGloss(PaintGlossEnum paintGloss)
        {
            return paintGloss == PaintGlossEnum.SemiGloss || paintGloss == PaintGlossEnum.Gloss || paintGloss == PaintGlossEnum.FullGloss;
        }

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
