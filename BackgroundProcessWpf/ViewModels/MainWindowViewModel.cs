using BackgroundProcessWpf.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackgroundProcessWpf.ViewModels
{
    /// <summary>
    /// The ViewModel of the MainWindow view.
    /// </summary>
    public class MainWindowViewModel
    {
        public Counter Model { get; set; }
        public DelegateCommand ResetCounter { get; set; }

        /// <summary>
        /// Initialization of the Counter
        /// </summary>
        public MainWindowViewModel()
        {
            Model = new Counter(0);

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
