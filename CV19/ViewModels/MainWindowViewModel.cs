using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        #region Заголовок окна

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title { get; set; } = "Анализ статистики CV19";

        #endregion
    }
}
