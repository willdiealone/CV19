using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels.Base
{ 
    internal abstract class BaseViewModel : INotifyPropertyChanged,IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;        

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private bool _Disposed;
        protected void Dispose(bool  Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
            //Освобождение управляемых ресурсов
        }
    }
}
