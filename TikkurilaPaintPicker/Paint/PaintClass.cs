using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens.PaintLayers;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint.Enums;
using static TikkurilaPaintPicker.Design.Screens.PaintsScreens.PaintViewScreen;

namespace TikkurilaPaintPicker.Paint
{
    public class PaintClass
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Consumption { get; set; } = 0;
        public List<PaintMaterialEnum> Materials { get; set; } = new List<PaintMaterialEnum>();
        public List<PaintObjectEnum> Objects { get; set; } = new List<PaintObjectEnum>();
        public List<PaintLocationEnum> Locations { get; set; } = new List<PaintLocationEnum>();
        public PaintThinnerEnum Thinner { get; set; } = PaintThinnerEnum.NotChosen;
        public List<PaintColorEnum> Colors { get; set; } = new List<PaintColorEnum>();
        public List<PaintGlossEnum> Gloss { get; set; } = new List<PaintGlossEnum>();
        public List<CategoryEnums> Categories { get; set; } = new List<CategoryEnums>();


        public string GenerateImageName()
        {
            string name = Name;
            return name.Replace(" ", "_").ToLower();
        }

        public static PaintClass GetEmptyPaint() 
        {
            return new PaintClass()
            {
                Name = "",
                Description = "",
                Consumption = 0,
                Materials = new List<PaintMaterialEnum>() { },
                Objects = new List<PaintObjectEnum>() { },
                Locations = new List<PaintLocationEnum>() { },
                Thinner = PaintThinnerEnum.Water,
                Colors = new List<PaintColorEnum>() { },
                Categories = new List<CategoryEnums>() { },
            };
        }

        public Frame GetProductOptionsFrame(NavigateToPageDelegate navigateToPage) 
        {
            StackLayout views = new StackLayout()
            {
                Spacing = 20
            };

            StackLayout headlineAndDesc = new StackLayout()
            {
                Spacing = 5,
                Margin = new Thickness(0, 0, 0, 10)
            };

            Label headline = CustomWidgets.CustomText(
                    text: "Технические характеристики:",
                    textColor: CustomColors.Black,
                    textState: TextState.HeadlineMedium,
                    horizontalAligment: TextAlignment.Start
                );

            Label desc = CustomWidgets.CustomText(
                    text: "Основные данные о краске из технической спецификации",
                    textColor: CustomColors.Black,
                    textState: TextState.DescMedium,
                    horizontalAligment: TextAlignment.Start
                );

            headlineAndDesc.Add( headline );

            headlineAndDesc.Add( desc );

            views.Add( headlineAndDesc );

            views.Children.Add(GetGrid(OptionsEnums.PaintColors, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintGloss, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintLocation, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintMaterials, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintObjects, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintThinner, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintConsumption, navigateToPage));
            views.Children.Add(GetGrid(OptionsEnums.PaintCategories, navigateToPage));

            return new Frame
            {
                Content = views,
                HasShadow = true,
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10
            };

        }

        private Grid GetGrid(OptionsEnums option, NavigateToPageDelegate navigateToPage)
        {

            Label headline = CustomWidgets.CustomText(
                    text: OptionsClass.GetOptionsName(option),
                    textColor: CustomColors.Black,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

            headline.FontAttributes = FontAttributes.Bold;

            Grid grid = new Grid
            {
                //Padding = new Thickness(10),
                ColumnSpacing = 10,
                RowSpacing = 10,
            };

            // Первая колонка, занимающая 1/3 ширины экрана
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // Вторая колонка, занимающая оставшуюся часть ширины
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });



            StackLayout stack = new StackLayout();

            switch (option)
            {
                case OptionsEnums.PaintLocation: stack = GetPaintLocation(); break;
                case OptionsEnums.PaintMaterials: stack = GetMaterials(); break;
                case OptionsEnums.PaintColors: stack = GetColors(); break;
                case OptionsEnums.PaintGloss: stack = GetGloss(); break;
                case OptionsEnums.PaintObjects: stack = GetObjects(); break;
                case OptionsEnums.PaintThinner: stack = GetThinner(); break;
                case OptionsEnums.PaintConsumption: stack = GetConsumption(); break;
                case OptionsEnums.PaintCategories: stack = GetCategories(navigateToPage); break;
            }

            stack.Spacing = 5;

            grid.Add(headline, 0, 0);
            grid.Add(stack, 1, 0);

