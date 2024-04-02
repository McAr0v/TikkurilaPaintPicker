using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    /// <summary>
    /// КЛАСС-РЕПОЗИТОРИЙ, ОБЪЕДИНЯЮЩИЙ ВСЕ СПИСКИ КРАСОК
    /// </summary>
    public class PaintRepository
    {
        // Общий список красок
        private static List<PaintClass> allPaints;

        /// <summary>
        /// Статический конструктор для инициализации списка красок
        /// </summary>
        static PaintRepository()
        {
            allPaints = new List<PaintClass>();
            InitializeAllPaints();
        }

        /// <summary>
        /// Статический метод для добавления красок в общий список
        /// </summary>
        private static void InitializeAllPaints()
        {
            // Создаем экземпляры классов с красками
            WaterEmulsionPaints waterEmulsionPaints = new WaterEmulsionPaints();
            MetalPaints metalPaints = new MetalPaints();

            // Добавляем краски из разных классов в общий список
            AddPaints(waterEmulsionPaints.WaterEmulsionPaintList);
            AddPaints(metalPaints.MetalPaintList);
        }

        /// <summary>
        /// Статический метод для добавления красок в общий список
        /// </summary>
        /// <param name="paints"></param>
        private static void AddPaints(List<PaintClass> paints)
        {
            allPaints.AddRange(paints);
        }

        /// <summary>
        /// Метод для получения красок, находящихся в определенной категории
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<PaintClass> GetPaintsInCategory(CategoryEnums category) 
        {
            List<PaintClass> tempList = new List<PaintClass>();

            foreach(PaintClass paintClass in allPaints) 
            {
                foreach (CategoryEnums categoryEnum in paintClass.Categories) 
                {
                    if (categoryEnum == category) 
                    {
                        tempList.Add(paintClass); 
                        break;
                    }
                }
            }

            return tempList;
        }

        /// <summary>
        /// Метод получения списка красок, соответствующих результатам 
        /// ответов пользователя в paintPicker'е
        /// </summary>
        /// <param name="pickerResult"></param>
        /// <returns></returns>
        public List<PaintClass> GetPaintsListFromPickerResult(PaintClass pickerResult) 
        {
            
            List<PaintClass> tempList = new List<PaintClass> ();

            // Заполняем ответы в переменные из переменной pickerResult,
            // которая по сути является краской, которую мы передавали из
            // экрана в экран

            PaintObjectEnum paintObject = pickerResult.Objects[0];
            PaintMaterialEnum paintMaterial = pickerResult.Materials[0];
            PaintLocationEnum paintLocation = pickerResult.Locations[0];
            PaintThinnerEnum paintThinner = pickerResult.Thinner;
            PaintColorEnum paintColor = pickerResult.Colors[0];
            PaintGlossEnum paintGlossEnum = pickerResult.Gloss[0];

            // Проверяем каждую краску из общего списка красок

            foreach(PaintClass paint in allPaints)
            {
                // Проверяем на точное совпадение ответов и свойств краски
                bool checkPaint = CheckPaintAndPickerResults
                    (
                        paint: paint,
                        paintMaterial: paintMaterial,
                        paintLocation: paintLocation,
                        paintThinner: paintThinner,
                        paintColor: paintColor,
                        paintGlossEnum: paintGlossEnum,
                        paintObject: paintObject
                    );

                // Если все совпадает, то добавляем в список
                if ( checkPaint ) 
                { 
                    tempList.Add(paint);
                }
            }

            return tempList;

        }

        /// <summary>
        /// Функция проверки краски на точное соответствие ответам,
        /// которые пользователь выбрал в paintPicker'е
        /// </summary>
        /// <param name="paint"></param>
        /// <param name="paintObject"></param>
        /// <param name="paintMaterial"></param>
        /// <param name="paintLocation"></param>
        /// <param name="paintThinner"></param>
        /// <param name="paintColor"></param>
        /// <param name="paintGlossEnum"></param>
        /// <returns></returns>
        private bool CheckPaintAndPickerResults
            (
                PaintClass paint,
                PaintObjectEnum paintObject,
                PaintMaterialEnum paintMaterial,
                PaintLocationEnum paintLocation,
                PaintThinnerEnum paintThinner,
                PaintColorEnum paintColor,
                PaintGlossEnum paintGlossEnum
            ) 
        {
            bool checkPaintObject = PaintObject.CheckPaintObject(paint: paint, paintObject: paintObject);
            bool checkPaintMaterial = PaintMaterial.CheckPaintMaterial(paint: paint, paintMaterial: paintMaterial);
            bool checkPaintLocation = PaintLocation.CheckPaintLocation(paint: paint, paintLocation: paintLocation);
            bool checkPaintThinner = PaintThinner.CheckPaintThinner(paint: paint, paintThinner: paintThinner);
            bool checkPaintColor = PaintColor.CheckPaintColor(paint, paintColor);
            bool checkPaintGloss = PaintGloss.CheckPaintGloss(paint, paintGlossEnum);

            // Возвращаем true, если есть совпадение по всем параметрам
            return checkPaintObject && checkPaintMaterial && checkPaintLocation && checkPaintThinner && checkPaintColor && checkPaintGloss;
        }
    }
}
