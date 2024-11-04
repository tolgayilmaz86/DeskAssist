using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Themes.Neumorphism;
using Avalonia.Themes.Neumorphism.Enums;
using DeskAssist.Helpers;
using DeskAssist.Interfaces;
using DeskAssist.Views;

namespace DeskAssist
{
    public sealed class App : Application, IThemeSwitch
    {
        private ApplicationTheme _currentTheme;

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);

            Name = "DeskAssist";
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
                DataContext = desktop.MainWindow.DataContext;
            }

            base.OnFrameworkInitializationCompleted();
        }

        ApplicationTheme IThemeSwitch.Current => this._currentTheme;



        void IThemeSwitch.ChangeTheme(ApplicationTheme theme)
        {
            if (theme == this._currentTheme)
                return;

            _currentTheme = theme;

            var neumorphismTheme = Application.Current.LocateMaterialTheme<NeumorphismTheme>();
            if (neumorphismTheme != null)
            {
                neumorphismTheme.BaseTheme = (Avalonia.Themes.Neumorphism.Enums.ApplicationTheme)theme;
            }
        }
    }
}