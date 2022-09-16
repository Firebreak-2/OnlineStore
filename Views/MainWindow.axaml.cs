using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using AvaloniaTestApp.Models;
using AvaloniaTestApp.ViewModels;

namespace AvaloniaTestApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            StackPanel panel = this.FindControl<StackPanel>("PreviewedMenuItems");
            panel[AvaloniaProperty.Register<StackPanel, Controls>("Children")] = MainWindowViewModel.ShopItems;
        }
    }
}