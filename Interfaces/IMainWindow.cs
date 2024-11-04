using Avalonia;
using Avalonia.Controls;

namespace DeskAssist.Interfaces
{
    public interface IMainWindow
    {
        IThemeSwitch ThemeSwitch { get; }
        IMainWindowState Model { get; }
        PixelPoint Position { get; }
        Size ClientSize { get; }
        Size? FrameSize { get; }
        WindowState State { get; }
    }
}
