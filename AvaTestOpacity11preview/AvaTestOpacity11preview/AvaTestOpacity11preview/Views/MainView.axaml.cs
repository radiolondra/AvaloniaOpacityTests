using Avalonia.Controls;
using Avalonia.Input;
using System.Diagnostics;

namespace AvaTestOpacity11preview.Views
{
    public partial class MainView : UserControl
    {
        public Panel _contentPanel;
        public MainView()
        {
            InitializeComponent();
            _contentPanel = this.Get<Panel>("ContentPanel");
            _contentPanel.PointerEntered += Panel_PointerEnter;
            _contentPanel.PointerExited += Panel_PointerLeave;
        }

        public void Panel_PointerEnter(object sender, PointerEventArgs e)
        {
            Debug.WriteLine("POINTER ENTER");
            _contentPanel.Opacity = 0.8;

        }

        public void Panel_PointerLeave(object sender, PointerEventArgs e)
        {
            Debug.WriteLine("POINTER LEAVE");
            _contentPanel.Opacity = 0.0;

        }
    }
}