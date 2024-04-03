using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    /// <summary>
    /// Класс, хранящий в себе списки красок по металлу
    /// </summary>
    public class MetalPaints
    {
        public List<PaintClass> MetalPaintList { get; private set; }

        public MetalPaints()
        {
            MetalPaintList =
            [
                // Добавляем краски по металлу

                // ---- МИРАНОЛ -----
                new PaintClass
                {
                    Name = "Miranol",
                    Description = "Тиксотропная алкидная эмаль с незначительным запахом. " +
                    "Универсальная и простая в использовании эмаль Tikkurila Miranol напоминает, сколько удовольствия может " +
                    "приносить работа руками. Она почти не пахнет и хорошо распределяется по поверхности, не образуя подтеков. " +
                    "Вы можете покрасить Tikkurila Miranol все - от лодок до детских игрушек. " +
                    "\r\n\r\nУдаропрочная желеобразная алкидная эмаль Tikkurila Miranol отлично подходит для окраски " +
                    "рабочих инструментов и велосипедов. Также вы можете обновить ей садовую мебель – яркие столики, " +
                    "кресла и скамейки станут настоящим украшением двора." +
                    "\r\n\r\nВысокоглянцевая эмаль колеруется по каталогам цветов для внутренних и наружных работ Tikkurila. " +
                    "Для вашего удобства Tikkurila Miranol продается как в маленьких, так и в больших банках, что позволяет эффективнее расходовать объем. ",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum> 
                    { 
                        PaintMaterialEnum.Metal, 
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullGloss },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.Constructions, 
                        PaintObjectEnum.Furniture, 
                        PaintObjectEnum.Windows, 
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Roofs
                    },
                    Locations = new List<PaintLocationEnum> 
                    { 
                        PaintLocationEnum.Indoor, 
                        PaintLocationEnum.Outdoor 
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
                        CategoryEnums.Enamels, 
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForRoofs,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForGardenFurniture,
                        CategoryEnums.EnamelsForWindows
                    }
                }
,
                // ---- УНИКА ------
                new PaintClass
                {
                    Name = "Unica",
                    Description = "Алкидная краска. Используйте краску Уника для защиты металлических поверхностей – " +
                    "в особенности тех, которые требуют частого мытья: транспортных средств, оборудования, лодок, рабочих инструментов. " +
                    "Она также отлично защитит мебель и другие деревянные поверхности. " +
                    "\r\n\r\nПластмассовые поверхности – не самые простые для окраски, но краска Уника справляется " +
                    "со многими из них. Например, вы можете обработать ею надводные части лодок из пластмассы или стекловолокна," +
                    " используя наиболее удобный инструмент: кисть, распылитель или валик с коротким ворсом." +
                    "\r\n\r\nУника – особенная краска. Она с легкостью выдерживает воздействие разных смазочных " +
                    "масел и консистентных смазок, устойчива к уайт-спириту и денатурату. Краска не выгорает на " +
                    "солнце и будет долго украшать обработанную поверхность.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum> 
                    { 
                        PaintMaterialEnum.Metal, 
                        PaintMaterialEnum.Plastic, 
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiGloss },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.Constructions, 
                        PaintObjectEnum.Furniture, 
                        PaintObjectEnum.Windows, 
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                        PaintObjectEnum.Fences
                    },
                    Locations = new List<PaintLocationEnum> 
                    { 
                        PaintLocationEnum.Indoor, 
                        PaintLocationEnum.Outdoor 
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForGardenFurniture,
                        CategoryEnums.EnamelsForWindows,
                        CategoryEnums.EnamelsForPlastic
                    }
                }
,
                // ----- ХЭЛМИ -------
                new PaintClass
                {
                    Name = "Helmi",
                    Description = "Акрилатная краска. Выбирая краску для мебели Tikkurila Helmi, " +
                    "вы выбираете из 20 000 оттенков гаммы Tikkurila «Симфония». Смелее экспериментируйте " +
                    "с цветами: яркий столик, шкаф или трюмо станут той вишенкой на торте, которая придаст " +
                    "палитре помещения завершенность и индивидуальность." +
                    "\r\n\r\nкрилатная краска для мебели Tikkurila Helmi не желтеет со временем. Она легко " +
                    "наносится на новые деревянные, ДВП, ДСП или металлические поверхности внутри помещений." +
                    " С ее помощью вы также можете перекрасить мебель, которая уже была окрашена алкидной или каталитической краской." +
                    "\r\n\r\nTikkurila Helmi относится к высшему классу М1: она почти не пахнет и не выделяет " +
                    "в воздух летучих веществ. Экологичный продукт идеален для покраски детских игрушек. " +
                    "Полуматовое покрытие украшает поверхность сдержанным блеском, в то же время на нем практически не заметны отпечатки пальцев.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum> 
                    { 
                        PaintMaterialEnum.Metal, 
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> 
                    { 
                        PaintGlossEnum.Matt, 
                        PaintGlossEnum.SemiMatte,
                        PaintGlossEnum.Gloss 
                    },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.Constructions, 
                        PaintObjectEnum.Furniture, 
                        PaintObjectEnum.Windows, 
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards
                    },
                    Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor},
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum> 
                    { 
                        PaintColorEnum.DarkShades, 
                        PaintColorEnum.LightShades, 
                        PaintColorEnum.White 
                    },
                    Categories = new List<CategoryEnums> 
                    {
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                    }
                }
