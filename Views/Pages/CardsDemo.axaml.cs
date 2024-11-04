using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class CardsDemo : UserControl
    {
        public CardsDemo()
        {
            InitializeComponent();

            DataContext = new CardsDemoViewModel();
        }
    }
}