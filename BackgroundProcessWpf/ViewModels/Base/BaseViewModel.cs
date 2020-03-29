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
    /// The Base View Model.
    /// </summary>
    public class BaseViewModel : IViewModel
    {
        [ImportingConstructor]
        public BaseViewModel()
        {
        }

    }
}
