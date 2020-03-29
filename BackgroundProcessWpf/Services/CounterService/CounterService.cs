using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using System.Threading;

namespace BackgroundProcessWpf.Services.CounterService
{
    [Export(typeof(ICounterService))]
    public class CounterService : ICounterService
    {
        private int _currentCount;
        private bool _keepCounting;

        public int EndCount()
        {
            _keepCounting = false;
            return _currentCount;
        }

        public int GetCurrentCount()
        {
            return _currentCount;
        }

        public void StartCount()
        {
            _keepCounting = true;
            while (_keepCounting)
            {
                _currentCount++;
                Thread.Sleep(1000);
            }
        }
    }
}
