using System;
using System.IO;
using System.Runtime.InteropServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace DeskAssist.Helpers
{
    internal static class Utilities
    {
        public static readonly bool IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static readonly bool IsOSX = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static Bitmap GetImageFromResources(string fileName)
        {
            return new Bitmap(AssetLoader.Open(new Uri($"avares://DeskAssist/Assets/{fileName}")));
        }

        public static PixelPoint GetWindowPosition(Window window)
        {
            if (!IsOSX || !window.FrameSize.HasValue)
                return window.Position;
            else
            {
                int yOffset = (int)(window.FrameSize.Value.Height - window.ClientSize.Height);
                return new(window.Position.X, window.Position.Y + yOffset);
            }
        }

        public static Bitmap GetImageFromFile(string path)
        {
            try
            {
                return new Bitmap(GetImageFullPath(path));
            }
            catch (Exception)
            {
                return GetImageFromResources("broken-link.png");
            }
        }

        private static string GetImageFullPath(string fileName)
            => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
    }
}
