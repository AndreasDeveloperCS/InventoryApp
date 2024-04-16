using System.Windows;
using System.Windows.Controls;

namespace Inventory.CustomControls.Controls
{
    public partial class SimpleInfoBlock : Control
    {
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(SimpleInfoBlock));

        public static readonly DependencyProperty TextBoxTextProperty =
            DependencyProperty.Register("TextBoxText", typeof(string), typeof(SimpleInfoBlock));

        public static readonly DependencyProperty InfoOrientationProperty =
            DependencyProperty.Register("InfoOrientation", typeof(Orientation), typeof(SimpleInfoBlock));

        public Orientation InfoOrientation
        {
            get { return (Orientation)GetValue(InfoOrientationProperty); }
            set { SetValue(InfoOrientationProperty, value); }
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public string TextBoxText
        {
            get { return (string)GetValue(TextBoxTextProperty); }
            set {
                SetValue(TextBoxTextProperty, value); 
            }
        }
    }
}
