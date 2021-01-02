using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeAddingPractice
{
    class ZipInfo
    {
        private int value;
        private int times;
        public ZipInfo (int value, int times)
        {
            this.value = value;
            this.times = times;
        }
        public ZipInfo(int value) : this(value, 1) { }
        public void IncTimes() => this.times++;
        public int GetTimes() => times;
        public int GetVal() => this.value;
        public override string ToString()
        {
            return $"the value {value} occurs {times} times";
        }
    }
}
