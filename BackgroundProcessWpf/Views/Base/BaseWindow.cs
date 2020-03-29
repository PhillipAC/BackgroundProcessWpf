using BackgroundProcessWpf.Support;
using BackgroundProcessWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Composition;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BackgroundProcessWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class BaseWindow : Window
    {
        public IViewModel ViewModel { get; set; }

        public BaseWindow()
        {
            string viewModelName = this.GetType().ToString().Split('.').Last() + "ViewModel";
            IEnumerable<IViewModel>Exports = Mef.Container.GetExportedValues<IViewModel>();
            DataContext = Exports
                .First(x => x.GetType().ToString().Split('.').Last().Equals(viewModelName));
        }
    }
}
