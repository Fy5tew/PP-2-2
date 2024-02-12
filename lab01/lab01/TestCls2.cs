using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal class TestCls2 : TestCls1, ITestInterface {
        protected string _name;

        public TestCls2(string name) {
            _name = name;
            OnNameChanged += (string newName) => {};
        }

        public char this[int index] {
            get => Name[index];
        }

        public string Name { 
            get => _name;
            set {
                OnNameChanged(value);
                _name = value;
            }
        }

        public event NameChanged OnNameChanged;

        public void Print() {
            Console.WriteLine($"Name is '{Name}'");
        }
    }
}
