using Avalonia.Controls;
using DeskAssist.ViewModels.Panels;

namespace DeskAssist.Pages.Panels
{
    public partial class PanelMessagesDemo : UserControl
    {
        public PanelMessagesDemo()
        {
            InitializeComponent();

            DataContext = new PanelMessagesDemoViewModel();
        }
    }
}
