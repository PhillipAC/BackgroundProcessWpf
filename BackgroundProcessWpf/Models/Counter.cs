using System;
using System.Collections.Generic;
using System.Text;

namespace BackgroundProcessWpf.Models
{
    class Counter
    {
        public int Count { get; set; }

        public Counter(int initialCount)
        {
            Count = initialCount;
        }

        /// <summary>
        /// Increase the count by amount
        /// </summary>
        /// <param name="amount">The amount to increase the amount by</param>
        /// <returns></returns>
        public int Increment(int amount = 1)
        {
            return Count += amount;
        }
    }
}
