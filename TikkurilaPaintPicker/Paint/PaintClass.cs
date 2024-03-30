using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Font;
using TikkurilaPaintPicker.Paint.Enums;
using static TikkurilaPaintPicker.Design.Screens.PaintsScreens.PaintViewScreen;

namespace TikkurilaPaintPicker.Paint
{
    public class PaintClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Consumption { get; set; }
        public List<PaintMaterialEnum> Materials { get; set; }
        public List<PaintObjectEnum> Objects { get; set; }
        public List<PaintLocationEnum> Locations { get; set; }
        public PaintThinnerEnum Thinner { get; set; }
        public List<PaintColorEnum> Colors {  get; set; }
        public List<PaintGlossEnum> Gloss { get; set; }
        public List<CategoryEnums> Categories { get; set; }

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

            Label headline = CutomTextWidget.CustomText(
                    text: "Технические характеристики:",
                    textColor: CustomColors.Black,
                    textState: TextState.HeadlineMedium,
                    horizontalAligment: TextAlignment.Start
                );

            Label desc = CutomTextWidget.CustomText(
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

            Label headline = CutomTextWidget.CustomText(
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
                Label label = CutomTextWidget.CustomText(
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
                Label label = CutomTextWidget.CustomText(
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
                Label label = CutomTextWidget.CustomText(
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
                Label label = CutomTextWidget.CustomText(
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
                Label label = CutomTextWidget.CustomText(
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

            Label label = CutomTextWidget.CustomText(
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


            Label label = CutomTextWidget.CustomText(
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
                Label label = CutomTextWidget.CustomText(
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

    }
}
