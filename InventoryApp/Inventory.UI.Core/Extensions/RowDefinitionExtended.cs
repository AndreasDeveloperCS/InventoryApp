using System.Windows;
using System.Windows.Controls;

namespace Inventory.UI.Core.Extensions
{
    public class RowDefinitionExtended : RowDefinition
    {
     
        public static readonly DependencyProperty VisibleProperty = DependencyProperty.Register(
            "Visible",
            typeof(bool),
            typeof(RowDefinitionExtended),
            new PropertyMetadata(true, new PropertyChangedCallback(OnVisibleChanged)));


        public bool Visible
        {
            get { return (bool)GetValue(VisibleProperty); }
            set { SetValue(VisibleProperty, value); }
        }

       
        static RowDefinitionExtended()
        {
            RowDefinition.HeightProperty.OverrideMetadata(typeof(RowDefinitionExtended),
                new FrameworkPropertyMetadata(new GridLength(1, GridUnitType.Star), null,
                    new CoerceValueCallback(CoerceWidth)));

            RowDefinition.MinHeightProperty.OverrideMetadata(typeof(RowDefinitionExtended),
                new FrameworkPropertyMetadata((double)0, null,
                    new CoerceValueCallback(CoerceMinWidth)));
        }

  
        public static void SetVisible(DependencyObject obj, bool nVisible)
        {
            obj.SetValue(VisibleProperty, nVisible);
        }

        public static bool GetVisible(DependencyObject obj)
        {
            return (bool)obj.GetValue(VisibleProperty);
        }

        static void OnVisibleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            obj.CoerceValue(RowDefinition.HeightProperty);
            obj.CoerceValue(RowDefinition.MinHeightProperty);
        }

  
        static object CoerceWidth(DependencyObject obj, object nValue)
        {
            return (((RowDefinitionExtended)obj).Visible) ? nValue : new GridLength(0);
        }

        static object CoerceMinWidth(DependencyObject obj, object nValue)
        {
            return (((RowDefinitionExtended)obj).Visible) ? nValue : (double)0;
        }
    }
}
