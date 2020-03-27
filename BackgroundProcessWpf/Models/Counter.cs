using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace BackgroundProcessWpf.Models
{
    public class Counter : INotifyPropertyChanged
    {
        private int _initialCount;
        private bool _running = true;
        private int _count;
        private BackgroundWorker _backgroundWorker;

        public event PropertyChangedEventHandler PropertyChanged;
        public int Count 
        {
            get { return _count; }
            set 
            { 
                _count = value;
                OnPropertyChanged();
            } 
        }

        public Counter(int initialCount)
        {
            _initialCount = initialCount;
            _backgroundWorker = new BackgroundWorker();

            Count = initialCount;
            _backgroundWorker.DoWork += new DoWorkEventHandler((object sender, DoWorkEventArgs e) => { IncrementEverySecond(1); });
            _backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Increase the count by amount
        /// </summary>
        /// <param name="amount">The amount to increase the amount by</param>
        /// <returns>The new count</returns>
        public int Increment(int amount = 1)
        {
            return Count += amount;
        }

        /// <summary>
        /// Resets the count to the intial count
        /// </summary>
        /// <returns>The new count</returns>
        public int Reset()
        {
            return Count = _initialCount;
        }

        public void IncrementEverySecond(int amount)
        {
            while (_running)
            {
                Increment(amount);
                Thread.Sleep(1000);
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
