using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class Solvents
    {
        public List<PaintClass> SolventsList { get; private set; }
        public Solvents() 
        {
            SolventsList = 
            [
                // ---- 1050 -----
                new PaintClass
                {
                    Name = "Lakkabensiini 1050",
                    Description = "Высокоочищенный уайт-спирит. Органический растворитель Tikkurila Lakkabensiini " +
                    "1050 подходит для разведения алкидных и масляных красок и лаков Tikkurila. Материал хранится " +
                    "в стандартной таре не менее 10 лет даже при низких температурах." +
                    "\r\n\r\nС помощью растворителя Tikkurila Lakkabensiini 1050 Вы сможете очистить небольшие поверхности " +
                    "от жировых пятен, пыли и грязи перед окраской. Также он подходит для очистки инструментов после использования." +
                    "\r\n\r\nВ отличие от обычных растворителей, высокоочищенный Tikkurila Lakkabensiini 1050 не содержит " +
                    "резких ароматов, поэтому с ним комфортно работать. Однако обращаем Ваше внимание на необходимость " +
                    "тщательно проветривать помещение во время работы.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        
                    },
                    Gloss = new List<PaintGlossEnum> {  },
                    Objects = new List<PaintObjectEnum>
                    {
                        
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,
                        
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Solvents
                    }
                },

                // ---- 1032 -----
                new PaintClass
                {
                    Name = "Ruiskuohenne 1032",
                    Description = "Растворитель с легким запахом используется для разведения красок «Миранол» и «Уника», " +
                    "что позволяет наносить их методом распыления. Разведенная краска образует идеально ровную " +
                    "поверхность после высыхания. Вы также можете использовать растворитель 1032 для очистки инструментов." +
                    "\r\n\r\nПри соблюдении правил безопасности растворители Тиккурила можно использовать в домашних условиях. " +
                    "В процессе работы обязательно организовать хорошую вентиляцию воздуха в помещении и использовать " +
                    "соответствующую защитную одежду и перчатки. Следует избегать вдыхания паров растворителя 1032.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {

                    },
                    Gloss = new List<PaintGlossEnum> {  },
                    Objects = new List<PaintObjectEnum>
                    {

                    },
                    Locations = new List<PaintLocationEnum>
                    {

                    },
                    Thinner = PaintThinnerEnum.Solvent1031,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,

                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Solvents
                    }
                },

                // ---- 1120 -----
                new PaintClass
                {
                    Name = "Ohenne 1120",
                    Description = "Растворитель Tikkurila Ohenne 1120 предназначен специально для антикоррозийной " +
                    "грунтовки Tikkurila Rostex Super. Разбавленная грунтовка не забивает сопло пульверизатора, " +
                    "лучше ложится и образует идеально ровную поверхность после высыхания. При необходимости грунтовку разбавляют до 15%. " +
                    "\r\n\r\nПри соблюдении правил безопасности растворители Tikkurila можно использовать в домашних условиях. " +
                    "В процессе работы обязательно организовать хорошую вентиляцию воздуха и использовать соответствующую защитную " +
                    "одежду и перчатки. Следует избегать вдыхания паров растворителя и пыли от распыления.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {

                    },
                    Gloss = new List<PaintGlossEnum> {  },
                    Objects = new List<PaintObjectEnum>
                    {

                    },
                    Locations = new List<PaintLocationEnum>
                    {

                    },
                    Thinner = PaintThinnerEnum.Solvent1120,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,

                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Solvents
                    }
                },

            ];
            
        }
    }
}
