using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class SlidersDemo : UserControl
    {
        public SlidersDemo()
        {
            InitializeComponent();

            DataContext = new SlidersDemoViewModel();
        }
    }
}
