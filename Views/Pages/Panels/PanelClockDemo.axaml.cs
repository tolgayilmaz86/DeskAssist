using Avalonia.Controls;
using DeskAssist.ViewModels.Panels;

namespace DeskAssist.Pages.Panels
{
    public partial class PanelClockDemo : UserControl
    {
        public PanelClockDemo()
        {
            InitializeComponent();

            DataContext = new PanelClockDemoViewModel();
        }
    }
}