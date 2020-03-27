using BackgroundProcessWpf.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackgroundProcessWpf.ViewModels
{
    /// <summary>
    /// The ViewModel of the MainWindow view.
    /// </summary>
    class MainWindowViewModel
    {
        public Counter Model { get; set; }

        /// <summary>
        /// Initialization of the Counter
        /// </summary>
        public MainWindowViewModel()
        {
            Model = new Counter(0);
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
