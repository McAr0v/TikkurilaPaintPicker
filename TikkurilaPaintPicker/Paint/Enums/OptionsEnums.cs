namespace TikkurilaPaintPicker.Paint.Enums
{
    /// <summary>
    /// enum опций красок
    /// </summary>
    public enum OptionsEnums 
    {
        PaintColors,
        PaintGloss,
        PaintLocation,
        PaintMaterials,
        PaintObjects,
        PaintThinner,
        PaintConsumption,
        PaintCategories
    }

    /// <summary>
    /// Класс, хранящий функции, связанные с опциями красок
    /// </summary>
    public static class OptionsClass 
    {
        /// <summary>
        /// Функция получения названия enum'а на русском языке
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public static string GetOptionsName(OptionsEnums option)
        {
            switch (option) 
            {
                case OptionsEnums.PaintColors: return "Цвета";
                case OptionsEnums.PaintGloss: return "Блеск";
                case OptionsEnums.PaintLocation: return "Область применения";
                case OptionsEnums.PaintMaterials: return "Поверхности для окраски";
                case OptionsEnums.PaintObjects: return "Объекты окраски";
                case OptionsEnums.PaintThinner: return "Растворитель";
                case OptionsEnums.PaintConsumption: return "Расход";
                case OptionsEnums.PaintCategories: return "Категория";
                default: return "Опция не найдена";
            }
        }
    }

}
