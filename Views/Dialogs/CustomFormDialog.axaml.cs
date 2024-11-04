using Avalonia.Controls;
using Avalonia.Themes.Neumorphism.Dialogs.Interfaces;
using Avalonia.Themes.Neumorphism.Dialogs;
using DeskAssist.ViewModels.Dialogs;

namespace DeskAssist.Views.Dialogs
{
    public partial class CustomFormDialog : Window, IDialogWindowResult<DialogResult>, IHasNegativeResult
    {
        public CustomFormDialog()
        {
            InitializeComponent();
        }

        public DialogResult GetResult() => (DataContext as CustomFormDialogViewModel)?.DialogResult;

        public void SetNegativeResult(DialogResult result)
        {
            if (DataContext is CustomFormDialogViewModel viewModel)
                viewModel.DialogResult = result;
        }
    }
}