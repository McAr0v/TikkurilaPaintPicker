
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class WoodOils
    {
        public List<PaintClass> WoodOilsList { get; private set; }
        public WoodOils()
        {
            WoodOilsList = 
            [
                // ДОБАВЛЯЕМ КРАСКИ

                // ---- Супи саунасуоя -----
                new PaintClass
                {
                    Name = "Supi Saunasuoja",
                    Description = "Акрилатный защитный состав. Обработка стен и потолка сауны защитным составом Супи Саунасуоя надолго сохранит " +
                    "их первоначальный вид и поможет поддерживать в помещении чистоту. Средство глубоко впитывается в древесину, образуя " +
                    "грязе- и водоотталквающую пленку. Специальный компонент защитит обработанную поверхность от синевы и плесени." +
                    "\r\n\r\nТрадиционные оттенки древесины все чаще уступают место новым палитрам в дизайне саун. Черный, серый или, " +
                    "например, бирюзовый цвет могут стать стильным решением. Придайте помещению индивидуальный стиль, заколеровав " +
                    "Супи Саунасуоя в один из цветов каталога «Колеруемые лаки для интерьеров»." +
                    "\r\n\r\nЗащитный состав Супи Саунасуоя предназначен для обработки стен и потолков из дерева, древесноволокнистых " +
                    "плит и бетона. Для обработки полков бань рекомендуем использовать другие продукты " +
                    "Тиккурила – например, Супи Саунаваха или Супи Лаудесуоя.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
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
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WoodOils,
                        CategoryEnums.SaunaOils,
                        CategoryEnums.InteriorWoodOils,
                    }
                },
                // ---- Супи саунаваха -----
                new PaintClass
                {
                    Name = "Supi Saunavaha",
                    Description = "Состав на основе воска. Даже термообработанное дерево внутри саун и бань нуждается в защите. " +
                    "Содержащий воск защитный состав Супи Саунаваха от Тиккурила глубоко впитывается в древесину, " +
                    "образуя натуральную водо- и грязеотталкивающую поверхность. У плесени и синевы просто нет шансов." +
                    "\r\n\r\nТрадиционные оттенки древесины все чаще уступают место новым палитрам в дизайне саун. Готовые цвета " +
                    "защитного состава Супи Саунаваха – черный, белый или серый – могут стать стильным и современным решением. " +
                    "Вы также можете заколеровать состав в цвета 3441–3451 каталога «Колеруемые лаки для интерьеров»." +
                    "\r\n\r\nСупи Саунаваха относится к экологически чистым материалам класса М1. Состав практически не имеет" +
                    " запаха и не выделяет в воздух вредных для здоровья веществ даже при нагревании. Обработанные " +
                    "воском поверхности легко содержать в чистоте.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows
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
                        CategoryEnums.WoodOils,
                        CategoryEnums.SaunaOils,
                        CategoryEnums.InteriorWoodOils
                    }
                },

                // ---- Supi Laudesuoja -----
                new PaintClass
                {
                    Name = "Supi Laudesuoja",
                    Description = "Парафиновое масло. В защите нуждается даже термообработанное дерево в саунах и банях. " +
                    "Масляной состав Супи Лаудесуоя от Тиккурила эффективно защитит как необработанные, так и покрытые " +
                    "ранее маслом поверхности – например, полки. Средство глубоко впитывается в древесину, " +
                    "создавая на ней грязе - и водоотталкивающую пленку." +
                    "\r\n\r\nНатуральный цвет и структура дерева – главное украшение традиционной бани или сауны. " +
                    "Обработка  бесцветным масляным составом Супи Лаудесуоя не изменит природный цвет древесины, " +
                    "но сделает его более глубоким. Глубина оттенка зависит от породы, твердости и первоначального цвета дерева." +
                    "\r\n\r\nСупи Лаудесуоя относится к экологически чистым материалам класса М1. " +
                    "Состав практически не имеет запаха и не выделяет в воздух вредных для здоровья веществ даже при нагревании. " +
                    "Обработанные маслом поверхности легко содержать в чистоте.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows
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
                        CategoryEnums.WoodOils,
                        CategoryEnums.SaunaOils
                    }
                },

                // ---- Supi Масло для пола -----
                new PaintClass
                {
                    Name = "Supi Lattiaoljy",
                    Description = "Масляная эмульсия на основе растительного масла. Сама природа подсказала " +
                    "решение для наилучшей защиты полов в банях и саунах. Состав на основе натурального растительного масла " +
                    "естественным образом оберегает древесину от влаги и грязи. Обработанная маслом для пола Супи поверхность " +
                    "меньше растрескивается, надолго оставаясь гладкой и красивой." +
                    "\r\n\r\nМасло для пола Супи применяется для обработки очищенной до голого дерева или обработанной ранее " +
                    "маслом древесины. Подходит для термообработанной древесины и твердых пород дерева. Продукт относится " +
                    "к экологически чистым материалам класса М1 – он не имеет запаха и не выделяет вредных веществ." +
                    "\r\n\r\nТрадиционные оттенки древесины все чаще уступают место новым палитрам в дизайне саун. " +
                    "Придайте помещению индивидуальный стиль, заколеровав масло для пола Супи в один из цветов каталога " +
                    "Тиккурила «Колеруемые лаки для интерьеров». Используя бесцветный состав, помните, что после обработки " +
                    "натуральный оттенок дерева станет более глубоким.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors
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
                        CategoryEnums.WoodOils,
                        CategoryEnums.SaunaOils
                    }
                },

                // ---- Валтти колор -----
                new PaintClass
                {
                    Name = "Valtti Color",
                    Description = "Фасадная лазурь на масляной основе. Деревянный фасад нового дома выглядит безупречно, " +
                    "радуя хозяев свежими красками и гладкой поверхностью. Чтобы сохранить его таким на многие годы, " +
                    "используйте фасадную лазурь Валтти Колор – она надежно защитит древесину от дождей, снега и УФ-излучения." +
                    "\r\n\r\nВ основе Валтти Колор содержится натуральное масло – природный компонент, с давних времен используемый " +
                    "для защиты дерева от влаги. Фасадная лазурь от Тиккурила хорошо впитывается в древесину и не образует " +
                    "сплошной пленки после нанесения первого слоя." +
                    "\r\n\r\nФасадная лазурь Валтти Колор колеруется в 40 цветов " +
                    "каталога «Валтти». Работая над ним, мы вдохновлялись скромной красотой северной природы: летними лесами, " +
                    "тихими вечерами у озера, щедрыми дарами осени. Какой бы цвет вы ни выбрали, он будет идеально сочетаться с " +
                    "окружающим ландшафтом и дарить душе ощущение гармонии.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WoodOils,
                        CategoryEnums.WoodFacadeOils
                    }
                },

                // ---- Валтти колор сатин-----
                new PaintClass
                {
                    Name = "Valtti Color Satin",
                    Description = "Слегка желеобразный лессирующий антисептик на основе таллового и льняного масел. " +
                    "\r\n\r\nУхаживать за деревянными наружными поверхностями, заборами и садовой мебелью теперь легко как никогда. " +
                    "Тиккурила разработала состав лессирующего антисептика Валтти Колор Сатин на основе таллового и льняного масел. " +
                    "Он защищает древесину от атмосферной нагрузки, замедляя воздействие влаги, УФ-излучения, грибков, гнили, плесени и синевы." +
                    "\r\n\r\nЛессирующий антисептик Валтти Колор Сатин колеруется по каталогу «Валтти», включающему 40 гармонирующих " +
                    "с ландшафтом цветов. На его создание нас вдохновила сдержанная красота северной природы: лесов, озер, камня. " +
                    "Достаточно 1-2 слоев, чтобы поверхность приобрела выбранный цвет с благородным сатиновым блеском." +
                    "\r\n\r\nЭффективен для защиты наружных бревенчатых, пиленых и строганых деревянных поверхностей, деревянных плит, " +
                    "а также пропитанной под давлением древесины. Не подходит для обработки горизонтальных поверхностей, " +
                    "подвергающихся усиленному воздействию воды, а также для обработки внутри теплиц.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.SemiGloss
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WoodOils,
                        CategoryEnums.WoodFacadeOils
                    }
                },

                // ---- Valtti Log -----
                new PaintClass
                {
                    Name = "Valtti Log",
                    Description = "Пропиточно-лессирующий антисептик для защиты и отделки деревянных поверхностей снаружи помещений." +
                    "\r\n\r\nХотите защитить бревенчатый фасад или обработать баню снаружи? Выбирая Tikkurila Valtti Log, " +
                    "вы можете быть уверены, что обработанная поверхность сохранит свой первоначальный внешний вид до 5 лет. " +
                    "\r\n\r\nTikkurila Valtti Log не оставляет видимой пленки на поверхности и подчеркивает естественную красоту бревна. " +
                    "Tikkurila Valtti Log  содержит специальные пигменты, которые равномерно распределяются по поверхности и создают " +
                    "неповторимый декоративный эффект!" +
                    "\r\n\r\nПлесень, грибки, водоросли? Нет, не слышали! Благодаря уникальной формуле, " +
                    "антисептик Tikkurila Valtti Log глубоко проникает в волокна древесины и обеспечивает надежную защиту поверхности от биопоражений.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WoodOils,
                        CategoryEnums.WoodFacadeOils
                    }
                },

                // ---- Валтти Pro -----
                new PaintClass
                {
                    Name = "Valtti Pro",
                    Description = "Пленочно-лессирующая лазурь для защиты и отделки деревянных поверхностей снаружи помещений." +
                    "\r\n\r\nЛазурь Tikkurila Valtti Pro содержит воск и создает надежное атмосферостойкое покрытие, а глянцевый " +
                    "блеск не только придает поверхности декоративный эффект, но и надежно защищает ее от грязи и пыли." +
                    "\r\n\r\nВ состав лазури входит УФ-фильтр, который защищает древесину от солнечных лучей и сохраняет " +
                    "яркие оттенки глянцевого покрытия. Лазурь Tikkurila Valtti Pro колеруется в 40 цветов по каталогу Tikkurila «Valtti»," +
                    " а также доступна в 5 готовых цветах." +
                    "\r\n\r\nВ состав лазури Tikkurila Valtti Pro входят специальные добавки, которые защищают поверхность " +
                    "от плесени, синевы и гнили на многие годы. Сверхпрочная защитная лазурь с глянцевым покрытием Tikkurila " +
                    "Valtti Pro не оставит биопоражениям ни единого шанса!",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.Gloss
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.Fassade,
                        PaintObjectEnum.Fences,
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WoodOils,
                        CategoryEnums.WoodFacadeOils
                    }
                },

                // ---- Valtti Terrace Oil -----
                new PaintClass
                {
                    Name = "Valtti Terrace Oil",
                    Description = "Террасное масло для наружных деревянных поверхностей. Защищает древесину от ультрафиолета и " +
                    "придает поверхности высокую прочность. В масле Valtti Plus Terrace Oil до 75% от общего количества " +
                    "органического углерода заменено на био-составляющие (измерено в соответствии с ASTM D6866-18), что означает, " +
                    "что 18% от общего содержания продукта - биологический состав." +
                    "\r\n\r\nМасло Valtti Plus Terrcae Oil проникает в древесину и создает высокопрочную поверхность. Для масла Valtti " +
                    "Plus Terrace Oil 75% общего органического углерода заменено на био-составляющие (измерено в соответствии с ASTM D6866-18), " +
                    "что означает, что 18% общего содержания продукта - био-основа." +
                    "\r\n\r\nValtti Plus Terrace Oil необходимо использовать колерованным для обеспечения высокой износостойкости " +
                    "наружных поверхностей. Яркие интенсивные цвета увеличивают долговечность поверхности, так как она имеет " +
                    "дополнительную защиту специальными пигментами. Valtti Plus Terrace Oil выпускается в готовых цветах " +
                    "(коричневый, светло-серый, черный) или в базе под колеровку." +
                    "\r\n\r\nСоздает поверхность, защищенную от ультрафиолета, что особенно важно для террас и уличной мебели. " +
                    "Valtti Plus Terrace Oil быстро сохнет и легко наносится.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Outdoor
                    },
                    Thinner = PaintThinnerEnum.Solvent1050,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.NoColor
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WoodOils,
                        CategoryEnums.WoodFacadeOils
                    }
                },

                // ---- Pirtti -----
                new PaintClass
                {
                    Name = "Pirtti",
                    Description = "Акрилатная морилка. Пиртти предназначена для морения стен, потолков, полов, дверей " +
                    "и других деревянных поверхностей в доме. Эффектно подчеркивает природный рисунок материала. " +
                    "После нанесения морилки на пол обязательно покройте его лаком, который будет защищать дерево от грязи и влаги." +
                    "\r\n\r\nБесцветная морилка Пиртти колеруется по каталогу Тиккурила «Колеруемые лаки для интерьеров». " +
                    "Для получения более светлого оттенка просто разбавьте морилку водой, например, в соотношении 1:1. Более темного " +
                    "цвета можно добиться повторным нанесением морилки через 4-6 часов после высыхания первого слоя. " +
                    "\r\n\r\nНаносите морилку Пиртти губкой, кистью или распылением в один слой. Чтобы получить равномерный " +
                    "оттенок на сплошной поверхности, обрабатывайте ее без перерывов от начала до конца, а при обработке больших " +
                    "панельных поверхностей – несколько досок за раз.",
                    Consumption = 12,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Wood,
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.Floors,
                        PaintObjectEnum.Constructions,
                        PaintObjectEnum.Furniture,
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Doors,
                        PaintObjectEnum.Windows,
                        PaintObjectEnum.SkirtingBoards
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
                        CategoryEnums.WoodOils,
                        CategoryEnums.InteriorWoodOils
                    }
                },
            ];
        }
    }
}
