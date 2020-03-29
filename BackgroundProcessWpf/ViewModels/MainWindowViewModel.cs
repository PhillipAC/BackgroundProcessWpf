using BackgroundProcessWpf.Models;
using BackgroundProcessWpf.Services.CounterService;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Composition;

namespace BackgroundProcessWpf.ViewModels
{
    /// <summary>
    /// The ViewModel of the MainWindow view.
    /// </summary>
    [Export(typeof(IViewModel))]
    public class MainWindowViewModel : BaseViewModel
    {
        private ICounterService _counterService;
        public Counter Model { get; set; }
        public DelegateCommand ResetCounter { get; set; }

        /// <summary>
        /// Initialization of the Counter
        /// </summary>
        [ImportingConstructor]
        public MainWindowViewModel(ICounterService counterService)
        {
            Model = new Counter(0);
            _counterService = counterService;

            ResetCounter = new DelegateCommand(ExecuteResetCounter, CanExecuteResetCounter);
        }

        /// <summary>
        /// Resets the ViewModel's counter
        /// </summary>
        public void ExecuteResetCounter()
        {
            Model.Reset();
        }

        /// <summary>
        /// Returns if the counter can be reset
        /// </summary>
        /// <returns></returns>
        public bool CanExecuteResetCounter()
        {
            return true;
        }
    }
}
