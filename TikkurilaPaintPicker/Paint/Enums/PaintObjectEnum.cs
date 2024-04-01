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
        Constructions,         // Строительные и декоративные конструкции
        WallsInDryRooms,       // Стены в сухих помещениях
        WallsInWetRooms,       // Стены во влажных помещениях
        CeilingsInDryRooms,    // Потолки в сухих помещениях
        CeilingsInWetRooms,    // Потолки во влажных помещениях
        Doors,                 // Двери
        Windows,               // Окна
        Floors,                // Полы
        SkirtingBoards,        // Плинтусы
        Fassade,               // Фасад здания
        Fences,                // Заборы
        Roofs,                 // Крыши
    }



    public static class PaintObject
    {

        public static bool CheckPaintObject(PaintClass paint,  PaintObjectEnum paintObject)
        {
            foreach (PaintObjectEnum objectEnum in paint.Objects)
            {
                if (objectEnum == paintObject)
                {
                    return true; 
                }
            }

            return false;

        }

        public static string GetPaintObjectName(PaintObjectEnum paintObject) 
        {
            switch (paintObject)
            {
                case PaintObjectEnum.Furniture: return "Мебель";
                case PaintObjectEnum.Constructions: return "Строительные и декоративные конструкции";
                case PaintObjectEnum.WallsInDryRooms: return "Стены в сухих помещениях";
                case PaintObjectEnum.WallsInWetRooms: return "Стены во влажных помещениях";
                case PaintObjectEnum.CeilingsInDryRooms: return "Потолки в сухих помещениях";
                case PaintObjectEnum.CeilingsInWetRooms: return "Потолки во влажных помещениях";
                case PaintObjectEnum.Doors: return "Двери";
                case PaintObjectEnum.Windows: return "Окна";
                case PaintObjectEnum.Floors: return "Полы";
                case PaintObjectEnum.SkirtingBoards: return "Плинтусы";
                case PaintObjectEnum.Fassade: return "Фасад здания";
                case PaintObjectEnum.Fences: return "Заборы";
                case PaintObjectEnum.Roofs: return "Крыши";
                default: return "Не найден объект";
            }
        }

        public static List<PaintObjectEnum> GetPaintObjectList(PaintMaterialEnum paintMaterial, PaintLocationEnum paintLocation) 
        {
            // Если внутри помещения
            if (paintLocation == PaintLocationEnum.Indoor)
            {
                switch (paintMaterial) 
                {
                    case PaintMaterialEnum.Wood: return new List<PaintObjectEnum> 
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.SkirtingBoards
                    };

                    case PaintMaterialEnum.Metal:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors
                    };

                    case PaintMaterialEnum.Plastic:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.SkirtingBoards
                    };

                    case PaintMaterialEnum.Plasterboard:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    };

                    case PaintMaterialEnum.PlasteredSurface:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    };

                    case PaintMaterialEnum.Concrete:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Floors
                    };

                    case PaintMaterialEnum.Brick:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    };

                    case PaintMaterialEnum.Ceramic:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    };

                    case PaintMaterialEnum.Fiberboard:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Doors
                    };

                    case PaintMaterialEnum.Chipboard:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Floors
                    };

                    case PaintMaterialEnum.Osb:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Floors,
                    };

                    default: return new List<PaintObjectEnum> { };

                }
            }
            // Если снаружи помещения
            else
            {
                switch (paintMaterial) 
                {
                    case PaintMaterialEnum.Wood:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Floors
                    };

                    case PaintMaterialEnum.Metal:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Roofs
                    };

                    case PaintMaterialEnum.Plastic:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Windows
                    };
                    case PaintMaterialEnum.PlasteredSurface:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    };
                    case PaintMaterialEnum.Concrete:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    };
                    case PaintMaterialEnum.Brick:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    };
                    case PaintMaterialEnum.Osb:
                        return new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences
                    };
                    default: return new List<PaintObjectEnum> { };
                }
            }
        }
    }

}
