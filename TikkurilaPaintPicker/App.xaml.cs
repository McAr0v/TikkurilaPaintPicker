using Microsoft.Maui.Controls;
using TikkurilaPaintPicker.Design.Screens;
using TikkurilaPaintPicker.Paint.PaintLists;

namespace TikkurilaPaintPicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainScreen()) 
            {
                BarTextColor = Colors.Black,
            };

        }
    }
}
