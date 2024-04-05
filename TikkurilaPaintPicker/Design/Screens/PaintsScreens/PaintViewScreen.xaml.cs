using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens.CatalogScreens;
using TikkurilaPaintPicker.Design.Widgets;
using TikkurilaPaintPicker.Design.Widgets.EnumsForWidgets;
using TikkurilaPaintPicker.Paint;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Design.Screens.PaintsScreens;

public partial class PaintViewScreen : ContentPage
{
    // Переменная для хранения рассчета необходимого
    // количества краски
    int paintCount = 0;

    // Делегат для перехода на страницу категории
    public delegate Task NavigateToPageDelegate(CategoryEnums categoryEnum);

    // Функция для перехода на страницу категории
    private async Task OnLabelTapped(CategoryEnums categoryEnum)
    {
        await Navigation.PushAsync(new CategoryPage(categoryEnum, CategoryClass.GetChildrenCategoriesList(categoryEnum)));
    }

    // Задний фон для калькулятора

    Frame calcFrame = new Frame
    {
        
        HasShadow = true, 
        BackgroundColor = CustomColors.White,
        Padding = new Thickness(20),
        CornerRadius = 10 
    };

    // Общий стак страницы, куда помещаются все элементы

    StackLayout pageStack = new StackLayout() 
    {
        Margin = new Thickness(20),
        Spacing = 20,
    };

    // Прокручиваемая разметка, чтобы прокручивать экран
    // по вертикали

    ScrollView pageScroll = new ScrollView();

    // Кнопки

    Button buttonToMainPage = CustomWidgets.CustomButton("Вернуться на главный экран", ButtonState.Primary);
    Button calcButton = CustomWidgets.CustomButton("Рассчитать количество краски", ButtonState.Primary);

    // Стак для калькулятора

    StackLayout calcStack = new StackLayout() {Spacing = 20 };

    // Форма ввода для калькулятора, чтобы ввести площадь

    Entry squareEntry = new Entry()
    {
        Keyboard = Keyboard.Numeric,
        Placeholder = "Введите площадь",
        TextColor = CustomColors.Black
    };

    // Текст с отображением результата калькулятора

    Label countOfPaint = CustomWidgets.CustomText
            (
                text: "Результат:",
                textColor: CustomColors.Black,
                textState: TextState.BodySmall,
                horizontalAligment: TextAlignment.Start
            );

	public PaintViewScreen(PaintClass paint)
	{
		InitializeComponent();

        calcButton.Clicked += async (sender, args) => await GetPaintCountAsync(paint);
        buttonToMainPage.Clicked += async (sender, args) => await Navigation.PopToRootAsync();

        // Генерируем калькулятор

        GenerateCalc();

        // Добавляем весь контент страницы в pageStack
        AddContentToPageStack(inputPaint:  paint);

        // Помещаем pageStack в прокручиваемую разметку
        pageScroll.Content = pageStack;

        // Устанавливаем прокручиваемую разметку в качестве
        // основного контента страницы
        Content = pageScroll;

        Title = paint.Name;

    }


    /// <summary>
    /// Функция добавления всего контента страницы в pageStack. 
    /// Принимает на вход краску inputPaint
    /// </summary>
    /// <param name="inputPaint"></param>
    private void AddContentToPageStack(PaintClass inputPaint)
    {
        Image image = new Image
        {
            Source = $"Images/PaintImages/{inputPaint.GenerateImageName()}.png",
            Aspect = Aspect.AspectFit,
            HeightRequest = 300,
        };

        Label paintName = CustomWidgets.CustomText
            (
                text: inputPaint.Name,
                textColor: CustomColors.Black,
                textState: TextState.HeadlineMedium
            );

        Label paintDesc = CustomWidgets.CustomText
            (
                text: inputPaint.Description,
                textColor: CustomColors.Graphite,
                textState: TextState.BodySmall
            );

        pageStack.Add(image);
        pageStack.Add(paintName);
        pageStack.Add(paintDesc);
        pageStack.Add(calcFrame);

        // Генерируем и добавляем виджет свойств красок
        pageStack.Add(inputPaint.GetProductOptionsFrame(OnLabelTapped));
        
        pageStack.Add(buttonToMainPage);

    }

