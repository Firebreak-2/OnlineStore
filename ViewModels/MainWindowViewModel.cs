using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using AvaloniaTestApp.Models;

namespace AvaloniaTestApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static Controls ShopItems = new ShopItem[]
        {
            new(0, "Very Long Item Name", ShopItemCategory.Meal),
            new(0, "Very Long Item Name", ShopItemCategory.Meal),
            new(0, "Very Long Item Name", ShopItemCategory.Meal),
            new(0, "Very Long Item Name", ShopItemCategory.Meal),
            new(0, "Very Long Item Name", ShopItemCategory.Meal),
            new(0, "Very Long Item Name", ShopItemCategory.Meal),
        }.Select(x => new Grid
        {
            [AvaloniaProperty.Register<Grid, Controls>("Children")] = new Controls(new IControl[]
            {
                new Button(),
                new Label { Content = $"{x.Price} : {x.Name}" } 
            })
        }).Pipe(x => new Controls(x));
        
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
