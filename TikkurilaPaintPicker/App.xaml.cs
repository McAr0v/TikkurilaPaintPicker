using TikkurilaPaintPicker.Design.Colors;
using TikkurilaPaintPicker.Design.Screens;

namespace TikkurilaPaintPicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Устанавливаем в качестве главной страницы
            // навигационную страницу. В навигационной странице
            // указываем MainScreen как первую страницу

            MainPage = new NavigationPage(new MainScreen()) 
            {
                BarTextColor = CustomColors.Black,
            };

        }
    }
}
