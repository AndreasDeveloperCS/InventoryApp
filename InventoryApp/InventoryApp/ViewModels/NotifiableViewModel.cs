﻿using JetBrains.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InventoryApp.ViewModels
{
    public class NotifiableViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
