using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkurilaPaintPicker.Paint.Enums
{
    public enum CategoryEnums
    {
        FacadePaints,
        FacadePaintsForWood,
        FacadePaintsForMineralSurfaces,
        WoodPreservatives,
        SaunaPreservatives,
        WoodFacadePreservatives,
        InteriorWoodPreservatives,
        Varnishes,
        VarnishesForWallsAndCeilings,
        VarnishesForFurniture,
        VarnishesForFloors,
        WaterbornePaints,
        WaterbornePaintsForDryRooms,
        WaterbornePaintsForWetRooms,
        Primers,
        PrimersForProblematicSurfaces,
        PrimersForWood,
        PrimersForMetal,
        PrimersForMineralSurfaces,
        Enamels,
        EnamelsForMetalConstructions,
        EnamelsForFurniture,
        EnamelsForWindows,
        EnamelsForPlastic,
        EnamelsForFloors,
        EnamelsForRoofs,
        EnamelsForGardenFurniture,
        Solvents,
        CleaningAgentsAndAdditives
    }

    public static class CategoryTranslator
    {
        public static string Translate(CategoryEnums category)
        {
            switch (category)
            {
                case CategoryEnums.FacadePaints:
                    return "Фасадные краски";
                case CategoryEnums.FacadePaintsForWood:
                    return "Фасадные краски для дерева";
                case CategoryEnums.FacadePaintsForMineralSurfaces:
                    return "Фасадные краски для минеральных поверхностей";
                case CategoryEnums.WoodPreservatives:
                    return "Пропитки для дерева";
                case CategoryEnums.SaunaPreservatives:
                    return "Пропитки для сауны";
                case CategoryEnums.WoodFacadePreservatives:
                    return "Пропитки для деревянных фасадов";
                case CategoryEnums.InteriorWoodPreservatives:
                    return "Пропитки для внутренних работ";
                case CategoryEnums.Varnishes:
                    return "Лаки";
                case CategoryEnums.VarnishesForWallsAndCeilings:
                    return "Лаки для стен и потолков";
                case CategoryEnums.VarnishesForFurniture:
                    return "Лаки для мебели";
                case CategoryEnums.VarnishesForFloors:
                    return "Лаки для полов";
                case CategoryEnums.WaterbornePaints:
                    return "Водоэмульсионные краски";
                case CategoryEnums.WaterbornePaintsForDryRooms:
                    return "Водоэмульсионные краски для сухих помещений";
                case CategoryEnums.WaterbornePaintsForWetRooms:
                    return "Водоэмульсионные краски для влажных помещений";
                case CategoryEnums.Primers:
                    return "Грунтовки";
                case CategoryEnums.PrimersForProblematicSurfaces:
                    return "Грунтовки для проблемных поверхностей";
                case CategoryEnums.PrimersForWood:
                    return "Грунтовки для дерева";
                case CategoryEnums.PrimersForMetal:
                    return "Грунтовки для металла";
                case CategoryEnums.PrimersForMineralSurfaces:
                    return "Грунтовки для минеральных поверхностей";
                case CategoryEnums.Enamels:
                    return "Эмали";
                case CategoryEnums.EnamelsForMetalConstructions:
                    return "Эмали для металлоконструкций";
                case CategoryEnums.EnamelsForFurniture:
                    return "Эмали для мебели";
                case CategoryEnums.EnamelsForWindows:
                    return "Эмали для окон";
                case CategoryEnums.EnamelsForPlastic:
                    return "Эмали для пластика";
                case CategoryEnums.EnamelsForFloors:
                    return "Эмали для полов";
                case CategoryEnums.EnamelsForRoofs:
                    return "Эмали для крыш";
                case CategoryEnums.EnamelsForGardenFurniture:
                    return "Эмали для садовой мебели";
                case CategoryEnums.Solvents:
                    return "Растворители";
                case CategoryEnums.CleaningAgentsAndAdditives:
                    return "Моющие средства и добавки";
                default:
                    return "Неизвестная категория";
            }
        }

        public static string GetDescription(CategoryEnums category)
        {
            switch (category)
            {
                case CategoryEnums.FacadePaints:
                    return "Эти краски используются для окраски стен снаружи помещения.";
                case CategoryEnums.FacadePaintsForWood:
                    return "Эти краски специально разработаны для окраски деревянных поверхностей на фасадах зданий.";
                case CategoryEnums.FacadePaintsForMineralSurfaces:
                    return "Эти краски предназначены для окраски минеральных поверхностей на фасадах зданий.";
                case CategoryEnums.WoodPreservatives:
                    return "Пропитки для дерева обеспечивают защиту от влаги, гниения и насекомых.";
                case CategoryEnums.SaunaPreservatives:
                    return "Пропитки для сауны используются для защиты деревянных поверхностей в сауне от воздействия высокой влажности и температуры.";
                case CategoryEnums.WoodFacadePreservatives:
                    return "Пропитки для деревянных фасадов обеспечивают защиту и долговечность деревянных элементов фасада.";
                case CategoryEnums.InteriorWoodPreservatives:
                    return "Пропитки для внутренних работ применяются для защиты и укрепления древесины внутри помещений.";
                case CategoryEnums.Varnishes:
                    return "Лаки используются для создания защитного и декоративного покрытия на различных поверхностях.";
                case CategoryEnums.VarnishesForWallsAndCeilings:
                    return "Лаки для стен и потолков создают прочное и долговечное покрытие на поверхностях внутри помещений.";
                case CategoryEnums.VarnishesForFurniture:
                    return "Лаки для мебели придают ей блеск, защищают от влаги и царапин.";
                case CategoryEnums.VarnishesForFloors:
                    return "Лаки для полов обеспечивают защиту от истирания, влаги и царапин, а также создают эстетичное покрытие.";
                case CategoryEnums.WaterbornePaints:
                    return "Водоэмульсионные краски имеют водную основу и характеризуются безопасностью и экологичностью.";
                case CategoryEnums.WaterbornePaintsForDryRooms:
                    return "Водоэмульсионные краски для сухих помещений идеально подходят для окраски стен и потолков в жилых комнатах.";
                case CategoryEnums.WaterbornePaintsForWetRooms:
                    return "Водоэмульсионные краски для влажных помещений обладают высокой стойкостью к влажности и образованию плесени.";
                case CategoryEnums.Primers:
                    return "Грунтовки создают основу для последующего нанесения краски, обеспечивая лучшее сцепление и защиту поверхности.";
                case CategoryEnums.PrimersForProblematicSurfaces:
                    return "Грунтовки для проблемных поверхностей предназначены для подготовки сложных и неровных поверхностей перед окраской.";
                case CategoryEnums.PrimersForWood:
                    return "Грунтовки для дерева обеспечивают защиту и лучшее сцепление краски с древесиной.";
                case CategoryEnums.PrimersForMetal:
                    return "Грунтовки для металла предотвращают коррозию и обеспечивают качественное покрытие на металлических поверхностях.";
                case CategoryEnums.PrimersForMineralSurfaces:
                    return "Грунтовки для минеральных поверхностей обеспечивают лучшее сцепление краски с бетоном, кирпичом и другими минеральными материалами.";
                case CategoryEnums.Enamels:
                    return "Эмали используются для создания долговечного и устойчивого к воздействию внешних факторов покрытия.";
                case CategoryEnums.EnamelsForMetalConstructions:
                    return "Эмали для металлоконструкций предназначены для защиты и декоративной отделки металлических конструкций.";
                case CategoryEnums.EnamelsForFurniture:
                    return "Эмали для мебели создают стойкое и красивое покрытие, защищая дерево от влаги и царапин.";
                case CategoryEnums.EnamelsForWindows:
                    return "Эмали для окон обеспечивают защиту и долговечность оконных рам и откосов.";
                case CategoryEnums.EnamelsForPlastic:
                    return "Эмали для пластика создают стойкое и красивое покрытие на пластиковых поверхностях.";
                case CategoryEnums.EnamelsForFloors:
                    return "Эмали для полов обладают высокой стойкостью к истиранию и воздействию химических веществ.";
                case CategoryEnums.EnamelsForRoofs:
                    return "Эмали для крыш обеспечивают защиту от влаги, солнечных лучей и механических повреждений.";
                case CategoryEnums.EnamelsForGardenFurniture:
                    return "Эмали для садовой мебели создают долговечное и красивое покрытие на металлических и деревянных элементах садовой мебели.";
                case CategoryEnums.Solvents:
                    return "Растворители используются для разбавления красок, очистки инструментов и удаления старых покрытий.";
                case CategoryEnums.CleaningAgentsAndAdditives:
                    return "Моющие средства и добавки предназначены для очистки поверхностей перед покраской и улучшения свойств краски.";
                default:
                    return "Описание отсутствует";
            }
        }

        public static List<CategoryEnums> GetCategoriesList(CategoryEnums category)
        {
            switch (category)
            {
                case CategoryEnums.FacadePaints:
                    return new List<CategoryEnums> 
                    {
                        CategoryEnums.FacadePaintsForWood,
                        CategoryEnums.FacadePaintsForMineralSurfaces
                    };
                
                case CategoryEnums.WoodPreservatives:
                    return new List<CategoryEnums>
                    {
                        CategoryEnums.SaunaPreservatives,
                        CategoryEnums.WoodFacadePreservatives,
                        CategoryEnums.InteriorWoodPreservatives,
                    };
               
                case CategoryEnums.Varnishes:
                    return new List<CategoryEnums>
                    {
                        CategoryEnums.VarnishesForWallsAndCeilings,
                        CategoryEnums.VarnishesForFurniture,
                        CategoryEnums.VarnishesForFloors,
                    };
                
                case CategoryEnums.WaterbornePaints:
                    return new List<CategoryEnums>
                    {
                        CategoryEnums.WaterbornePaintsForDryRooms,
                        CategoryEnums.WaterbornePaintsForWetRooms,
                    };
                
                case CategoryEnums.Primers:
                    return new List<CategoryEnums>
                    {
                        CategoryEnums.PrimersForProblematicSurfaces,
                        CategoryEnums.PrimersForWood,
                        CategoryEnums.PrimersForMetal,
                        CategoryEnums.PrimersForMineralSurfaces,
                    };
                
                case CategoryEnums.Enamels:
                    return new List<CategoryEnums>
                    {
                        CategoryEnums.EnamelsForMetalConstructions,
                        CategoryEnums.EnamelsForFurniture,
                        CategoryEnums.EnamelsForWindows,
                        CategoryEnums.EnamelsForPlastic,
                        CategoryEnums.EnamelsForFloors,
                        CategoryEnums.EnamelsForRoofs,
                        CategoryEnums.EnamelsForGardenFurniture,

                    };

                default:
                    return new List<CategoryEnums>();
            }
        }

    }


}
