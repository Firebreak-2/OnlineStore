using System;
using Avalonia.Controls;
using Avalonia.Controls.Platform;
using Avalonia.Input;
using Avalonia.Media;

namespace AvaloniaTestApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static ContextMenu MenuBarItemContextMenu => new()
        {
            Items = new[]
            {
                "test 1",
                "test 2"
            }
        };
        public static IBrush BgColor => new SolidColorBrush(Color.Parse("#072436"));
        public static IBrush MenuBarColor => new SolidColorBrush(Color.Parse("#082c42"));

        public static void Login()
        {

        }

        public static void Logout()
        {
            
        }

        public static void SwitchAccount()
        {
            
        }

        public static void GotoSettings()
        {
            
        }

        public static void GotoMenu()
        {
            
        }

        public static void GotoHistory()
        {
            
        }
    }
}
