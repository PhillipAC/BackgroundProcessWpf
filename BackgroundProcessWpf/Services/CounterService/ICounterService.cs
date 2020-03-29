using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;

namespace BackgroundProcessWpf.Services.CounterService
{
    public interface ICounterService
    {
        int GetCurrentCount();
        void StartCount();
        int EndCount();
    }
}
