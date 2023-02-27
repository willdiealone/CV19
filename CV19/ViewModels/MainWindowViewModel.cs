using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        #region Заголовок окна

        #endregion
        private string _Title = "Анализ статистики CV19";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {            
            get => _Title;

            //set 
            //{
            //    if (Equals(Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();

            //    Set(ref _Title,value)
            //}
            set => Set(ref _Title, value);
        }
    }
}
