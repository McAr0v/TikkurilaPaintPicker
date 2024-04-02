using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.PaintPickerScreens.PaintLayers;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint.Enums;
using static TikkurilaPaintPicker.Design.Screens.PaintsScreens.PaintViewScreen;

namespace TikkurilaPaintPicker.Paint
{
    /// <summary>
    /// Класс краски
    /// </summary>
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

        /// <summary>
        /// Функция генерации названия картинки. Заменяет пробелы в названии на нижнее подчеркивание. Для 
        /// автоматического подтягивания нужной картинки краски
        /// </summary>
        /// <returns></returns>
        public string GenerateImageName()
        {
            string name = Name;
            return name.Replace(" ", "_").ToLower();
        }

        /// <summary>
        /// Статическая функция для получения пустой краски
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция для получения Frame с свойствами краски
        /// </summary>
        /// <param name="navigateToPage"></param>
        /// <returns></returns>
        public Frame GetProductOptionsFrame(NavigateToPageDelegate navigateToPage) 
        {
            // Общий стак элементов
            StackLayout elementsStack = new StackLayout(){Spacing = 20};

            // Отдельный стак для заголовка и описания
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

            elementsStack.Add( headlineAndDesc );

            // Генерируем и добавляем в 2 колонки каждое свойство краски
            // Затем помещаем каждое свойство в общий стак элементов
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintColors, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintGloss, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintLocation, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintMaterials, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintObjects, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintThinner, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintConsumption, navigateToPage));
            elementsStack.Children.Add(GetGrid(OptionsEnums.PaintCategories, navigateToPage));

            // Возвращаем красивую карточку свойств
            return new Frame
            {
                Content = elementsStack,
                HasShadow = true,
                BackgroundColor = CustomColors.White,
                Padding = new Thickness(20),
                CornerRadius = 10
            };

        }

        /// <summary>
        /// Функция генерации свойства краски в 2 колонки
        /// </summary>
        /// <param name="option"></param>
        /// <param name="navigateToPage"></param>
        /// <returns></returns>
        private Grid GetGrid(OptionsEnums option, NavigateToPageDelegate navigateToPage)
        {
            // Название свойства

            Label optionName = CustomWidgets.CustomText(
                    text: OptionsClass.GetOptionsName(option),
                    textColor: CustomColors.Black,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

            optionName.FontAttributes = FontAttributes.Bold;

            // Макет для расположения элементов в 2 колонки с разной шириной
            Grid grid = new Grid
            {
                ColumnSpacing = 10,
                RowSpacing = 10,
            };

            // Первая колонка, занимающая 1/3 ширины экрана
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // Вторая колонка, занимающая оставшуюся часть ширины
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            // Отдельный стак для опций краски
            StackLayout optionsItemsStack = new StackLayout();

            // Генерируем опции в стак в зависимости от типа опции
            switch (option)
            {
                case OptionsEnums.PaintLocation: optionsItemsStack = GetPaintLocation(); break;
                case OptionsEnums.PaintMaterials: optionsItemsStack = GetMaterials(); break;
                case OptionsEnums.PaintColors: optionsItemsStack = GetColors(); break;
                case OptionsEnums.PaintGloss: optionsItemsStack = GetGloss(); break;
                case OptionsEnums.PaintObjects: optionsItemsStack = GetObjects(); break;
                case OptionsEnums.PaintThinner: optionsItemsStack = GetThinner(); break;
                case OptionsEnums.PaintConsumption: optionsItemsStack = GetConsumption(); break;
                case OptionsEnums.PaintCategories: optionsItemsStack = GetCategories(navigateToPage); break;
            }

            // Отступы между элементами
            optionsItemsStack.Spacing = 5;

            // добавляем в колонки название опции и элементы опций
            grid.Add(optionName, 0, 0);
            grid.Add(optionsItemsStack, 1, 0);

            return grid;
        }

        /// <summary>
        /// Функция получения стака с объектами краски
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения стака с локациями краски
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения стака с подходящими материалами для окраски 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения стака с доступными цветами краски
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения стака со списком существующих блесков краски 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения стака с разбавителем краски
        /// </summary>
        /// <returns></returns>
        private StackLayout GetThinner()
        {
            StackLayout stack = new StackLayout();

            Label label = CustomWidgets.CustomText(
                    text: PaintThinner.GetThinnerName(Thinner),
                    textColor: CustomColors.Graphite,
                    textState: TextState.BodySmall,
                    horizontalAligment: TextAlignment.Start
                );

            stack.Children.Add(label);

            return stack;


        }

        /// <summary>
        /// Функция получения стака с расходом краски
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Функция получения стака со списком категорий, в которых находится данная краска
        /// </summary>
        /// <param name="navigateToPage"></param>
        /// <returns></returns>
        private StackLayout GetCategories(NavigateToPageDelegate navigateToPage)
        {
            StackLayout stack = new StackLayout();

            foreach (CategoryEnums category in Categories)
            {
                Label label = CustomWidgets.CustomText(
                    text: CategoryClass.Translate(category),
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

        /// <summary>
        /// Функция проверки - заполнены ли локации в краске. Используется для перехода между страницами в PaintPicker'е
        /// </summary>
        /// <returns></returns>
        public bool CheckLocations() 
        {
            return Locations.Count > 0;
        }

        /// <summary>
        /// Функция проверки - заполнены ли объекты в краске. Используется для перехода между страницами в PaintPicker'е
        /// </summary>
        /// <returns></returns>
        public bool CheckObjects()
        {
            return Objects.Count > 0;
        }

        /// <summary>
        /// Функция проверки - заполнены ли материалы в краске. Используется для перехода между страницами в PaintPicker'е
        /// </summary>
        /// <returns></returns>
        public bool CheckMaterials()
        {
            return Materials.Count > 0;
        }

        /// <summary>
        /// Функция проверки - заполнен ли цвет в краске. Используется для перехода между страницами в PaintPicker'е
        /// </summary>
        /// <returns></returns>
        public bool CheckColors()
        {
            return Colors.Count > 0;
        }

        /// <summary>
        /// Функция проверки - заполнен ли растворитель в краске. Используется для перехода между страницами в PaintPicker'е
        /// </summary>
        /// <returns></returns>
        public bool CheckThinner()
        {
            return Thinner != PaintThinnerEnum.NotChosen;
        }

        /// <summary>
        /// Функция проверки - заполнен ли блеск в краске. Используется для перехода между страницами в PaintPicker'е
        /// </summary>
        /// <returns></returns>
        public bool CheckGloss()
        {
            return Gloss.Count > 0;
        }

        /// <summary>
        /// Функция получения виджета всех ответов из PaintPicker'а
        /// </summary>
        /// <returns></returns>
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
                text: $"{PaintLayer.GetAnswer(layer: PaintLayerEnum.LocationEnum)} - {PaintLocation.GetPaintLocationString(Locations[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label materials = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetAnswer(layer: PaintLayerEnum.MaterialEnum)} - {PaintMaterial.GetPaintMaterialName(Materials[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label objects = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetAnswer(layer: PaintLayerEnum.ObjectEnum)} - {PaintObject.GetPaintObjectName(Objects[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label colors = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetAnswer(layer: PaintLayerEnum.ColorsEnum)} - {PaintColor.GetPaintColorAnswer(Colors[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label gloss = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetAnswer(layer: PaintLayerEnum.GlossEnum)} - {PaintGloss.GetGlossName(Gloss[0])}",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium
                );

            Label waterborn = CustomWidgets.CustomText(
                text: $"{PaintLayer.GetAnswer(layer: PaintLayerEnum.WaterbornEnum)} - {waterbornText}",
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