,
                // ----- ПЕСТО -----
                new PaintClass
                {
                    Name = "Pesto",
                    Description = "Стойкая универсальная матовая эмаль.\r\n\r\n" +
                    "Универсальная эмаль Tikkurila Pesto 10 великолепно подходит для деревянных поверхностей " +
                    "внутри и снаружи помещений: мебели, дверей, оконных рам, а также окрашивает любые металлические поверхности, " +
                    "в том числе инструмент и транспорт: велосипеды, автомобили, грузовики, сельхозтехнику. Внутри помещений " +
                    "эмалью можно покрывать бетонные и кирпичные стены." +
                    "\r\n\r\nОкрашенная универсальной эмалью " +
                    "Tikkurila Pesto 10 поверхность приобретает отличную износостойкость до 10 лет. " +
                    "Она выдержит воздействие скипидара, уайт-спирита, денатурата, растительных и " +
                    "животных жиров и смазочных масел. Устойчива к атмосферным нагрузкам. Используйте эмаль Tikkurila " +
                    "Pesto 10 для окраски стен и потолков в ванных, кухнях и коридорах, а также для любых " +
                    "металлических поверхностей (в том числе для инструментов и транспорта), " +
                    "и она будет многие годы украшать их, оставаясь чистой и сохраняя первоначальный блеск." +
                    "\r\n\r\nИнтерьерная эмаль Tikkurila Pesto 10 образует красивую матовую поверхность. " +
                    "Воплощайте с ее помощью самые смелые дизайнерские идеи, выбирая из более чем 20 000 цветов " +
                    "и оттенков каталога ​Tikkurila «Симфония». База А также может использоваться в качестве белой эмали.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum> 
                    { 
                        PaintMaterialEnum.Metal, 
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> 
                    { 
                        PaintGlossEnum.Matt, 
                        PaintGlossEnum.SemiMatte, 
                        PaintGlossEnum.FullGloss 
                    },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.Constructions, 
                        PaintObjectEnum.Furniture, 
                        PaintObjectEnum.Windows, 
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards,
                        PaintObjectEnum.Fences
                    },
                    Locations = new List<PaintLocationEnum> 
                    { 
                        PaintLocationEnum.Indoor, 
                        PaintLocationEnum.Outdoor 
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForGardenFurniture,
                        CategoryEnums.EnamelsForWindows,
                    }
                },

                // ---- Empire -----
                new PaintClass
                {
                    Name = "Empire",
                    Description = "Тиксотропная алкидная краска. Краска Tikkurila Empire разработана специально для окраски деревянной " +
                    "и металлической мебели, в том числе садовой. Она обладает слабым запахом, легко наносится и равномерно, " +
                    "без подтеков распределяется по поверхности. Также прекрасно подходит для окраски дверей, радиаторов или окон внутри дома." +
                    "\r\n\r\nTikkurila Empire – тиксотропная краска. Благодаря загустителям в своем составе она не дает подтеков " +
                    "даже при нанесении на вертикальную поверхность. Работать с такой густой краской – одно удовольствие: она не " +
                    "стекает с кисти и не оседает на дне банки." +
                    "\r\n\r\nКраску Tikkurila Empire можно колеровать в более чем 20 000 оттенков гаммы Tikkurila «Симфония», " +
                    "воплощая самые тонкие замыслы дизайнера. Полуматовое покрытие украшает мебель сдержанным блеском и в то же " +
                    "время практично: на нем почти не заметны отпечатки пальцев.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiMatte },
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForWindows
                    }
                },

                // ---- Уника аква -----
                new PaintClass
                {
                    Name = "Unica Akva Maali",
                    Description = "Акрилатная краска. Предназначена для окраски оконных и дверных рам, дверей, " +
                    "а также садовой мебели. Применяется также для окраски деревянных панелей застекленных балконов. " +
                    "Применяется для окраски новых и ранее окрашенных или лакированных деревянных и загрунтованных " +
                    "металлических поверхностей внутри и снаружи помещений. Отлично подходит для ремонтной окраски " +
                    "деревянных поверхностей, окрашенных, лакированных или лессированных промышленным способом. " +
                    "Не рекомендуется для окраски покрытых краской горячей сушки алюминиевых поверхностей.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiGloss },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.SkirtingBoards
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForGardenFurniture,
                        CategoryEnums.EnamelsForWindows
                    }
                },


                // ---- Metallista -----
                new PaintClass
                {
                    Name = "Metallista",
                    Description = "Специальная атмосферостойкая краска по ржавчине для внутренних и наружных работ, " +
                    "сочетает в себе свойства преобразователя ржавчины, антикоррозионной грунтовки и декоративного финишного покрытия." +
                    "\r\n\r\nКраска Tikkurila Metallista – это эффективное решение для защиты металлических поверхностей до 12 лет. " +
                    "Теперь вам не придется идти на компромисс, с Tikkurila Metallista вы можете быть уверены, что получите максимум. " +
                    "\r\n\r\nВоск в составе краски Tikkurila Metallista препятствует проникновению влаги и грязи к основанию, " +
                    "а активные компоненты взаимодействуют со ржавчиной и не дают ей распространяться дальше, образуя нерастворимый защитный слой." +
                    "\r\n\r\nПростое решение для сложных поверхностей? Краска Tikkurila Metallista – это преобразователь ржавчины, " +
                    "антикоррозионная грунтовка и декоративное покрытие в одной банке. Теперь окрашивать металлические поверхности " +
                    "можно без дополнительной подготовки!",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiGloss },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Fences,
                        PaintObjectEnum.Roofs
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForGardenFurniture,
                        CategoryEnums.EnamelsForRoofs
                    }
                },

                // ---- Betolux -----
                new PaintClass
                {
                    Name = "Betolux",
                    Description = "Уретано-алкидная краска. Роскошный шале-отель в горах, большой торговый центр и даже ваш " +
                    "дачный дом – в любом из этих зданий полы регулярно испытывают немалые механические нагрузки, а значит, " +
                    "нуждаются в защите. Краска для полов Tikkurila Betolux прекрасно справляется с задачей, продлевая " +
                    "срок службы бетонных и деревянных полов." +
                    "\r\n\r\nГлянцевый блеск краски для полов Tikkurila Betolux сделает помещение визуально " +
                    "более просторным. Пол будет отражать свет подобно глади большого озера, для которого вы можете " +
                    "выбрать любой из двух десятков цветов каталога «Покрытия для полов». Еще больше вдохновляющих " +
                    "оттенков – в гамме каталога Tikkurila «Симфония»." +
                    "\r\n\r\nЦвет пола меняет визуальное восприятие пространства. Например, сочетание темного " +
                    "пола и потолка со светлыми стенами зрительно расширит помещение, но уменьшит его высоту. " +
                    "Светлые стены, пол и потолок создадут эффект простора. Чтобы подчеркнуть горизонтальные линии " +
                    "в интерьере, покрасьте пол и потолок в светлый цвет, а стены – в темный.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiGloss },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Doors
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForFloors,
                        CategoryEnums.EnamelsForFurniture,
                    }
                },

                // ---- Betolux Akva -----
                new PaintClass
                {
                    Name = "Betolux Akva",
                    Description = "Полиуретано-акрилатная краска. Чтобы защитить поверхность пола от повреждений, " +
                    "используйте современную краску для пола Tikkurila Betolux Akva. Она гарантирует ровное," +
                    " красивое покрытие, которое не только упростит уход за поверхностью пола, но и раскроет ее эстетический потенциал." +
                    "\r\n\r\nTikkurila Betolux Akva можно применять как для деревянных, так и для бетонных полов в сухих и влажных " +
                    "помещениях. Краска подходит для ремонтной окраски полов, ранее покрытых лаками, эпоксидными или алкидными красками." +
                    "\r\n\r\nНасладитесь самой приятной и творческой частью работы – выбором цвета. Краска для пола Tikkurila Betolux " +
                    "Akva колеруется в 20 цветов каталога Tikkurila «Покрытия для полов», а также в большинство цветов гаммы Tikkurila «Симфония».",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiMatte },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Doors
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForFloors,
                        CategoryEnums.EnamelsForFurniture,
                    }
                },

                // ---- Panssarimaali -----
                new PaintClass
                {
                    Name = "Panssarimaali",
                    Description = "Алкидная краска. Краска Панссаримаали проверена временем и суровым финским климатом. " +
                    "Активный противокоррозийный пигмент в ее составе надежно защищает металлическое покрытие от дождей и снега. " +
                    "Большой выбор цветов поможет сделать яркий акцент на крыше и украсить дом." +
                    "\r\n\r\nКраской Панссаримаали можно защитить любые металлические конструкции снаружи дома:" +
                    " водосточные трубы и желоба, металлические сливы, карнизы, перила. Она легко ложится на оцинкованные, " +
                    "алюминиевые и стальные, а также окрашенные ранее алкидной краской поверхности." +
                    "\r\n\r\nКраска образует красивое полуглянцевое покрытие, блестящее на солнце. Колеруется по каталогам " +
                    "Тиккурила «Краски для металлических крыш» и «Деревянные фасады». Рекомендуем выбирать цвет на один-два " +
                    "тона темнее желаемого, так как под воздействием солнца и влаги цвет поверхности имеет свойство светлеть.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Metal
                    },
                    Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiGloss },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Roofs,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Fences
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor,
                        PaintLocationEnum.Outdoor
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
                        CategoryEnums.Enamels,
                        CategoryEnums.EnamelsForRoofs,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForGardenFurniture,
                    }
                },


            ];
        }
    }
}
