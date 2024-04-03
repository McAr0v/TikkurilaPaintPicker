using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    /// <summary>
    /// Класс, хранящий в себе список водоэмульсионных красок
    /// </summary>
    public class WaterEmulsionPaints
    {
        public List<PaintClass> WaterEmulsionPaintList { get; private set; }

        public WaterEmulsionPaints()
        {
            WaterEmulsionPaintList =
            [
                // ДОБАВЛЯЕМ КРАСКИ

                // ---- ГАРМОНИЯ -----
                new PaintClass 
                { 
                    Name = "Harmony",
                    Description = "Интерьерная глубокоматовая экологичная краска, придающая поверхности бархатистый эффект." +
                    "\r\n\r\nИнтерьерная краска Tikkurila Harmony создает мягкую бархатистую поверхность, к которой так и хочется прикоснуться. " +
                    "Ее можно использовать при создании как минималистичных, так и богато декорированных интерьеров, ведь бархат – излюбленный материал королей и богемы." +
                    "\r\n\r\nTikkurila Harmony относится к высшему классу эмиссии строительных материалов М1. Такие материалы практически не " +
                    "выделяют вредных веществ. Выбрав ее для окраски детской комнаты, вы можете не опасаться за здоровье малыша." +
                    "\r\n\r\nИнтерьерную краску Tikkurila Harmony можно использовать для оштукатуренных, бетонных, зашпатлеванных, " +
                    "кирпичных, картонных, деревянных и гипсокартонных поверхностей. Она стойка к мытью, а глубокоматовый оттенок " +
                    "хорошо скроет мелкие недостатки поверхности.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum> 
                    { 
                        PaintMaterialEnum.Plasterboard, 
                        PaintMaterialEnum.Concrete, 
                        PaintMaterialEnum.Brick, 
                        PaintMaterialEnum.PlasteredSurface, 
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> 
                    { 
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.WallsInDryRooms, 
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                }
                ,
                // ---- ДЖОКЕР -----
                new PaintClass
                {
                    Name = "Joker",
                    Description = "Стойкая к мытью экологичная матовая интерьерная краска, " +
                    "создающая шелковистую поверхность. Не содержит органических растворителей." +
                    "\r\n\r\nИнтерьерная краска Tikkurila Joker разработана совместно с финской " +
                    "Ассоциацией по аллергическим и астматическим заболеваниям. Ее безопасность " +
                    "для здоровья подтверждена «Экознаком» Европейского Союза. Краска устойчива " +
                    "к влажной очистке и станет идеальным выбором для детской." +
                    "\r\n\r\nTikkurila Joker – одна из самых популярных красок Tikkurila и пользуется " +
                    "заслуженной любовью потребителей вот уже более 60 лет. Краска образует красивую " +
                    "матовую поверхность с шелковистым эффектом. Она быстро высыхает, все же оставляя " +
                    "достаточно времени на обработку поверхности без опасения появления «швов»." +
                    "\r\n\r\nБолее 20 000 оттенков доступны в палитре для колеровки краски Tikkurila " +
                    "Joker. При выборе цвета обратите внимание на обозначение базы краски: база А " +
                    "применяется для светлых оттенков, база С – для более темных и ярких тонов.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum> 
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> 
                    { 
                        PaintGlossEnum.Matt 
                    },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.WallsInDryRooms, 
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                }
                ,
                // --- ЛУЯ -----
                new PaintClass
                {
                    Name = "Luja",
                    Description = "Специальная акрилатная краска, содержащая противоплесневый компонент, защищающий поверхность." +
                    "\r\n\r\nПокрывная матовая краска Луя входит в состав влагоизоляционной системы " +
                    "Тиккурила «Луя – барьер против влаги». Вместе с другими компонентами этой системы она " +
                    "образует прочное покрытие, которое надежно противостоит влаге и плесени." +
                    "\r\n\r\nБлагодаря особым свойствам краска Луя используется при окраске влажных помещений: кухонь, " +
                    "прихожих, ванных комнат. Противоплесневый компонент в ее составе помогает поддерживать в доме чистоту " +
                    "и препятствует появлению грибка.\r\n\r\nЛуя выдерживает воздействие даже сильных моющих и дезинфекционных " +
                    "средств. Рекомендуется для окраски стен и потолков, от которых требуется особая стойкость к мытью и износу: " +
                    "в вестибюлях, лестничных клетках, коридорах и палатах больниц, помещениях предприятий пищевой промышленности.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum> 
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum> 
                    { 
                        PaintGlossEnum.Matt, 
                        PaintGlossEnum.SemiMatte, 
                        PaintGlossEnum.SemiGloss 
                    },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.WallsInDryRooms, 
                        PaintObjectEnum.WallsInWetRooms, 
                        PaintObjectEnum.CeilingsInDryRooms, 
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms,
                        CategoryEnums.WaterbornePaintsForWetRooms,
                    }
                }
                ,
                // ---- ЛУЯ КЕРАМИК ТАЙЛС -----
                new PaintClass
                {
                    Name = "Luja Ceramic Tiles",
                    Description = "Полуматовая краска для керамической плитки." +
                    "\r\n\r\nБлагодаря превосходным адгезионным качествам, грунтование поверхности перед окрашиванием не требуется. " +
                    "Подходит для любого вида глянцевой или матовой плитки. Ремонт с керамической плиткой Luja - это быстро и просто." +
                    "\r\n\r\nLuja Ceramic Tiles может быть заколерована в любой цвет на ваш выбор из широкого спектра интерьерных цветов Tikkurila." +
                    "\r\n\r\nОкрашенная керамическая плитка проста в уходе, ее поверхность чрезвычайно устойчива к горячей " +
                    "и холодной воде, шампуням, чистящим средствам и различным пятнам (масло, кетчуп, сок и т.д.).",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum> 
                    { 
                        PaintMaterialEnum.Ceramic 
                    },
                    Gloss = new List<PaintGlossEnum> 
                    { 
                        PaintGlossEnum.SemiMatte
                    },
                    Objects = new List<PaintObjectEnum> 
                    { 
                        PaintObjectEnum.WallsInDryRooms, 
                        PaintObjectEnum.WallsInWetRooms, 
                        PaintObjectEnum.CeilingsInDryRooms, 
                        PaintObjectEnum.CeilingsInWetRooms, 
                        PaintObjectEnum.Floors 
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForWetRooms,
                    }
                },

                // ---- СироМат -----
                new PaintClass
                {
                    Name = "Siro Himmea",
                    Description = "Водоразбавляемая потолочная краска без бликов. " +
                    "Краска Сиро Мат предназначена для окраски стен и потолков. Она отлично ложится на бетон, кирпич, картон, штукатурку и шпатлевку, " +
                    "а также древесностружечные, гипсовые и древесноволокнистые плиты. Подходит для обоев под покраску. " +
                    "\r\n\r\nАкрилатное связующее в составе краски Сиро Мат обеспечивает ей великолепную укрывистость. Краска легко наносится кистью, " +
                    "валиком или распылением. Высохшая поверхность – ровная и совершенно матовая, как чистый лист, лежащий перед художником." +
                    "\r\n\r\nИстории большинства удачных интерьеров начинаются с выбора цвета для стен и потолка. Вы можете оставить их совершенно белыми, " +
                    "а можете заколеровать краску Сиро Мат в один из светлых оттенков гаммы «Тиккурила Симфония», которые легко сочетать с другими цветами.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.CeilingsInDryRooms,
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                },

                // ---- Евро Смарт 2 -----
                new PaintClass
                {
                    Name = "Euro Smart 2",
                    Description = "Водоразбавляемая краска для стен и потолков. Нужно покрасить быстро и качественно? " +
                    "Тогда Tikkurila Euro Smart 2 – это лучший выбор для первого слоя покраски! Эта умная краска одинаково удобна " +
                    "при нанесении на потолок и на стены и обладает отличными малярными характеристиками. Она идеальна для быстрой " +
                    "покраски и образует гладкое покрытие с высокими декоративными характеристиками. " +
                    "\r\n\r\nВы красите в первый раз и переживаете за результат? Не бойтесь, с Tikkurila Euro Smart 2 красить совсем не сложно! " +
                    "Она не разбрызгивается и прекрасно наносится. Благодаря этим качествам краска отлично подходит как опытным, так и начинающим малярам." +
                    "\r\n\r\nВы не любите запах краски и переживаете за свое здоровье и здоровье своих близких во время покраски? " +
                    "Выбирайте Tikkurila Euro Smart 2! Эта краска обладает нейтральным запахом. Она безопасна для здоровья и " +
                    "соответствует европейским экологическим нормам по содержанию летучих органических веществ (Евродиректива VOC). " +
                    "Также Euro Smart 2 может использоваться в детских учреждениях и помещениях административной " +
                    "группы лечебно-профилактических учреждений.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                },

                // ---- Евро White -----
                new PaintClass
                {
                    Name = "Euro White",
                    Description = "Водоразбавляемая краска для потолка. Краска Tikkurila Euro White позволит вам создать потолок своей мечты!  " +
                    "Она разработана с применением самых современных технологий, что позволяет уменьшить поглощение солнечного света и обеспечить " +
                    "долговременную яркость и белизну потолка. Уникальные микросферы в рецептуре эффективно рассеивают свет, придавая покрашенному " +
                    "потолку безупречный вид идеальной матовой поверхности." +
                    "\r\n\r\nХорошо? Еще лучше! Добейтесь идеального результата с " +
                    "Tikkurila Euro White! Ведь эта краска также обладает великолепной укрывистостью и низким боковым блеском. " +
                    "Эти качества позволяют ей превосходно скрывать мелкие дефекты поверхности. " +
                    "Достаточно одного-двух слоев – и ваш потолок уже выглядит безупречно." +
                    "\r\n\r\nВы не любите запах краски и переживаете за свое здоровье и здоровье своих близких во время покраски? " +
                    "Выбирайте Tikkurila Euro White! Эта краска обладает нейтральным запахом. Она безопасна для здоровья и соответствует " +
                    "европейским экологическим нормам по содержанию летучих органических веществ (Евродиректива VOC). Еще одним " +
                    "свидетельством экологичности краски является то, что Tikkurila Euro White может использоваться в детских учреждениях " +
                    "и помещениях административной группы лечебно-профилактических учреждений",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.CeilingsInDryRooms
                    },
                    Locations = new List<PaintLocationEnum>
                    {
                        PaintLocationEnum.Indoor
                    },
                    Thinner = PaintThinnerEnum.Water,
                    Colors = new List<PaintColorEnum>
                    {
                        PaintColorEnum.White
                    },
                    Categories = new List<CategoryEnums>
                    {
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                },

                // ---- Евро матт 3 -----
                new PaintClass
                {
                    Name = "Euro Matt 3",
                    Description = "Водоразбавляемая краска для стен и потолков. Хорошая краска для гостиной, спальни или детской" +
                    " – самый ответственный выбор, не правда ли? Доверьтесь Tikkurila Euro Matt 3, ведь эта краска гарантирует " +
                    "превосходное качество глубокоматовых поверхностей стен, идеальную и полную гамму цветов. Она создана " +
                    "специально для окраски стен и потолков жилых комнат: спален, гостиных и детских. Кроме того, устойчивое к " +
                    "мытью покрытие выдержит более 5000 проходов щеткой. Вы сможете легко поддерживать в доме чистоту, протирая " +
                    "стены без ущерба для внешнего вида поверхностей, когда это понадобится." +
                    "\r\n\r\nПерекрашиваете стены заново? Или красите по свежей отштукатуренной поверхности? Tikkurila Euro Matt 3 " +
                    "справится с любой задачей! Благодаря великолепной укрывистости, краска подходит как для первичной покраски, " +
                    "так и для нанесения на покрашенные ранее поверхности. Ее усовершенствованные малярные свойства позволяют достичь " +
                    "отличного результата при нанесении всего 1-2 слоев." +
                    "\r\n\r\nВы не любите запах краски и переживаете за свое здоровье и здоровье своих близких во время покраски? " +
                    "Выбирайте Tikkurila Euro Matt 3! Эта краска обладает нейтральным запахом. Она безопасна для здоровья и " +
                    "соответствует европейским экологическим нормам по содержанию летучих органических веществ (Евродиректива VOC). " +
                    "Также Tikkurila Euro Matt 3 может использоваться в детских учреждениях и помещениях административной " +
                    "группы лечебно-профилактических учреждений",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.FullMatt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                },

                // ---- Eвро Повер 7 -----
                new PaintClass
                {
                    Name = "Euro Power 7",
                    Description = "Водоразбавляемая краска для стен и потолков. Ищете краску, которая лучше всего подойдет " +
                    "для коридора или прихожей? Выбирайте Tikkurila Euro Power 7! Это - отличная стойкая краска с хорошей укрывной " +
                    "способностью и экономным расходом. Кроме того, покрашенная поверхность устойчива к многократному интенсивному " +
                    "мытью с применением бытовых неабразивных моющих средств и выдерживает 10.000 проходов щеткой. Благодаря этим свойствам " +
                    "Tikkurila Euro Power 7 зачастую используют в помещениях, требующих частой уборки, а также в магазинах, офисах, " +
                    "в кафе, ресторанах и зонах ожидания в публичных местах." +
                    "\r\n\r\nВам нужны яркие и насыщенные цвета на стенах, которые не тускнеют со временем? Tikkurila Euro Power 7 – " +
                    "вот, что для этого нужно! Краска образует прочное и гладкое покрытие, с непревзойденной долговечностью цвета. " +
                    "Как результат – покрашенная поверхность надолго сохранит свежий внешний вид, а стойкие цвета дополнят современный интерьер. " +
                    "\r\n\r\nВы не любите запах краски и переживаете за свое здоровье и здоровье своих близких во время покраски? " +
                    "Выбирайте Tikkurila Euro Power 7! Эта краска обладает нейтральным запахом. Она безопасна для здоровья и " +
                    "соответствует европейским экологическим нормам по содержанию летучих органических веществ (Евродиректива VOC). " +
                    "Еще одним свидетельством экологичности краски является то, что Tikkurila Euro Power 7 может использоваться в " +
                    "детских учреждениях и помещениях административной группы лечебно-профилактических учреждений.",
                    Consumption = 10,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.Matt
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms
                    }
                },

                // --- Евро экстра 20 -----
                new PaintClass
                {
                    Name = "Euro Extra 20",
                    Description = "Водоразбавляемая краска для стен и потолков в помещениях с умеренной и повышенной влажностью." +
                    "\r\n\r\nВам нужно покрасить стены на кухне или в ванной? А может быть в другом помещении, требующем особо " +
                    "стойкого покрытия? В этом случае Tikkurila Euro Extra 20 – лучший выбор! Благодаря особой рецептуре, краска " +
                    "образует усиленное покрытие, устойчивое к интенсивному мытью. Также она устойчива к воздействию пара от бытовых " +
                    "приборов (чайника, пароварки) и образованию конденсата и защищает поверхности от плесени и грибка. Сочетание " +
                    "этих качеств гарантирует вашим стенам настоящую суперзащиту!" +
                    "\r\n\r\nПятна на стенах? Нестрашно! Специальная формула Tikkurila Euro Extra 20 позволяет легко очистить " +
                    "поверхность от большинства бытовых загрязнений. При этом стены сохраняют насыщенность цвета даже после " +
                    "многократного мытья с применением моющих средств. Кроме того, краска выдерживает более 10 000 проходов щеткой. " +
                    "Покрасьте поверхность Tikkurila Euro Extra 20 - и мытье стен на кухне и в ванной перестанет быть проблемой! " +
                    "\r\n\r\nВы не любите запах краски и переживаете за свое здоровье и здоровье своих близких во время покраски? " +
                    "Выбирайте Tikkurila Euro Extra 20! Эта краска обладает нейтральным запахом. Она безопасна для здоровья и " +
                    "соответствует европейским экологическим нормам по содержанию летучих органических веществ (Евродиректива VOC). " +
                    "Кроме того, Tikkurila Euro Extra 20 может использоваться в детских учреждениях и помещениях административной " +
                    "группы лечебно-профилактических учреждений.",
                    Consumption = 8,
                    Materials = new List<PaintMaterialEnum>
                    {
                        PaintMaterialEnum.Plasterboard,
                        PaintMaterialEnum.Concrete,
                        PaintMaterialEnum.Brick,
                        PaintMaterialEnum.PlasteredSurface,
                        PaintMaterialEnum.Wood,
                        PaintMaterialEnum.Fiberboard,
                        PaintMaterialEnum.Chipboard,
                        PaintMaterialEnum.Osb
                    },
                    Gloss = new List<PaintGlossEnum>
                    {
                        PaintGlossEnum.SemiMatte
                    },
                    Objects = new List<PaintObjectEnum>
                    {
                        PaintObjectEnum.WallsInDryRooms,
                        PaintObjectEnum.WallsInWetRooms,
                        PaintObjectEnum.CeilingsInDryRooms,
                        PaintObjectEnum.CeilingsInWetRooms,
                        PaintObjectEnum.Constructions
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
                        CategoryEnums.WaterbornePaints,
                        CategoryEnums.WaterbornePaintsForDryRooms,
                        CategoryEnums.WaterbornePaintsForWetRooms,
                    }
                }




,
            ];

        }
    }
}
