using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Diagnostics;

namespace AvaTestOpacity11preview.Views
{
    public partial class PlayerControls : UserControl
    {
        
        public PlayerControls()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void YellowButtonClick(object? sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Yellow Button Clicked");
        }

        private void BlueButtonClick(object? sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Blue Button Clicked");
        }
    }
}
