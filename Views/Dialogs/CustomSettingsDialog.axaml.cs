using Avalonia.Controls;
using Avalonia.Themes.Neumorphism.Dialogs.Interfaces;
using Avalonia.Themes.Neumorphism.Dialogs;
using DeskAssist.ViewModels.Dialogs;

namespace DeskAssist.Views.Dialogs
{
    public partial class CustomSettingsDialog : Window, IDialogWindowResult<DialogResult>, IHasNegativeResult
    {
        public CustomSettingsDialog()
        {
            InitializeComponent();
        }

        public DialogResult GetResult() => (DataContext as CustomSettingsDialogViewModel)?.DialogResult;

        public void SetNegativeResult(DialogResult result)
        {
            if (DataContext is CustomSettingsDialogViewModel viewModel)
                viewModel.DialogResult = result;
        }
    }
}