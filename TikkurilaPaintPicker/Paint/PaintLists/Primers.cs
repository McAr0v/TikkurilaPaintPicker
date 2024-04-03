using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class Primers
    {
        public List<PaintClass> PrimersList { get; private set; }

        public Primers() 
        {
            PrimersList = 
            [
                // Добавляем грунтовки

                // ---- Otex -----
                new PaintClass
                {
                    Name = "Otex",
                    Description = "Алкидная грунтовка. Отекс быстро сохнет и обеспечивает прочное сцепление даже " +
                    "с такими проблематичными поверхностями, как стекло, кафель, стекловолокно, пластик, алюминий " +
                    "и оцинкованная сталь. Она обладает хорошей адгезией к поверхностям, окрашенным " +
                    "алкидной краской или краской кислотного отверждения." +
                    "\r\n\r\nПрименяйте грунтовку Отекс для внутренних поверхностей, от которых требуется особенно " +
                    "хорошая адгезия. Она прекрасно подойдет для грунтования наружных оконных переплетов, окрашенных " +
                    "ранее краской кислотного отверждения или краской на полиуретановой основе." +
                    "\r\n\r\nСовершенно матовая грунтовка Отекс колеруется в цвета гаммы «Тиккурила Симфония». " +
                    "Базис АР можно применять как белую краску или для колеровки. Базис С предназначен только для колеровки.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plastic,
                        PaintMaterialEnum.Ceramic,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.DarkShades,
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Primers,
                        CategoryEnums.PrimersForProblematicSurfaces,
                        CategoryEnums.PrimersForWood,

                    }
                },

                // ---- Otex Akva -----
                new PaintClass
                {
                    Name = "Otex Akva",
                    Description = "Грунтовка на водной основе. Водная альтернатива грунтовки Отекс. " +
                    "Грунтовка Отекс Аква  обладает хорошей адгезией к поверхностям, окрашенным алкидной краской или краской " +
                    "кислотного отверждения. Быстро сохнет и не имеет запаха. Относится к высшему классу эмиссии строительных материалов М1. " +
                    "\r\n\r\nОтекс Аква хорошо ложится на поверхности и обеспечивает прочное сцепление даже с такими проблематичными" +
                    " поверхностями, как стекло, кафель, стекловолокно, пластик, алюминий и оцинкованная сталь." +
                    "\r\n\r\nВоплощайте с помощью Отекс Аква самые смелые дизайнерские идеи. Матовая грунтовка Отекс Аква " +
                    "колеруется в цвета гаммы «Тиккурила Симфония».  Нет точности в оттенках темных цветов.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plastic,
                        PaintMaterialEnum.Ceramic,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Primers,
                        CategoryEnums.PrimersForProblematicSurfaces,
                        CategoryEnums.PrimersForWood,

                    }
                },

                // ---- Valtti Primer -----
                new PaintClass
                {
                    Name = "Valtti Primer",
                    Description = "Бесцветный грунтовочный антисептик, содержащий масло, для обработки древесины снаружи." +
                    "\r\n\r\nБесцветный грунтовочный антисептик, содержащий масло, для обработки древесины снаружи. " +
                    "Брёвна, вагонка, брус, строганые и пиленые доски, балки, перила, откосы, двери, оконные рамы. " +
                    "Предназначен для обработки бревенчатой, пиленой и строганой деревянной поверхности, а также разного " +
                    "рода деревянных плит и пропитанной под давлением древесины, подлежащих дальнейшей обработке " +
                    "лессирующими или кроющими материалами (кроме масел для дерева и красок на основе красной охры). " +
                    "Впитывается в древесину и замедляет проникновение влаги, что, в свою очередь, замедляет распространение " +
                    "плесени на обработанной поверхности.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Primers,
                        CategoryEnums.PrimersForWood,
                    }
                },

                // ---- RostexSuper -----
                new PaintClass
                {
                    Name = "Rostex Super",
                    Description = "Противокоррозионная алкидная грунтовка. Быстосохнущая противокоррозионная алкидная грунтовка на " +
                    "специальном связующем. Не содержит свинца и хроматов. Предназначена для грунтования стальных, оцинкованных, " +
                    "отшлифованных алюминиевых поверхностей, подвергающихся усиленной нагрузке, когда адгезия или скорость высыхания " +
                    "обыкновенных алкидных красок недостаточны. Подходит для покрытий из меди, латуни и нержавеющей стали, а также " +
                    "для покрытий из PURAL, POLYESTER, ACRYL и старого VC-покрытия. Применяется в качестве грунтовки под алкидные " +
                    "(например, Tikkurila Miranol, Tikkurila Unica, Tikkurila Panssarimaali) и водоразбавляемые краски. Только для " +
                    "профессионального использования. Применяется для грунтования металлических крыш, водостоков, кровельных конструкций, " +
                    "автотранспортных средств, железнодорожных подвижных составов, грузовиков, стальных конструкций, силосов, " +
                    "противопожарных дверей, пожарных лестниц, перил, флагштоков, лодок и других поверхностей как снаружи, так и внутри зданий.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal,
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Roofs,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Fences
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1120,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Primers,
                        CategoryEnums.PrimersForMetal
                    }
                },

                // ---- Евро праймер -----
                new PaintClass
                {
                    Name = "Euro Primer",
                    Description = "Водоразбавляемая акрилатная укрепляющая грунтовка глубокого проникновения " +
                    "с добавками против грибков и плесени. Концентрат 1:3." +
                    "\r\n\r\nХотите добиться наилучшего результата при покраске стен? Тогда не стоит недооценивать " +
                    "значение подходящей грунтовки! Грунтовка Tikkurila Euro Primer создавалась специально для идеального " +
                    "сочетания со шпатлевками и красками серии Tikkurila Euro. Она обеспечивает равномерность нанесения " +
                    "краски, сокращает расход финишного материала и увеличивает срок службы покрытия в целом. Помимо использования " +
                    "внутри помещений, эта грунтовка подходит и для фасадных работ." +
                    "\r\n\r\nНуждаетесь в дополнительной защите стен от биопоражений? Tikkurila Euro Primer – отличный выбор! " +
                    "Рецептура этой грунтовки позволяет дополнительно уберечь стены от появления грибка и " +
                    "плесени и улучшить адгезию поверхности с краской." +
                    "\r\n\r\nК несомненным достоинствам Tikkurila Euro Primer относятся и ее усиленные проникающие " +
                    "свойства. После нанесения грунтовки на стену вы можете быть уверенными, что добьетесь идеального " +
                    "результата при покраске. Кроме того, грунтовка является концентратом и разбавляется водой в пропорции 1:3, " +
                    "что позволяет покрыть максимальный объем при подготовке поверхности.",
                    Consumption = 40,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Fassade,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.Transparent
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Primers,
                        CategoryEnums.PrimersForMineralSurfaces
                    }
                },

            ];
        }
    }
}
