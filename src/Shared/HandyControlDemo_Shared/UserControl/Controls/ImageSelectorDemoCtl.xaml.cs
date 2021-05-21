using System;
using System.Windows;
using System.Windows.Media;

namespace HandyControlDemo.UserControl
{
    public partial class ImageSelectorDemoCtl
    {
        public ImageSelectorDemoCtl()
        {
            InitializeComponent();
        }
        void OnClick1(object sender, RoutedEventArgs e)
        {
            test.HasValue = false;
            test.PreviewBrush = default(Brush);
            test.Uri = default(Uri);
        }
    }
}
