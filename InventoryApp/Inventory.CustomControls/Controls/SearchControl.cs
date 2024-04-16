using System.Windows;
using System.Windows.Controls;

namespace Inventory.CustomControls.Controls
{
    public partial class SearchControl : Control
    {
        public static readonly DependencyProperty SearchedTextProperty =
        DependencyProperty.Register
        (
            "SearchedText"
           ,typeof(string)
           ,typeof(SearchControl)
           ,  new PropertyMetadata(string.Empty)
        );

        public string SearchedText
        {
            get
            {
                return (string)GetValue(SearchedTextProperty);
            }
            set
            {
                SetValue(SearchedTextProperty, value);
            }
        }

        public static readonly DependencyProperty LabelTextProperty = 
        DependencyProperty.Register
        (
            "LabelText"
            , typeof(string)
            ,typeof(SearchControl)
            , new PropertyMetadata(string.Empty)
            , new ValidateValueCallback(ValidateValueLabelText)
        );

        private static bool ValidateValueLabelText(object value)
        {
            return !value.ToString().Contains("1");
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set
            {
                SetValue(LabelTextProperty, value);
            }
        }

        public static readonly DependencyProperty SearchControlWidthProperty =
        DependencyProperty.Register
        (
            "SearchControlWidth"
            , typeof(double)
            , typeof(SearchControl)
            , new FrameworkPropertyMetadata
            (100.0
                , FrameworkPropertyMetadataOptions.AffectsArrange 
                  | FrameworkPropertyMetadataOptions.AffectsParentArrange 
                  | FrameworkPropertyMetadataOptions.AffectsArrange 
                  | FrameworkPropertyMetadataOptions.AffectsRender
                  | FrameworkPropertyMetadataOptions.Inherits
                , WidthChanged, CorrectWidth)
            , ValidateWidth 
        );

        private static object CorrectWidth(DependencyObject d, object baseValue)
        {
            return 0.0;
        }

        private static bool ValidateWidth(object value)
        {
            if (value is double)
            {
                double currentValue = (double)value;
                return currentValue >= 0.0;
            }

            return false;
        }

        private static void WidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public double SearchControlWidth
        {
            get { return (double)GetValue(SearchControlWidthProperty); }
            set
            {
                SetValue(SearchControlWidthProperty, value);
            }
        }
        public static readonly DependencyProperty SearchControlHeightProperty =
            DependencyProperty.Register
            (
                "SearchControlHeight"
                , typeof(double)
                , typeof(SearchControl)
                , new PropertyMetadata(25.0)
            );

        public double SearchControlHeight
        {
            get { return (double)GetValue(SearchControlHeightProperty); }
            set
            {
                SetValue(SearchControlHeightProperty, value);
            }
        }
    }
}
