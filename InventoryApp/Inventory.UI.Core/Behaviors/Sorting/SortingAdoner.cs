﻿using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Inventory.UI.Core.Behaviors.Sorting
{
    public class SortingAdorner : Adorner
    {
        private static Geometry _arrowUp = Geometry.Parse("M 5,5 15,5 10,0 5,5");
        private static Geometry _arrowDown = Geometry.Parse("M 5,0 10,5 15,0 5,0");
        private Geometry _sortDirection;

    
        public SortingAdorner(GridViewColumnHeader adornedElement, ListSortDirection sortDirection)
            : base(adornedElement)
        {
            _sortDirection = sortDirection == ListSortDirection.Ascending ? _arrowUp : _arrowDown;
        }
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            double x = AdornedElement.RenderSize.Width - 20;
            double y = (AdornedElement.RenderSize.Height - 5) / 2;

            if (x >= 20)
            {
                drawingContext.PushTransform(new TranslateTransform(x, y));
                drawingContext.DrawGeometry(Brushes.Black, null, _sortDirection);
                drawingContext.Pop();
            }
        }
    }
}
