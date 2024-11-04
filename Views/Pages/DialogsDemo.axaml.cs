using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Primitives;
using DeskAssist.ViewModels;

namespace DeskAssist.Pages
{ 
    public partial class DialogsDemo : UserControl
    {
        public DialogsDemo()
        {
            InitializeComponent();
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime app)
            {
                // Lazy Initialize view model
                DataContext = new DialogsDemoViewModel(app.MainWindow);
            }

            base.OnApplyTemplate(e);
        }
    }
}