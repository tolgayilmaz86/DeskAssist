using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class ExpandersDemo : UserControl
    {
        public ExpandersDemo()
        {
            InitializeComponent();

            DataContext = new ExpandersDemoViewModel();
        }
    }
}