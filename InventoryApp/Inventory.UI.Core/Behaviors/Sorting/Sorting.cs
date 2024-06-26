﻿using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace Inventory.UI.Core.Behaviors.Sorting
{
    
    public class Sorting
    {
        private ListSortDirection _sortDirection;

        private GridViewColumnHeader _sortColumn;

     
        private string SetAdorner(object columnHeader)
        {
            string header = string.Empty;
            try
            {
                if (columnHeader.GetType() == typeof(GridViewColumnHeader))
                {
                    GridViewColumnHeader column = null;
                    column = columnHeader as GridViewColumnHeader;
                    if (column == null)
                    {
                        return null;
                    }

                    if (_sortColumn != null)
                    {
                        var adornerLayer = AdornerLayer.GetAdornerLayer(_sortColumn);
                        try
                        {
                            var adorners = adornerLayer.GetAdorners(_sortColumn);
                            if (adorners != null)
                            {
                                adornerLayer?.Remove(adorners[0]);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidOperationException(ex.Message);
                        }
                    }

                    if (_sortColumn == column)
                    {
                        _sortDirection = _sortDirection == ListSortDirection.Ascending ?
                                                           ListSortDirection.Descending :
                                                           ListSortDirection.Ascending;
                    }
                    else
                    {
                        _sortColumn = column;
                        _sortDirection = ListSortDirection.Ascending;
                    }

                    var sortingAdorner = new SortingAdorner(column, _sortDirection);
                    AdornerLayer.GetAdornerLayer(column).Add(sortingAdorner);

                    var b = _sortColumn?.Column?.DisplayMemberBinding as Binding;
                    if (b != null)
                    {
                        header = !string.IsNullOrEmpty(b.Path.Path) ? b.Path.Path : (_sortColumn.Column.Header as string);
                    }
                    else
                    {
                        var tb = _sortColumn?.Column?.Header as TextBlock;
                        header = tb?.Text;
                    }
                }
               
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return header;
        }
       
        public void Sort(object columnHeader, CollectionView list)
        {
            try
            {
                string column = SetAdorner(columnHeader);
                
                list.SortDescriptions.Clear();
                var sortDescription = new SortDescription(column, _sortDirection);
                list.SortDescriptions.Add(sortDescription);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
