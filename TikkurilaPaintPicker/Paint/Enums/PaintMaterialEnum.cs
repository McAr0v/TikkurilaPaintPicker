using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum PaintMaterialEnum
    {
        Wood, // Дерево
        Metal, // Металл
        Plastic, // Пластик
        Plasterboard, // Гипсокартон
        PlasteredSurface, // Оштукатуренные поверхности
        Concrete, // Бетон
        Brick, // Кирпич
        Ceramic, // Керамическая плитка
    }

    public static class PaintMaterial 
    {
        public static string GetPaintMaterialName(PaintMaterialEnum paintMaterial) 
        {
            switch (paintMaterial) 
            {
                case PaintMaterialEnum.Wood: return "Дерево";
                case PaintMaterialEnum.Metal: return "Металл";
                case PaintMaterialEnum.Plastic: return "Пластик";
                case PaintMaterialEnum.Plasterboard: return "Гипсокартон";
                case PaintMaterialEnum.PlasteredSurface: return "Оштукатуренные поверхности";
                case PaintMaterialEnum.Concrete: return "Бетон";
                case PaintMaterialEnum.Brick: return "Кирпич";
                case PaintMaterialEnum.Ceramic: return "Керамическая плитка";
                default: return "Такого материала не найдено";
            }
        }
    }
}
