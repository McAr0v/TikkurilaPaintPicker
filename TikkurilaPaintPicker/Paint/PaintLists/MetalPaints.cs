using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint.PaintLists
{
    public class MetalPaints
    {
        public List<PaintClass> MetalPaintList { get; private set; }

        public MetalPaints()
        {
            MetalPaintList = new List<PaintClass>();
            // Здесь вы можете добавить краски для металлических красок
            MetalPaintList.Add
                (
                    new PaintClass
                    {
                        Name = "Miranol",
                        Description = "Тиксотропная алкидная эмаль с незначительным запахом\r\n\r\nУниверсальная и простая в использовании эмаль Tikkurila Miranol напоминает, сколько удовольствия может приносить работа руками. Она почти не пахнет и хорошо распределяется по поверхности, не образуя подтеков. Вы можете покрасить Tikkurila Miranol все - от лодок до детских игрушек. \r\n\r\nУдаропрочная желеобразная алкидная эмаль Tikkurila Miranol отлично подходит для окраски рабочих инструментов и велосипедов. Также вы можете обновить ей садовую мебель – яркие столики, кресла и скамейки станут настоящим украшением двора.\r\n\r\nВысокоглянцевая эмаль колеруется по каталогам цветов для внутренних и наружных работ Tikkurila. Для вашего удобства Tikkurila Miranol продается как в маленьких, так и в больших банках, что позволяет эффективнее расходовать объем. ",
                        Consumption = 12,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Metal, PaintMaterialEnum.Wood },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.FullGloss },
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.MetalConstructions, PaintObjectEnum.Furniture, PaintObjectEnum.Windows, PaintObjectEnum.Doors },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor },
                        Thinner = PaintThinnerEnum.Solvent1050,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> { 
                            CategoryEnums.Enamels, 
                            CategoryEnums.EnamelsForMetalConstructions,
                            CategoryEnums.EnamelsForRoofs,
                            CategoryEnums.EnamelsForFurniture,
                            CategoryEnums.EnamelsForGardenFurniture,
                            CategoryEnums.EnamelsForWindows
                        }
                    }
                );
            MetalPaintList.Add
                (
                    new PaintClass
                    {
                        Name = "Unica",
                        Description = "Алкидная краска.\r\n\r\nИспользуйте краску Уника для защиты металлических поверхностей – в особенности тех, которые требуют частого мытья: транспортных средств, оборудования, лодок, рабочих инструментов. Она также отлично защитит мебель и другие деревянные поверхности. \r\n\r\nПластмассовые поверхности – не самые простые для окраски, но краска Уника справляется со многими из них. Например, вы можете обработать ею надводные части лодок из пластмассы или стекловолокна, используя наиболее удобный инструмент: кисть, распылитель или валик с коротким ворсом.\r\n\r\nУника – особенная краска. Она с легкостью выдерживает воздействие разных смазочных масел и консистентных смазок, устойчива к уайт-спириту и денатурату. Краска не выгорает на солнце и будет долго украшать обработанную поверхность.",
                        Consumption = 12,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Metal, PaintMaterialEnum.Plastic, PaintMaterialEnum.Wood },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.SemiGloss },
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.MetalConstructions, PaintObjectEnum.Furniture, PaintObjectEnum.Windows, PaintObjectEnum.Doors },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor },
                        Thinner = PaintThinnerEnum.Solvent1050,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.Enamels,
                            CategoryEnums.EnamelsForMetalConstructions,
                            CategoryEnums.EnamelsForRoofs,
                            CategoryEnums.EnamelsForFurniture,
                            CategoryEnums.EnamelsForGardenFurniture,
                            CategoryEnums.EnamelsForWindows,
                            CategoryEnums.EnamelsForPlastic
                        }
                    }
                );

            MetalPaintList.Add
                (
                    new PaintClass
                    {
                        Name = "Helmi",
                        Description = "Акрилатная краска.\r\n\r\nВыбирая краску для мебели Tikkurila Helmi, вы выбираете из 20 000 оттенков гаммы Tikkurila «Симфония». Смелее экспериментируйте с цветами: яркий столик, шкаф или трюмо станут той вишенкой на торте, которая придаст палитре помещения завершенность и индивидуальность.\r\n\r\nкрилатная краска для мебели Tikkurila Helmi не желтеет со временем. Она легко наносится на новые деревянные, ДВП, ДСП или металлические поверхности внутри помещений. С ее помощью вы также можете перекрасить мебель, которая уже была окрашена алкидной или каталитической краской.\r\n\r\nTikkurila Helmi относится к высшему классу М1: она почти не пахнет и не выделяет в воздух летучих веществ. Экологичный продукт идеален для покраски детских игрушек. Полуматовое покрытие украшает поверхность сдержанным блеском, в то же время на нем практически не заметны отпечатки пальцев.",
                        Consumption = 12,
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Metal, PaintMaterialEnum.Wood },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.Matt, PaintGlossEnum.SemiMatte, PaintGlossEnum.Gloss },
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.MetalConstructions, PaintObjectEnum.Furniture, PaintObjectEnum.Windows, PaintObjectEnum.Doors },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor},
                        Thinner = PaintThinnerEnum.Water,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.Enamels,
                            CategoryEnums.EnamelsForMetalConstructions,
                            CategoryEnums.EnamelsForFurniture,
                        }
                    }
                );

            MetalPaintList.Add
                (
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
                        Materials = new List<PaintMaterialEnum> { PaintMaterialEnum.Metal, PaintMaterialEnum.Wood },
                        Gloss = new List<PaintGlossEnum> { PaintGlossEnum.Matt, PaintGlossEnum.SemiMatte, PaintGlossEnum.FullGloss },
                        Objects = new List<PaintObjectEnum> { PaintObjectEnum.MetalConstructions, PaintObjectEnum.Furniture, PaintObjectEnum.Windows, PaintObjectEnum.Doors },
                        Locations = new List<PaintLocationEnum> { PaintLocationEnum.Indoor, PaintLocationEnum.Outdoor },
                        Thinner = PaintThinnerEnum.Solvent1050,
                        Colors = new List<PaintColorEnum> { PaintColorEnum.DarkShades, PaintColorEnum.LightShades, PaintColorEnum.White },
                        Categories = new List<CategoryEnums> {
                            CategoryEnums.Enamels,
                            CategoryEnums.EnamelsForMetalConstructions,
                            CategoryEnums.EnamelsForRoofs,
                            CategoryEnums.EnamelsForFurniture,
                            CategoryEnums.EnamelsForGardenFurniture,
                            CategoryEnums.EnamelsForWindows,
                        }
                    }
                );
        }
    }
}
