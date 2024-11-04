using Avalonia.Controls;
using DeskAssist.ViewModels.Panels;

namespace DeskAssist.Pages.Panels
{
    public partial class PanelPlayerDemo : UserControl
    {
        public PanelPlayerDemo()
        {
            InitializeComponent();
            
            DataContext = new PanelPlayerDemoViewModel();
        }
    }
}