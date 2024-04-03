using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class CleaningAgents
    {
        public List<PaintClass> CleaningAgentsList { get; private set; }

        public CleaningAgents() 
        {
            CleaningAgentsList = 
            [
                // ---- Maalipesu -----
                new PaintClass
                {
                    Name = "Maalipesu",
                    Description = "Щелочное моющее средство для очистки и предварительной обработки внутренних " +
                    "и наружных поверхностей перед окраской." +
                    "\r\n\r\nМоющее средство Tikkurila Maalipesu эффективно подготовит поверхность к окраске. " +
                    "Оно избавит неокрашенные поверхности от грязи, жира, масла, воска и других загрязнений. Используйте " +
                    "неразбавленный раствор, чтобы очистить и матировать ранее окрашенные твердые и глянцевые " +
                    "поверхности – для лучшего сцепления новой краски." +
                    "\r\n\r\nИспользуйте Tikkurila Maalipesu для промывки стен, полов, мебели, дверей, разного рода " +
                    "строительных плит, лодок и других неметаллических поверхностей. " +
                    "\r\n\r\nОтлично подходит для мытья сильно загрязненных поверхностей в случаях, когда требуется " +
                    "эффективное и экологичное средство. Окрашенные латексной краской и другие матовые поверхности можно " +
                    "промывать моющим средством Tikkurila Maalipesu, разбавленным водой в соотношении 1:10 или 1:5.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Plastic
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Roofs,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,

                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.CleaningAgentsAndAdditives,

                    }
                },

                // ---- Pensselipesu -----
                new PaintClass
                {
                    Name = "Pensselipesu",
                    Description = "Не содержащее органических растворителей моющее средство для очистки инструментов от остатков краски.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Plastic
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Roofs,
                        PaintObjectEnum.Fassade
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,

                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.CleaningAgentsAndAdditives,

                    }
                },

                // ---- Homeenpoisto -----
                new PaintClass
                {
                    Name = "Homeenpoisto",
                    Description = "Гипохлоритный желеобразный раствор для удаления плесени. " +
                    "Раствор Homeenpoisto от Tikkurila эффективно удаляет плесень с деревянных, отштукатуренных и " +
                    "бетонных фасадов. Он хорошо убирает с дерева синеву при условии, что она не успела проникнуть " +
                    "слишком глубоко. Также им можно обрабатывать крыши из фиброцементных плит и бетонной черепицы." +
                    "\r\n\r\nСостав Tikkurila Homeenpoisto разбавляют водой в соотношении 1:3 и наносят на заплесневелый " +
                    "фасад губкой или мягкой щеткой. На большие поверхности его удобнее наносить садовым опрыскивателем " +
                    "в направлении снизу вверх – это позволит избежать появления полос." +
                    "\r\n\r\nЕсли поверхность сильно заплесневела, раствор можно подержать подольше и применить щетку. " +
                    "После обработки фасад тщательно промывают чистой водой в направлении сверху вниз, например, опрыскивателем. " +
                    "Очищенная раствором Tikkurila Homeenpoisto поверхность – гладкая и готова к окраске.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Plastic,
                        PaintMaterialEnum.Ceramic,
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,

                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.CleaningAgentsAndAdditives,

                    }
                },

                // ---- Supi Saunapesu -----
                new PaintClass
                {
                    Name = "Supi Saunapesu",
                    Description = "Кислое отбеливающее, растворяющее известковые соли моющее средство." +
                    "\r\n\r\nМоющее средство Супи Саунапесу поможет содержать в чистоте баню и другие влажные помещения. " +
                    "Используйте его для отбеливания полков, мытья полов и стен, а также для обязательной очистки поверхностей перед " +
                    "обработкой – например, перед пропиткой маслом. Подходит для деревянных, кафельных и металлических поверхностей." +
                    "\r\n\r\nУ бани свой особый аромат: благоухание прогретого дерева и терпкие травяные ноты душистых веников. " +
                    "В ней нет места запаху хлора. В отличие от других моющих средств, Супи Саунапесу от Тиккурила – кислотное средство. " +
                    "Оно дезинфицирует поверхность и эффективно удаляет известковый налет, оставляя после себя чистоту, но не запах." +
                    "\r\n\r\nСупи Саунапесу относится к экологически чистым материалам класса М1, оно не пахнет и не выделяет в " +
                    "воздух вредных веществ. Средство не вызывает коррозии, однако при очистке зашпатлеванных швов концентратом " +
                    "или крепким раствором следует соблюдать осторожность и не применять его одновременно со средствами, содержащими хлор.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Ceramic,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Plastic
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent,

                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.CleaningAgentsAndAdditives,
                        CategoryEnums.SaunaOils

                    }
                },
            ];
        }
    }
}
