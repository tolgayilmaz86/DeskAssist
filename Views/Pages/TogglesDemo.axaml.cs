using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class TogglesDemo : UserControl
    {
        public TogglesDemo()
        {
            InitializeComponent();

            DataContext = new ButtonsDemoViewModel();
        }
    }
}
