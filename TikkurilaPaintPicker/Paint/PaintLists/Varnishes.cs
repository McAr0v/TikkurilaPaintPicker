using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class Varnishes
    {
        public List<PaintClass> VarnishesList { get; private set; }
        public Varnishes() 
        {
            VarnishesList = 
            [
                // ДОБАВЛЯЕМ КРАСКИ

                // ---- Paneeli-Ässä  -----
                new PaintClass
                {
                    Name = "Paneeli assa",
                    Description = "Акрилатный лак. Еще один хит в линейке лаков Тиккурила – матовый лак Панели-Ясся. " +
                    "Он эффективно защищает стены и потолки от механических и других повреждений, одновременно позволяя обновить и украсить интерьер." +
                    "\r\n\r\nЛак имеет белый цвет, однако становится прозрачным после высыхания. Он не темнеет со временем и выгодно " +
                    "подчеркивает цвет дерева, сохраняя нетронутой его природную красоту. Панели-Ясся также прекрасно подойдет " +
                    "для лакировки кирпичных и бетонных поверхностей." +
                    "\r\n\r\nОбразованная матовым лаком Панели-Ясся бархатистая поверхность добавит уюта и тепла в " +
                    "любой интерьер. Вдобавок на ней не остаются отпечатки пальцев, что особенно удобно, если в доме растут дети. ",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.Matt,
                        PaintGlossEnum.SemiMatte
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Varnishes,
                        CategoryEnums.VarnishesForWallsAndCeilings
                    }
                },

                // ---- Lacquer Aqua  -----
                new PaintClass
                {
                    Name = "Lacquer Aqua",
                    Description = "Водоразбавляемый колеруемый лак на акрилатной основе для внутренних работ. " +
                    "Представлен в матовой и полуглянцевой степенях блеска." +
                    "\r\n\r\nВодоразбавляемый колеруемый лак на акрилатной основе для внутренних работ. " +
                    "Представлен в матовой и полуглянцевой степенях блеска. Деревянные панели, вагонка, доски, " +
                    "брёвна, а также бетонные и кирпичные поверхности. Предназначен для защиты ранее непокрытых " +
                    "деревянных панелей, вагонки, досок, брёвен, а также бетонных и кирпичных поверхностей в " +
                    "сухих помещениях. Не применяется для полов и мебели. Придает поверхности водо- и грязеотталкивающие " +
                    "свойства, защищает от появления плесени.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.Matt,
                        PaintGlossEnum.Gloss
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Varnishes,
                        CategoryEnums.VarnishesForWallsAndCeilings
                    }
                },

                // ---- Kiva  -----
                new PaintClass
                {
                    Name = "Kiva",
                    Description = "Не желтеющий с течением времени колируемый акрилатный лак на водной основе для применения внутри помещений." +
                    "\r\n\r\nЛак для мебели Tikkurila Kiva поможет обновить любимый книжный шкаф, защитит от времени деревянный " +
                    "стол и стулья. Используйте его также для лакировки детских игрушек, панельных стен, потолков, дверей или для " +
                    "защитной лакировки окрашенных и мореных поверхностей." +
                    "\r\n\r\nПрирода создала дерево совершенным, поэтому водоразбавляемые акрилатные лаки Tikkurila " +
                    "изначально бесцветны. Благородный блеск лака лишь подчеркивает естественный цвет дерева. " +
                    "Стойкое покрытие Tikkurila Kiva не желтеет и не темнеет, сохраняя древесину в ее первозданной красоте." +
                    "\r\n\r\nС помощью лака для мебели Tikkurila Kiva вы можете не только защитить дерево, но и при желании тонировать его. " +
                    "Лак колеруется в 36 лессирующих цветов каталога Tikkurila «Колеруемые лаки для интерьеров». " +
                    "Относится к высшему классу М1, то есть почти не выделяет в воздух летучих веществ.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.Matt,
                        PaintGlossEnum.SemiMatte,
                        PaintGlossEnum.SemiGloss,
                        PaintGlossEnum.Gloss
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
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
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Varnishes,
                        CategoryEnums.VarnishesForFurniture
                    }
                },

                // ---- Unica Super -----
                new PaintClass
                {
                    Name = "Unica Super",
                    Description = "Уретано-алкидный лак. Лак Уника Супер содержит компоненты, замедляющие воздействие солнечного " +
                    "света на древесину. Формула состава обеспечивает устойчивость покрытия к мытью и износу, " +
                    "а также стойкость к химикатам, животным и растительным жирам, смазкам." +
                    "\r\n\r\nИзносостойкий лак поможет сохранить превосходный внешний вид паркета даже при частой влажной " +
                    "уборке. Он защитит от выцветания двери и оконные рамы, придаст деревянной мебели более привлекательный " +
                    "вид. На красивом покрытии практически не заметны отпечатки обуви или пальцев." +
                    "\r\n\r\nУстойчивый к износу и воздействию воды, лак Уника Супер с успехом применяется для обработки " +
                    "лодок, яхт и катеров. С его помощью вы сможете защитить от гниения и растрескивания не только борта, но и палубу с каютами.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.SemiMatte,
                        PaintGlossEnum.SemiGloss,
                        PaintGlossEnum.Gloss
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Floors
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.Varnishes,
                        CategoryEnums.VarnishesForFurniture,
                        CategoryEnums.VarnishesForFloors
                    }
                },
            ];
        }
    }
}
