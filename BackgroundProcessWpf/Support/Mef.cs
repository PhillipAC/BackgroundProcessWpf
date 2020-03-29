using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Text;

namespace BackgroundProcessWpf.Support
{
    public static class Mef
    {
        private static CompositionContainer container;

        public static CompositionContainer Container
        {
            get
            {
                if (container == null)
                {
                    var catalog =
                        new DirectoryCatalog(".//", "BackgroundProcessWpf.*");

                    container = new CompositionContainer(catalog);
                }

                return container;
            }
        }
    }
}
