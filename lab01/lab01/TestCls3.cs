using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal class TestCls3 : TestCls2 {
        public TestCls3(string name) : base(name) { }

        public void PrintInfo() {
            Console.WriteLine("TestCls3 Info");
        }
    }
}
