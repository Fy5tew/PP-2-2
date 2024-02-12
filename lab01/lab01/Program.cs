namespace lab01 {
    internal class Program {
        static void Main(string[] args) {
            Task2();
            Task8();
            Task9();
        }

        static void Task2() {
            Console.WriteLine("\n\t\tTask 2");

            var tc1 = new TestCls1();
            var tc2 = new TestCls1(12, 19.2);
            var tc3 = new TestCls1(tc2);

            Console.WriteLine(TestCls1.PUBLIC_VALUE);
            Console.WriteLine(tc1.publicField);
            Console.WriteLine(tc1.PublicProperty);
            Console.WriteLine(tc2.PublicInfo());
            Console.WriteLine(tc3.GetInfo());
        }
        
        static void Task8() {
            Console.WriteLine("\n\t\tTask 8");

            var tc = new TestCls2("some name");
            tc.OnNameChanged += (string newName) => { Console.WriteLine($"Name changed: {newName}"); };

            tc.Print();
            Console.WriteLine(tc[3]);
            tc.Name = "Some other name";
            tc.Print();
            Console.WriteLine(tc[7]);
        }

        static void Task9() {
            Console.WriteLine("\n\t\tTask 9");

            var tc = new TestCls4("cls4");

            Console.WriteLine(tc.publicField);
            Console.WriteLine(tc.PublicProperty);
            Console.WriteLine(tc[2]);
            Console.WriteLine(tc.GetInfo());
            tc.Print();
            tc.PrintInfo();
        }
    }
}