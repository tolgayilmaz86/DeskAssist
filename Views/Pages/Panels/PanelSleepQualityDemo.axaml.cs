using Avalonia.Controls;
using DeskAssist.ViewModels.Panels;

namespace DeskAssist.Pages.Panels
{
    public partial class PanelSleepQualityDemo : UserControl
    {
        public PanelSleepQualityDemo()
        {
            InitializeComponent();

            DataContext = new PanelSleepQualityDemoViewModel();
        }
    }
}