    /// <summary>
    /// Функция отправки сообщения в ватсап с текстом
    /// </summary>
    /// <param name="paintName"></param>
    /// <returns></returns>
    private async Task SendWhatsapp(string paintName)
    {

        string uri = $"https://wa.me/77018039220?text=Здравствуйте,%20интересует%20ваша%20краска%20{paintName}";

        bool supportsUri = await Launcher.Default.CanOpenAsync(uri);
        if (supportsUri)
            await Launcher.Default.OpenAsync(uri);

        else
            await DisplayAlert("Ошибка", "Не установлено приложение Whatsapp", "OK");

    }


    /// <summary>
    /// Функция генерации содержимого калькулятора
    /// </summary>
    private void GenerateCalc() 
    {
         
        StackLayout headlineDesc = new StackLayout() { Spacing = 5 };

        headlineDesc.Add(
            CustomWidgets.CustomText(
                text: "Калькулятор расхода",
                textColor: CustomColors.Black,
                textState: TextState.HeadlineMedium,
                horizontalAligment: TextAlignment.Start
                )
            );

        headlineDesc.Add(
            CustomWidgets.CustomText(
                text: "Введите вашу площадь поверхности и нажмите кнопку 'Рассчитать'. ",
                textColor: CustomColors.Black,
                textState: TextState.DescMedium,
                horizontalAligment: TextAlignment.Start
                )
            );

        calcStack.Add(headlineDesc);

        // Добавляем форму ввода площади
        calcStack.Add(squareEntry);

        calcStack.Add(calcButton);

        // Добавляем текстовый виджет ответа
        calcStack.Add(countOfPaint);

        // Добавляем во Frame калькулятора наш контент
        calcFrame.Content = calcStack;
    }

    /// <summary>
    /// Функция для правильного склонения слова "Литр" в зависимости
    /// от количества литров
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private string GetCorrectWord(int number)
    {
        if (number % 10 == 1 && number % 100 != 11)
        {
            return "литр";
        }
        else if ((number % 10 == 2 || number % 10 == 3 || number % 10 == 4) && (number % 100 != 12 && number % 100 != 13 && number % 100 != 14))
        {
            return "литра";
        }
        else
        {
            return "литров";
        }
    }

    /// <summary>
    /// Функция вычисления необходимого количества краски
    /// </summary>
    /// <param name="paint"></param>
    /// <returns></returns>
    private async Task GetPaintCountAsync(PaintClass paint)
    {
        if (squareEntry.Text != null && squareEntry.Text != "") 
        {
            // Проверяем - ввел ли пользователь цифры или нет

            if (int.TryParse(squareEntry.Text, out int count))
            {
                // Если площадь меньше 5 кв.м, то устанавливаем
                // минимальный объем краски - 1л
                if (int.Parse(squareEntry.Text) < 5)
                {
                    paintCount = 1;
                }
                // Иначе вычисляем по формуле
                // Площадь умножаем на 2 слоя и делим на расход
                // На 2 слоя умножаем, потому что по правилам окраски окрашивать нужно ОБЯЗАТЕЛЬНО в 2 слоя
                else 
                {
                    paintCount = int.Parse(squareEntry.Text) * 2 / paint.Consumption;
                }
                
                // Устанавливаем результат в переменную
                countOfPaint.Text = $"Результат: Нужно {paintCount} {GetCorrectWord(paintCount)} краски {paint.Name}";

            }

            // Если как то смог ввести не цифры, то выводим сообщение
            
            else 
            {
                await DisplayAlert("Ошибка", "Вы ввели не цифры!", "OK");
            }
            
        }
        else
        {
            await DisplayAlert("Ошибка", "Вы не ввели площадь!", "OK");
        }

        // Перерисовываем переменную с результатом калькулятора
        SemanticScreenReader.Announce(countOfPaint.Text);
    }
}