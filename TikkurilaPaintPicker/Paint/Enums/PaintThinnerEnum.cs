
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum PaintThinnerEnum
    {
        Water,
        Solvent1031,
        Solvent1050
    }

    public static class PaintThinner 
    {
        public static string getThinnerName(PaintThinnerEnum thinner)
        {
            switch (thinner) 
            {
                case PaintThinnerEnum.Water: return "Вода";
                case PaintThinnerEnum.Solvent1031: return "Растворитель 1031";
                case PaintThinnerEnum.Solvent1050: return "Растворитель 1050";
                default: return "Нет такого растворителя";
            }
        }
    }
}
