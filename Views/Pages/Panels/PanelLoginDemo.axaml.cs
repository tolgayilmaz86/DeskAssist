using Avalonia.Controls;
using DeskAssist.ViewModels.Panels;

namespace DeskAssist.Pages.Panels
{
    public partial class PanelLoginDemo : UserControl
    {
        public PanelLoginDemo()
        {
            InitializeComponent();

            DataContext = new PanelLoginDemoViewModel();
        }
    }
}