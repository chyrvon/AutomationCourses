using NUnit.Framework;

namespace AHW1
{
    [TestFixture]
    [Author("Yevhen Chyrvon")]
    class CalcTests
    {
        [Test]
        [Description("Verify add operation")]
        [Category("Add_Sub")]
        [Order(1)]
        [Combinatorial]
        public void Add([Values(-10, 0, 10)] int numA, [Values(-10, 20, 0)] int numB)
        {
            Calculator calc = new Calculator();
            int actualResult = calc.Add(numA, numB);
            ToConsole($"Add: " +
                $"{numA} + {numB} = {actualResult}");
            Assert.AreEqual(numA + numB, actualResult, "Verify operation Add: False");
        }

        [Test, Description("Verify divide operation")]
        [Order(3)]
        [Timeout(100)]
        public void Div()
        {
            Calculator calc = new Calculator();
            int actualResult = calc.Div(Constants.NumA_Div, Constants.NumB_Div);
            ToConsole($"Div: " +
                $"{Constants.NumA_Div} / {Constants.NumB_Div} = {actualResult}");
            Assert.AreEqual(Constants.ExpectedResultDiv, actualResult, "Verify divide operation: False");
        }

        [Test, Description("Verify substract operation")]
        [Category("Add_Sub")]
        [Order(2)]
        [Retry(2)]
        public void Sub()
        {
            Calculator calc = new Calculator();
            int actualResult = calc.Sub(Constants.NumA_Sub, Constants.NumB_Sub);
            ToConsole($"Sub: " +
                $"{Constants.NumA_Sub} - {Constants.NumB_Sub} = {actualResult}");
            Assert.AreEqual(Constants.ExpectedResultSub, actualResult, "Verify substract operation: False");
        }
        
        [Test, Description("Verify multiply operation")]
        [MaxTime(100)]
        public void Mult()
        {
            Calculator calc = new Calculator();
            int actualResult = calc.Mult(Constants.NumA_Mult, Constants.NumB_Mult);
            ToConsole($"Mult: " +
               $"{Constants.NumA_Mult} x {Constants.NumB_Mult} = {actualResult}");
            Assert.AreEqual(Constants.ExpectedResultMult, actualResult, "Verify multiply operation: False");
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ToConsole("-----------------------------");
            ToConsole("Started testing new operation");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ToConsole("Ended testing operation");
            ToConsole("-----------------------");
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

        public static void ToConsole(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}
