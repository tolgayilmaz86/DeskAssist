using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class ButtonsDemo : UserControl
    {
        public ButtonsDemo()
        {
            InitializeComponent();

            DataContext = new ButtonsDemoViewModel();
        }
    }
}
