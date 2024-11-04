using Avalonia.Controls;
using Avalonia.Input;
using DeskAssist.Models;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{
    public partial class ListsDemo : UserControl
    {
        public ListsDemo()
        {
            InitializeComponent();

            DataContext = new ListsDemoViewModel();
        }

        private void Grid_PointerPressed(object sender, PointerPressedEventArgs e)
        {
            var item = ((Control)e.Source).DataContext as CustomListItem;
            ((ListsDemoViewModel)DataContext).ListItemClickCommand(item);
        }
    }
}