using System.Windows;
using System.Windows.Controls;

namespace Inventory.UI.Core.Extensions
{
    public class ColumnDefinitionExtended : ColumnDefinition
    {
        public static readonly DependencyProperty VisibleProperty = DependencyProperty.Register(
            "Visible",
            typeof(bool),
            typeof(ColumnDefinitionExtended),
            new PropertyMetadata(true, new PropertyChangedCallback(OnVisibleChanged)));

        public bool Visible
        {
            get { return (bool)GetValue(VisibleProperty); }
            set { SetValue(VisibleProperty, value); }
        }

   
        static ColumnDefinitionExtended()
        {
            ColumnDefinition.WidthProperty.OverrideMetadata(typeof(ColumnDefinitionExtended),
                new FrameworkPropertyMetadata(new GridLength(1, GridUnitType.Star), null,
                    new CoerceValueCallback(CoerceWidth)));

            ColumnDefinition.MinWidthProperty.OverrideMetadata(typeof(ColumnDefinitionExtended),
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

        private static void OnVisibleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            obj.CoerceValue(ColumnDefinition.WidthProperty);
            obj.CoerceValue(ColumnDefinition.MinWidthProperty);
        }

        private static object CoerceWidth(DependencyObject obj, object nValue)
        {
            return (((ColumnDefinitionExtended)obj).Visible) ? nValue : new GridLength(0);
        }

        private static object CoerceMinWidth(DependencyObject obj, object nValue)
        {
            return (((ColumnDefinitionExtended)obj).Visible) ? nValue : (double)0;
        }
    }
}
