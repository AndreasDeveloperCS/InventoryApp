using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace Inventory.UI.Core.Behaviors.Sorting
{ 
    public class SortingBehavior : Behavior<ListView>
    {
        private Sorting _sorting;

        public SortingBehavior()
        {
            _sorting = new Sorting();
        }

        protected override void OnAttached()
        {
            AssociatedObject.AddHandler(GridViewColumnHeader.ClickEvent,
                            new RoutedEventHandler(OnColumnHeaderClicked));
        }
        
        protected override void OnDetaching()
        {
            AssociatedObject.RemoveHandler(GridViewColumnHeader.ClickEvent,
                            new RoutedEventHandler(OnColumnHeaderClicked));
        }
        
        private void OnColumnHeaderClicked(object sender, RoutedEventArgs e)
        {
            var listView = sender as ListView;

            if (listView == null)
            {
                return;
            }
            try
            {
                if (e.OriginalSource.GetType() == typeof(GridViewColumnHeader))
                {
                    _sorting.Sort(e.OriginalSource, listView.Items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
