using ClassLibrary1;
using NUnit.Framework;

namespace AHW1
{
    [TestFixture]
    [Author("Yevhen Chyrvon")]
    public class CalcTests
    {
        private Calculator calc;
        private AssertsAccumulator Test;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Test = new AssertsAccumulator();
            //calc = calc ?? new Calculator();
            calc = new Calculator();
            ToConsole("-----------------------------");
            ToConsole("Started testing new operation");
        }

        [SetUp]
        public void SetUp()
        {
            ToConsole("Start test operation");
        }

        [TearDown]
        public void TearDown()
        {
            ToConsole("End test");
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ToConsole("Ended testing operation");
            ToConsole("-----------------------");
        }

        [Test]
        [Description("Verify add operation")]
        [Category("Add_Sub")]
        [Order(1)]
        [Combinatorial]
        public void Add([Values(-10, 0, 10)] int numA, [Values(-10, 20, 0)] int numB)
        {
            int actualResult = calc.Add(numA, numB);
            ToConsole($"Add: " +
                $"{numA} + {numB} = {actualResult}");

            Assert.That((numA + numB).Equals(actualResult));
            Test.Accumulate(() =>
            Assert.AreEqual(numA + numB, actualResult + 1,
            "XXX"));

            Test.Accumulate(() => 
            Assert.AreEqual(numA + numB, actualResult, 
            "Verify operation Add: False"));

            Test.Accumulate(() =>
            Assert.AreEqual(numA + numB, actualResult - 1,
            "YYY"));
        }

        [Test, Description("Verify substract operation")]
        [Category("Add_Sub")]
        [Order(2)]
        [Retry(2)]
        public void Sub()
        {
            int actualResult = calc.Sub(Constants.NumA_Sub, Constants.NumB_Sub);
            ToConsole($"Sub: " +
                $"{Constants.NumA_Sub} - {Constants.NumB_Sub} = {actualResult}");
            Assert.AreEqual(Constants.ExpectedResultSub, actualResult, "Verify substract operation: False");
        }

        [Test, Description("Verify divide operation")]
        [Order(3)]
        [Timeout(100)]
        public void Div()
        {
            int actualResult = calc.Div(Constants.NumA_Div, Constants.NumB_Div);
            ToConsole($"Div: " +
                $"{Constants.NumA_Div} / {Constants.NumB_Div} = {actualResult}");
            Assert.AreEqual(Constants.ExpectedResultDiv, actualResult, "Verify divide operation: False");
        }
        
        [Test, Description("Verify multiply operation")]
        [MaxTime(100)]
        public void Mult()
        {
            int actualResult = calc.Mult(Constants.NumA_Mult, Constants.NumB_Mult);
            ToConsole($"Mult: " +
               $"{Constants.NumA_Mult} x {Constants.NumB_Mult} = {actualResult}");
            Assert.AreEqual(Constants.ExpectedResultMult, actualResult, "Verify multiply operation: False");
        }

        public static void ToConsole(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}
