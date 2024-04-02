namespace TikkurilaPaintPicker.Paint.Enums
{

    /// <summary>
    /// enum, хранящий варианты растворителей для красок
    /// </summary>
    public enum PaintThinnerEnum
    {
        NotChosen,
        Water,
        Solvent1031,
        Solvent1050
    }

    /// <summary>
    /// Класс, хранящий функции для работы с растворителями красок
    /// </summary>
    public static class PaintThinner 
    {

        /// <summary>
        /// Функция проверки для paintPicker'а в вопросе - Обязательно ли
        /// краска должна быть на водной основе? 
        /// Если растворитель Slovent1050 - то допускается краска как на растворителях, так и на воде.
        /// Если растворитель Water - то допускаются краски только на водной основе
        /// </summary>
        /// <param name="paint"></param>
        /// <param name="paintThinner"></param>
        /// <returns></returns>
        public static bool CheckPaintThinner(PaintClass paint, PaintThinnerEnum paintThinner)
        {
            if (paintThinner == PaintThinnerEnum.Solvent1050) 
            {
                return true;
            } 
            else 
            {
                if (paint.Thinner == PaintThinnerEnum.Water) 
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Функция получения названия растворителя на русском языке
        /// </summary>
        /// <param name="thinner"></param>
        /// <returns></returns>
        public static string GetThinnerName(PaintThinnerEnum thinner)
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
