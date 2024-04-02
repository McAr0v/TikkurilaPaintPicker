using TikkurilaPaintPicker.Paint;

namespace TikkurilaPaintPicker.Design.Screens.PaintPickerScreens.PaintLayers
{

    /// <summary>
    /// enum'ы для PaintPicker'а. Определяют, какой вопрос отображать
    /// на текущем экране
    /// </summary>
    public enum PaintLayerEnum
    {
        NotChosen,     // Не выбрано
        LocationEnum,  // Локация
        ObjectEnum,    // Объекты
        MaterialEnum,  // Материалы
        ColorsEnum,    // Цвета
        GlossEnum,     // Блеск
        WaterbornEnum, // Разбавитель
        Finish         // Завершающий этап
    }

    /// <summary>
    /// Класс для хранения функций, связынных с 
    /// enum PaintLayerEnum
    /// </summary>
    public static class PaintLayer
    {

        /// <summary>
        /// Функция получения вопроса для PaintPicker'а
        /// в зависимости от переданного enum
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public static string GetAnswer(PaintLayerEnum layer)
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

        /// <summary>
        /// Функция получения заголовка страницы PaintPicker'а
        /// в зависимости от переданного enum
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция для получения enum следующего экрана в PaintPicker
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция проверки - выбрал ли пользователь 
        /// какой либо ответ на странице PaintPicker'а.
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="paint"></param>
        /// <returns></returns>
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
