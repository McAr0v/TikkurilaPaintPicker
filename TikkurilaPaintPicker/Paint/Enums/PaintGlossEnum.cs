using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    /// <summary>
    /// enum, хранящий виды блеска краски
    /// </summary>
    public enum PaintGlossEnum
    {
        FullMatt,
        Matt,
        SemiMatte,
        SemiGloss,
        Gloss,
        FullGloss
    }

    /// <summary>
    /// Класс, хранящий функции, связанные с блеском краски
    /// </summary>
    public static class PaintGloss 
    {
        /// <summary>
        /// Функция проверки - имеет ли краска такой же блеск, как переданный в 
        /// функцию. ЗДЕСЬ ЕСТЬ ОСОБЕННОСТЬ - клиенты не знают о существовании 6 степеней блеска, 
        /// для них есть только 2 - матовый и глянцевый. При сравнении мы допускаем, что 
        /// при указании матового блеска, можно так же отобразить абсолютно матовый и полуматовый, так как
        /// визуально они не сильно отличаются от просто матового. Так же по аналогии и с глянцевым блеском.
        /// </summary>
        /// <param name="paint"></param>
        /// <param name="paintGloss"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция проверки - Матовая краска или нет. ЗДЕСЬ ЕСТЬ ОСОБЕННОСТЬ - клиенты не знают о существовании 6 степеней блеска, 
        /// для них есть только 2 - матовый и глянцевый. При сравнении мы допускаем, что 
        /// при указании матового блеска, можно так же отобразить абсолютно матовый и полуматовый, так как
        /// визуально они не сильно отличаются от просто матового. Так же по аналогии и с глянцевым блеском.
        /// </summary>
        /// <param name="paintGloss"></param>
        /// <returns></returns>
        public static bool CheckMattGloss(PaintGlossEnum paintGloss)
        {
            return paintGloss == PaintGlossEnum.FullMatt || paintGloss == PaintGlossEnum.Matt || paintGloss == PaintGlossEnum.SemiMatte;
        }

        /// <summary>
        /// Функция проверки - Глянцевая краска или нет. ЗДЕСЬ ЕСТЬ ОСОБЕННОСТЬ - клиенты не знают о существовании 6 степеней блеска, 
        /// для них есть только 2 - матовый и глянцевый. При сравнении мы допускаем, что 
        /// при указании матового блеска, можно так же отобразить абсолютно матовый и полуматовый, так как
        /// визуально они не сильно отличаются от просто матового. Так же по аналогии и с глянцевым блеском.
        /// </summary>
        /// <param name="paintGloss"></param>
        /// <returns></returns>
        public static bool CheckNotMattGloss(PaintGlossEnum paintGloss)
        {
            return paintGloss == PaintGlossEnum.SemiGloss || paintGloss == PaintGlossEnum.Gloss || paintGloss == PaintGlossEnum.FullGloss;
        }

        /// <summary>
        /// Функция получения названия блеска на русском языке
        /// </summary>
        /// <param name="gloss"></param>
        /// <returns></returns>
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
