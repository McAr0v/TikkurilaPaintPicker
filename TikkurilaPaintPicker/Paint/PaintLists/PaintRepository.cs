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
        public static void AddPaints(List<PaintClass> paints)
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



    }
}
