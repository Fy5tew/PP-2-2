using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal delegate void NameChanged(string newName);

    internal interface ITestInterface {
        string Name { get; set; }

        void Print();

        event NameChanged OnNameChanged;

        char this[int index] { get; }
    }
}
