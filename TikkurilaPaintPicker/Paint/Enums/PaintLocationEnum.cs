namespace TikkurilaPaintPicker.Paint.Enums
{
    /// <summary>
    /// enum, хранящий информацию о том, где будет производиться окраска -
    /// снаружи помещения или внутри
    /// </summary>
    public enum PaintLocationEnum
    {
        Indoor,
        Outdoor
    }


    /// <summary>
    /// Класс, хранящий функции связанные с локацией окраски
    /// </summary>
    public static class PaintLocation 
    {

        /// <summary>
        /// Функция проверки - содержит ли краска необходимую локацию
        /// </summary>
        /// <param name="paint"></param>
        /// <param name="paintLocation"></param>
        /// <returns></returns>
        public static bool CheckPaintLocation(PaintClass paint, PaintLocationEnum paintLocation)
        {
            foreach (PaintLocationEnum locationEnum in paint.Locations)
            {
                if (locationEnum == paintLocation)
                {
                    return true;
                }
            }

            return false;

        }

        /// <summary>
        /// Функция получения названия локации на русском языке
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static string GetPaintLocationString(PaintLocationEnum location) 
        {
            switch (location) 
            {
                case PaintLocationEnum.Indoor: return "Внутри помещений";
                case PaintLocationEnum.Outdoor: return "Снаружи помещений";
                default: return "Не найдено";
            }
        }
    }
}
