using Avalonia.Controls;
using DeskAssist.ViewModels.Panels;

namespace DeskAssist.Pages.Panels
{
    public partial class PanelUserProfilDemo : UserControl
    {
        public PanelUserProfilDemo()
        {
            InitializeComponent();

            DataContext = new PanelUserProfilDemoViewModel();
        }
    }
}