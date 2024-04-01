using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class PaintRepository
    {
        // Общий список красок
        private static List<PaintClass> allPaints;

        // Статический конструктор для инициализации списка красок
        static PaintRepository()
        {
            allPaints = new List<PaintClass>();
            InitializeAllPaints();
        }

        // Статический метод для добавления красок в общий список
        private static void InitializeAllPaints()
        {
            // Создаем экземпляры классов с красками
            WaterEmulsionPaints waterEmulsionPaints = new WaterEmulsionPaints();
            MetalPaints metalPaints = new MetalPaints();

            // Добавляем краски из разных классов в общий список
            AddPaints(waterEmulsionPaints.WaterEmulsionPaintList);
            AddPaints(metalPaints.MetalPaintList);
        }

        // Статический метод для добавления красок в общий список
        private static void AddPaints(List<PaintClass> paints)
        {
            allPaints.AddRange(paints);
        }

        // Метод для получения общего списка красок
        public static List<PaintClass> GetAllPaints()
        {
            return allPaints;
        }

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

        public List<PaintClass> GetPaintsListFromPickerResult(PaintClass pickerResult) 
        {
            List<PaintClass> tempList = new List<PaintClass> ();

            PaintObjectEnum paintObject = pickerResult.Objects[0];
            PaintMaterialEnum paintMaterial = pickerResult.Materials[0];
            PaintLocationEnum paintLocation = pickerResult.Locations[0];
            PaintThinnerEnum paintThinner = pickerResult.Thinner;
            PaintColorEnum paintColor = pickerResult.Colors[0];
            PaintGlossEnum paintGlossEnum = pickerResult.Gloss[0];

            foreach(PaintClass paint in allPaints)
            {
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

                if ( checkPaint ) 
                { 
                    tempList.Add(paint);
                }
            }

            return tempList;

        }

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

            return checkPaintObject && checkPaintMaterial && checkPaintLocation && checkPaintThinner && checkPaintColor && checkPaintGloss;
        }
    }
}
