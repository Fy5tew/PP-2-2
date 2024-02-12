using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal class TestCls1 {
        private const string PRIVATE_VALUE = "private value";
        public const string PUBLIC_VALUE = "public value";
        protected const string PROTECTED_VALUE = "protected value";

        private int privateField;
        public int publicField;
        protected int protectedField;

        private double PrivateProperty { get; set; }
        public double PublicProperty { get; set; }
        protected double ProtectedProperty { get; set; }

        public TestCls1() {
            privateField = 1;
            publicField = 2;
            protectedField = 3;

            PrivateProperty = 11.5;
            PublicProperty = 12.5;
            ProtectedProperty = 13.5;
        }

        public TestCls1(TestCls1 other) {
            privateField = other.privateField;
            publicField = other.publicField;
            protectedField= other.protectedField;

            PrivateProperty= other.PrivateProperty;
            PublicProperty= other.PublicProperty;
            ProtectedProperty= other.ProtectedProperty;
        }

        public TestCls1(int iValue, double dValue) {
            privateField = 1 + iValue;
            publicField = 2 + iValue;
            protectedField = 3 + iValue;

            PrivateProperty = 11.5 + dValue;
            PublicProperty = 12.5 + dValue;
            ProtectedProperty = 13.5 + dValue;
        }

        private string PrivateInfo() {
            return $"{PRIVATE_VALUE} {privateField} {PrivateProperty}";
        }

        public string PublicInfo() {
            return $"{PUBLIC_VALUE} {publicField} {PublicProperty}";
        }

        protected string ProtectedInfo() {
            return $"{PROTECTED_VALUE} {protectedField} {ProtectedProperty}";
        }

        public string GetInfo() {
            return $"{PrivateInfo()}\n{PublicInfo()}\n{ProtectedInfo()}";
        }
    }
}
