using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{ 
    public partial class MenusDemo : UserControl
    {
        public MenusDemo()
        {
            InitializeComponent();

            DataContext = new MenusDemoViewModel();
        }
    }
}