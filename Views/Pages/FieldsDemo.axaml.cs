using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class FieldsDemo : UserControl
    {
        public FieldsDemo()
        {
            InitializeComponent();

            DataContext = new TextBoxesDemoViewModel();
        }
    }
}