            return grid;
        }

        private StackLayout GetObjects() 
        {
            StackLayout stack = new StackLayout();

            foreach (PaintObjectEnum objects in Objects)
            {
                Label label = CustomWidgets.CustomText(
                    text: PaintObject.GetPaintObjectName(objects),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

                stack.Children.Add(label);
            }

            return stack;


        }

        private StackLayout GetPaintLocation()
        {
            StackLayout stack = new StackLayout();

            foreach (PaintLocationEnum location in Locations)
            {
                Label label = CustomWidgets.CustomText(
                    text: PaintLocation.GetPaintLocationString(location),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

                stack.Children.Add(label);
            }

            return stack;


        }

        private StackLayout GetMaterials()
        {
            StackLayout stack = new StackLayout();

            foreach (PaintMaterialEnum material in Materials)
            {
                Label label = CustomWidgets.CustomText(
                    text: PaintMaterial.GetPaintMaterialName(material),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

                stack.Children.Add(label);
            }

            return stack;


        }

        private StackLayout GetColors()
        {
            StackLayout stack = new StackLayout();

            foreach (PaintColorEnum color in Colors)
            {
                Label label = CustomWidgets.CustomText(
                    text: PaintColor.GetPaintColorName(color),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

                stack.Children.Add(label);
            }

            return stack;


        }

        private StackLayout GetGloss()
        {
            StackLayout stack = new StackLayout();

            foreach (PaintGlossEnum gloss in Gloss)
            {
                Label label = CustomWidgets.CustomText(
                    text: PaintGloss.GetGlossName(gloss),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

                stack.Children.Add(label);
            }

            return stack;


        }

        private StackLayout GetThinner()
        {
            StackLayout stack = new StackLayout();

            Label label = CustomWidgets.CustomText(
                    text: PaintThinner.getThinnerName(Thinner),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

            stack.Children.Add(label);

            return stack;


        }

        private StackLayout GetConsumption()
        {
            StackLayout stack = new StackLayout();


            Label label = CustomWidgets.CustomText(
                    text: $"{Consumption} кв.м/л",
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

            stack.Children.Add(label);

            return stack;


        }

        private StackLayout GetCategories(NavigateToPageDelegate navigateToPage)
        {
            StackLayout stack = new StackLayout();

            foreach (CategoryEnums category in Categories)
            {
                Label label = CustomWidgets.CustomText(
                    text: CategoryTranslator.Translate(category),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start,
                    underline: TextDecorations.Underline
                );

                label.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(async () =>
                    {
                        await navigateToPage(category);

                    })
                });

                stack.Children.Add(label);

                
            }

            

            return stack;


        }

        public bool CheckLocations() 
        {
            return Locations.Count > 0;
        }

        public bool CheckObjects()
        {
            return Objects.Count > 0;
        }

        public bool CheckMaterials()
        {
            return Materials.Count > 0;
        }
        public bool CheckColors()
        {
            return Colors.Count > 0;
        }
        public bool CheckThinner()
        {
            return Thinner != PaintThinnerEnum.NotChosen;
        }
        public bool CheckGloss()
        {
            return Gloss.Count > 0;
        }

        public Frame GetAllAnswers()
        {
            string waterbornText = Thinner == PaintThinnerEnum.Solvent1050 ? "Не обязательно" : "Да";

            StackLayout result = new StackLayout();

            Label headline = CustomWidgets.CustomText(
                text: $"Ваши ответы:",
                textColor: CustomColors.Black,
                textState: TextState.HeadlineSmall
                );

            headline.Margin = new Thickness(0, 0, 0, 10);

            Label location = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetHeadline(layer: PaintLayerEnum.LocationEnum)} - {PaintLocation.GetPaintLocationString(Locations[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label materials = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetHeadline(layer: PaintLayerEnum.MaterialEnum)} - {PaintMaterial.GetPaintMaterialName(Materials[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label objects = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetHeadline(layer: PaintLayerEnum.ObjectEnum)} - {PaintObject.GetPaintObjectName(Objects[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label colors = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetHeadline(layer: PaintLayerEnum.ColorsEnum)} - {PaintColor.GetPaintColorAnswer(Colors[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label gloss = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetHeadline(layer: PaintLayerEnum.GlossEnum)} - {PaintGloss.GetGlossName(Gloss[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label waterborn = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetHeadline(layer: PaintLayerEnum.WaterbornEnum)} - {waterbornText}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            result.Add(headline);
            result.Add(location);
            result.Add(materials);
            result.Add(objects);
            result.Add(colors);
            result.Add(gloss);
            result.Add(waterborn);

            Frame frame = new Frame
            {
                Content = result,
                HasShadow = true,
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10
            };

            return frame;

        }

    }
}
