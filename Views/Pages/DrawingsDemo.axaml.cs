using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class DrawingsDemo : UserControl
    {
        public DrawingsDemo()
        {
            InitializeComponent();

            DataContext = new DrawingsDemoViewModel();
        }
    }
}
