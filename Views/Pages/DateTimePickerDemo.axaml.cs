using Avalonia.Controls;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class DateTimePickersDemo : UserControl
    {
        public DateTimePickersDemo()
        {
            InitializeComponent();

            DataContext = new DateTimePickersDemoViewModel();
        }
    }
}