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
        Fiberboard, // ДВП
        Chipboard, // ДСП
        Osb // OSB
    }

    public static class PaintMaterial 
    {
        public static bool CheckPaintMaterial(PaintClass paint, PaintMaterialEnum paintMaterial)
        {
            foreach (PaintMaterialEnum materialEnum in paint.Materials)
            {
                if (materialEnum == paintMaterial)
                {
                    return true;
                }
            }

            return false;

        }
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
                case PaintMaterialEnum.Fiberboard: return "ДВП";
                case PaintMaterialEnum.Chipboard: return "ДСП";
                case PaintMaterialEnum.Osb: return "ОСБ-плиты";
                default: return "Такого материала не найдено";
            }
        }

        public static List<PaintMaterialEnum> GetMaterialList(PaintLocationEnum location) 
        {
            switch (location) 
            {
                case PaintLocationEnum.Indoor: return new List<PaintMaterialEnum> 
                {
                    PaintMaterialEnum.Wood,
                    PaintMaterialEnum.Metal,
                    PaintMaterialEnum.Plastic,
                    PaintMaterialEnum.Plasterboard,
                    PaintMaterialEnum.PlasteredSurface,
                    PaintMaterialEnum.Concrete,
                    PaintMaterialEnum.Brick,
                    PaintMaterialEnum.Ceramic,
                    PaintMaterialEnum.Fiberboard,
                    PaintMaterialEnum.Chipboard,
                    PaintMaterialEnum.Osb
                };

                case PaintLocationEnum.Outdoor:
                    return new List<PaintMaterialEnum>
                {
                    PaintMaterialEnum.Wood,
                    PaintMaterialEnum.Metal,
                    PaintMaterialEnum.Plastic,
                    PaintMaterialEnum.PlasteredSurface,
                    PaintMaterialEnum.Concrete,
                    PaintMaterialEnum.Brick,
                    PaintMaterialEnum.Osb
                };

                default: return new List<PaintMaterialEnum> { };
            }
        }
    }
}
