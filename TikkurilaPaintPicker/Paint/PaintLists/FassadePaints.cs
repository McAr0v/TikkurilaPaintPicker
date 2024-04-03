using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    
    public class FassadePaints
    {
        public List<PaintClass> FassadePaintsList { get; private set; }

        public FassadePaints()
        {
            FassadePaintsList = 
            [
                // ДОБАВЛЯЕМ КРАСКИ

                // ---- Фасад силикон -----
                new PaintClass
                {
                    Name = "Facade Silicon",
                    Description = "Силикон-модифицированная акриловая краска. Предназначена для окраски цоколей и фасадов жилых, торговых, промышленных, " +
                    "складских и др. помещений по бетону, штукатурке, фиброцементным плитам. Краска подходит для отделки ранее окрашенных " +
                    "прочно держащихся поверхностей, за исключением окрашенных известковыми, силикатными красками и органическими эластичными покрытиями. " +
                    "Рекомендуется для окраски бетонных оснований для защиты бетона от карбонизации и предотвращения коррозии железобетонных конструкций." +
                    "\r\n\r\nПредназначена для окраски цоколей и фасадов жилых, торговых, промышленных, складских и др. помещений.",
                    Consumption = 6,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Constructions
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.DarkShades,
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.FacadePaints,
                        CategoryEnums.FacadePaintsForMineralSurfaces
                    }
                },

                // ---- Фасад акрилат -----
                new PaintClass
                {
                    Name = "Facade Acrylate",
                    Description = "Для наружных работ: окраска фасадов, цоколей жилых, торговых, промышленных, складских и др. помещений " +
                    "по бетону, штукатурке, минеральным и акриловым декоративным материалам, фиброцементным плитам, вертикальным " +
                    "деревянным поверхностям из вагонки, строганным и пиленым дощатым фасадам, " +
                    "а также по балкам и откосам, подверженным атмосферным нагрузкам." +
                    "\r\n\r\nДля внутренних работ: окраска стен и потолков внутри жилых, торговых, промышленных, " +
                    "складских и др. помещений, в том числе с повышенной влажностью, по бетонным, кирпичным, " +
                    "оштукатуренным, зашпатлеванным поверхностям, гипсокартону, ДСП и ДВП плитам. " +
                    "Также используется для отделки ранее окрашенных водно-дисперсионными красками прочно держащихся " +
                    "поверхностей (после предварительного зашкуривания). Краска не рекомендуется для отделки поверхностей, ранее окрашенных известковыми, " +
                    "силикатными красками и органическими эластичными покрытиями.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,

                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor,
                        PaintLocationEnum.Indoor,
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.DarkShades,
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.FacadePaints,
                        CategoryEnums.FacadePaintsForMineralSurfaces,
                        CategoryEnums.FacadePaintsForWood,
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms,
                        CategoryEnums.WaterbornePaintsForWetRooms
                    }
                }, 

                // ---- Юки -----

                new PaintClass
                {
                    Name = "Yki Sokkelimaali",
                    Description = "Щелочестойкая акрилатная краска. Покрытие Юки отличается особенной стойкостью к ударам и очистке, " +
                    "а потому идеально подходит для окраски бетонных цоколей. Оно надежно защищает конструкцию от проникновения влаги " +
                    "и в то же время пропускает пар изнутри, позволяя зданию «дышать»." +
                    "\r\n\r\nГлубокоматовая краска для цоколя Юки колеруется в сотни современных оттенков. На ваш выбор – " +
                    "цвета каталогов «Фасад», «Деревянные фасады» и «Каменные фасады», а также в цвета для цоколя веера «Красивый Дом для Фасадов».",
                    Consumption = 6,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Constructions
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.DarkShades,
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.FacadePaints,
                        CategoryEnums.FacadePaintsForMineralSurfaces
                    }
                },

                // ---- Винха -----
                new PaintClass
                {
                    Name = "Vinha",
                    Description = "Защита для наружных деревянных поверхностей. В качестве связующего использован акрилат с добавлением алкида." +
                    "\r\n\r\nКроющий антисептик Винха от компании Тиккурила уже почти 40 лет пользуется заслуженной любовью в Скандинавии, " +
                    "России и многих других странах, жители которых ценят природную красоту дерева. Этот уникальный состав надежно " +
                    "защищает древесину, сохраняя ее структуру видной." +
                    "\r\n\r\nГотовое покрытие Винха устойчиво к атмосферным и механическим воздействиям. Оно обладает" +
                    " водоотталкивающей способностью, долгие годы защищая дом от непогоды. Специальные компоненты в составе " +
                    "кроющего антисептика Винха уберегут дерево от синевы и плесени." +
                    "\r\n\r\nВинха обладает великолепной укрывистостью. Это позволяет использовать его, чтобы перекрашивать " +
                    "старые фасады, покрытые антисептиками темных тонов, в светлые оттенки (и наоборот). Антисептик создает " +
                    "красивую полуматовую поверхность и колеруется в 30 цветов по каталогу «Винха».",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.SemiMatte
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Windows

                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor,
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.DarkShades,
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.FacadePaints,
                        CategoryEnums.FacadePaintsForWood
                    }
                },

                // ---- Пика Техо -----
                new PaintClass
                {
                    Name = "Pika Teho",
                    Description = "Акрилатная краска, содержащая масло. Pika-teho прошла испытание суровым финским климатом. " +
                    "Состав на основе натурального масла надолго защитит деревянный фасад дома от непогоды: дождей, снега, солнечного ультрафиолета. " +
                    "Благодаря особой прочности и эластичности краска будет отлично держаться на дереве, избавив вас от забот об окраске по меньшей мере на 20 лет." +
                    "\r\n\r\nPika-teho производится в Финляндии и пользуется большой популярностью благодаря высокому качеству и " +
                    "экономичному расходу. Работать с краской Пика-Техо – одно удовольствие: она хорошо ложится, не оставляя подтеков, " +
                    "и практически не пахнет. При соблюдении требуемых условий работы к следующему слою можно приступать уже через 2-4 часа." +
                    "\r\n\r\nУкрасьте загородный дом и забор на участке, выбрав приятные цвета, гармонирующие с окружающим ландшафтом. " +
                    "Совершенно матовая краска Пика-Техо колеруется в 120 цветов каталога Тиккурила «Деревянные фасады», устойчивых к выцветанию. " +
                    "Вы также можете провести окраску базовым составом, если хотите получить ярко-белый цвет.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.Matt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Windows

                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor,
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.DarkShades,
                        PaintColorEnum.LightShades,
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.FacadePaints,
                        CategoryEnums.FacadePaintsForWood
                    }
                },
            ];
        }
    }
}
