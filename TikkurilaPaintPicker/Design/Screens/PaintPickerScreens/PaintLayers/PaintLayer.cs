using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Paint;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens.PaintLayers
{

    public enum PaintLayerEnum
    {
        NotChosen,
        LocationEnum,
        ObjectEnum,
        MaterialEnum,
        ColorsEnum,
        GlossEnum,
        WaterbornEnum,
        Finish
    }
    public static class PaintLayer
    {
        public static string GetHeadline(PaintLayerEnum layer)
        {
            switch (layer) 
            {
                case PaintLayerEnum.LocationEnum: return "Где будете красить?";
                case PaintLayerEnum.ObjectEnum: return "Что собираетесь красить?";
                case PaintLayerEnum.MaterialEnum: return "Какой материал будете окрашивать?";
                case PaintLayerEnum.ColorsEnum: return "Какой цвет вы планируете выбрать?";
                case PaintLayerEnum.WaterbornEnum: return "Краска должна быть без запаха?";
                case PaintLayerEnum.GlossEnum: return "Какой предпочитаете блеск?";
                default: return "Не найден заголовок";
            }
        }

        public static string GetPageHeadline(PaintLayerEnum layer)
        {
            string result = "Подборщик красок - ";
            
            switch (layer)
            {
                case PaintLayerEnum.LocationEnum: 
                    {
                        result += "Шаг 1"; break;
                    } 
                
                case PaintLayerEnum.MaterialEnum:
                    {
                        result += "Шаг 2"; break;
                    }

                case PaintLayerEnum.ObjectEnum:
                    {
                        result += "Шаг 3"; break;
                    }

                case PaintLayerEnum.ColorsEnum:
                    {
                        result += "Шаг 4"; break;
                    }
                
                case PaintLayerEnum.GlossEnum:
                    {
                        result += "Шаг 5"; break;
                    }

                case PaintLayerEnum.WaterbornEnum:
                    {
                        result += "Шаг 6"; break;
                    }

                default:
                    {
                        result += ""; break;
                    }
            }

            return result;
        }

        public static PaintLayerEnum GetNextPage(PaintLayerEnum layer)
        {
            switch (layer)
            {
                case PaintLayerEnum.LocationEnum: return PaintLayerEnum.MaterialEnum;
                case PaintLayerEnum.MaterialEnum: return PaintLayerEnum.ObjectEnum;
                case PaintLayerEnum.ObjectEnum: return PaintLayerEnum.ColorsEnum;
                case PaintLayerEnum.ColorsEnum: return PaintLayerEnum.GlossEnum;
                case PaintLayerEnum.GlossEnum: return PaintLayerEnum.WaterbornEnum;
                case PaintLayerEnum.WaterbornEnum: return PaintLayerEnum.Finish;
                default: return PaintLayerEnum.NotChosen;
            }
        }

        public static bool CheckAnswer(PaintLayerEnum layer, PaintClass paint)
        {
            switch (layer)
            {
                case PaintLayerEnum.LocationEnum: return paint.CheckLocations();
                case PaintLayerEnum.ObjectEnum: return paint.CheckObjects();
                case PaintLayerEnum.MaterialEnum: return paint.CheckMaterials();
                case PaintLayerEnum.ColorsEnum: return paint.CheckColors();
                case PaintLayerEnum.WaterbornEnum: return paint.CheckThinner();
                case PaintLayerEnum.GlossEnum: return paint.CheckGloss();
                default: return false;
            }
        }

    }

    

}
