using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class WaterEmulsionPaints
    {
        public List<PaintClass> WaterEmulsionPaintList { get; private set; }

        public WaterEmulsionPaints()
        {
            WaterEmulsionPaintList = new List<PaintClass>();
            // Здесь вы можете добавить краски для водоэмульсионных красок
            WaterEmulsionPaintList.Add
                (
                    new PaintClass { 
                        Name = "Harmony",
                        Description = "Интерьерная глубокоматовая экологичная краска, придающая поверхности бархатистый эффект.\r\n\r\nИнтерьерная краска Tikkurila Harmony создает мягкую бархатистую поверхность, к которой так и хочется прикоснуться. Ее можно использовать при создании как минималистичных, так и богато декорированных интерьеров, ведь бархат – излюбленный материал королей и богемы.\r\n\r\nTikkurila Harmony относится к высшему классу эмиссии строительных материалов М1. Такие материалы практически не выделяют вредных веществ. Выбрав ее для окраски детской комнаты, вы можете не опасаться за здоровье малыша.\r\n\r\nИнтерьерную краску Tikkurila Harmony можно использовать для оштукатуренных, бетонных, зашпатлеванных, кирпичных, картонных, деревянных и гипсокартонных поверхностей. Она стойка к мытью, а глубокоматовый оттенок хорошо скроет мелкие недостатки поверхности.",
                        Consumption = 10,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Plasterboard, PaintMaterialEnum.Concrete, PaintMaterialEnum.Brick, PaintMaterialEnum.PlasteredSurface, PaintMaterialEnum.Wood},
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullMatt},
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.Walls, PaintObjectEnum.Ceilings },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.ForWetRooms },
                        Thinner = PaintThinnerEnum.Water,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.WaterbornePaints,
                            CategoryEnums.WaterbornePaintsForDryRooms
                        }
                    }
                );
            WaterEmulsionPaintList.Add
                (
                    new PaintClass
                    {
                        Name = "Joker",
                        Description = "Стойкая к мытью экологичная матовая интерьерная краска, создающая шелковистую поверхность. Не содержит органических растворителей.\r\n\r\nИнтерьерная краска Tikkurila Joker разработана совместно с финской Ассоциацией по аллергическим и астматическим заболеваниям. Ее безопасность для здоровья подтверждена «Экознаком» Европейского Союза. Краска устойчива к влажной очистке и станет идеальным выбором для детской.\r\n\r\nTikkurila Joker – одна из самых популярных красок Tikkurila и пользуется заслуженной любовью потребителей вот уже более 60 лет. Краска образует красивую матовую поверхность с шелковистым эффектом. Она быстро высыхает, все же оставляя достаточно времени на обработку поверхности без опасения появления «швов».\r\n\r\nБолее 20 000 оттенков доступны в палитре для колеровки краски Tikkurila Joker. При выборе цвета обратите внимание на обозначение базы краски: база А применяется для светлых оттенков, база С – для более темных и ярких тонов.",
                        Consumption = 10,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Plasterboard, PaintMaterialEnum.Concrete, PaintMaterialEnum.Brick, PaintMaterialEnum.PlasteredSurface, PaintMaterialEnum.Wood },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.Matt },
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.Walls, PaintObjectEnum.Ceilings },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.ForWetRooms },
                        Thinner = PaintThinnerEnum.Water,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.WaterbornePaints,
                            CategoryEnums.WaterbornePaintsForDryRooms
                        }
                    }
                );

            WaterEmulsionPaintList.Add
                (
                    new PaintClass
                    {
                        Name = "Luja",
                        Description = "Специальная акрилатная краска, содержащая противоплесневый компонент, защищающий поверхность.\r\n\r\nПокрывная матовая краска Луя входит в состав влагоизоляционной системы Тиккурила «Луя – барьер против влаги». Вместе с другими компонентами этой системы она образует прочное покрытие, которое надежно противостоит влаге и плесени.\r\n\r\nБлагодаря особым свойствам краска Луя используется при окраске влажных помещений: кухонь, прихожих, ванных комнат. Противоплесневый компонент в ее составе помогает поддерживать в доме чистоту и препятствует появлению грибка.\r\n\r\nЛуя выдерживает воздействие даже сильных моющих и дезинфекционных средств. Рекомендуется для окраски стен и потолков, от которых требуется особая стойкость к мытью и износу: в вестибюлях, лестничных клетках, коридорах и палатах больниц, помещениях предприятий пищевой промышленности.",
                        Consumption = 8,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Plasterboard, PaintMaterialEnum.Concrete, PaintMaterialEnum.Brick, PaintMaterialEnum.PlasteredSurface, PaintMaterialEnum.Wood },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.Matt, PaintGlossEnum.SemiMatte, PaintGlossEnum.SemiGloss },
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.Walls, PaintObjectEnum.Ceilings },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.ForWetRooms },
                        Thinner = PaintThinnerEnum.Water,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.WaterbornePaints,
                            CategoryEnums.WaterbornePaintsForDryRooms,
                            CategoryEnums.WaterbornePaintsForWetRooms,
                        }
                    }
                );

            WaterEmulsionPaintList.Add
                (
                    new PaintClass
                    {
                        Name = "Luja Ceramic Tiles",
                        Description = "Полуматовая краска для керамической плитки.\r\n\r\nБлагодаря превосходным адгезионным качествам, грунтование поверхности перед окрашиванием не требуется. Подходит для любого вида глянцевой или матовой плитки. Ремонт с керамической плиткой Luja - это быстро и просто.\r\n\r\nLuja Ceramic Tiles может быть заколерована в любой цвет на ваш выбор из широкого спектра интерьерных цветов Tikkurila.\r\n\r\nОкрашенная керамическая плитка проста в уходе, ее поверхность чрезвычайно устойчива к горячей и холодной воде, шампуням, чистящим средствам и различным пятнам (масло, кетчуп, сок и т.д.).",
                        Consumption = 8,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Ceramic },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiMatte},
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.Walls, PaintObjectEnum.Ceilings, PaintObjectEnum.Floors },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.ForWetRooms },
                        Thinner = PaintThinnerEnum.Water,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.WaterbornePaints,
                            CategoryEnums.WaterbornePaintsForWetRooms,
                        }
                    }
                );

        }
    }
}
