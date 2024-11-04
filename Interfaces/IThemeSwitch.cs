using Avalonia.Themes.Neumorphism.Enums;

namespace DeskAssist.Interfaces
{
    public interface IThemeSwitch
    {
        ApplicationTheme Current { get; }
        void ChangeTheme(ApplicationTheme theme);
    }
}
