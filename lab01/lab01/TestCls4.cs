using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal class TestCls4 : TestCls3 {
        public TestCls4(string name) : base(name) {}

        public new void PrintInfo() {
            Console.WriteLine("TestCls4 Info");
        }
    }
}
