using System;
using System.Collections.Generic;
using System.Text;

namespace BackgroundProcessWpf.Models
{
    public class Counter
    {
        private int _initialCount;
        public int Count { get; set; }

        public Counter(int initialCount)
        {
            _initialCount = initialCount;
            Count = initialCount;
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
    }
}
