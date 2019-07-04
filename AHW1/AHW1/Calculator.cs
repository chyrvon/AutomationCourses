namespace AHW1
{
    public class Calculator
    {
        private int _numA;
        private int _numB;
        public int NumA
        {
            get
            {
                return _numA;
            }
            set
            {
                _numA = value;
            }
        }
        public int NumB
        {
            get
            {
                return _numB;
            }
            set
            {
                _numB = value;
            }
        }

        public int Add(int a, int b)
        {
            NumA = a;
            NumB = b;
            return a + b;
        }
        public int Sub(int a, int b)
        {
            NumA = a;
            NumB = b;
            return a - b;
        }
        public int Div(int a, int b)
        {
            NumA = a;
            NumB = b;
            return a / b;
        }
        public int Mult(int a, int b)
        {
            NumA = a;
            NumB = b;
            return a * b;
        }
    }
}
