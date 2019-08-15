using ClassLibrary1;
using NUnit.Framework;
using System;

namespace AHW1
{

    //Create several tests for 
    //String asserts(Contains, StartsWith, AreEqualIgnoringCase) that will test built-in String methods.


    [TestFixture]
    class CalcScientificTest
    {
        [Test]
        public void StringTest()
        {
            string strActual = "First test on local machine";
            string strBExpected = "First test";
            AssertsAccumulator Test2 = new AssertsAccumulator();

            Test2.Accumulate(() =>
            CollectionAssert.AreEquivalent(strActual, strBExpected, "Test equal A = b : False"));


            Assert.IsTrue(string.Equals(strActual, strBExpected, StringComparison.OrdinalIgnoreCase));




            Test2.Accumulate(() =>
            CollectionAssert.AreNotEquivalent(strActual, "First test on local machine", "Test equal A = const : True"));
        }


        [Test]
        public void Pow()
        {
            double numA = 5;
            double numB = 2;
            ScientificCalculator scientific = new ScientificCalculator();
            double actualResult = scientific.Pow(numA, numB);
            ToConsole($"Pow: " +
                $"{numA} ^ {numB} = {actualResult}");
            Assert.AreEqual(numA*numA, actualResult, "Verify operation Pow: False");
        }

        [Test]
        public void Percents()
        {
            double number = 100;
            double persent = 20;
            ScientificCalculator scientific = new ScientificCalculator();
            double actualResult = scientific.Percents(number, persent);
                
            ToConsole($"Percents: " +
                $"{persent}% from {number} = {actualResult}");
            Assert.AreEqual((number / 100 * persent), actualResult, "Verify operation Percents: False");
        }

        [Test]
        public void Mod()
        {
            int a = -5;
            int b = 3;
            ScientificCalculator scientific = new ScientificCalculator();
            double actualResult = scientific.Mod(a, b);

            ToConsole($"Mod: " +
                $"{a} mod {b} = {actualResult}");
            Assert.AreEqual(((Math.Abs(a * b) + a) % b), actualResult, "Verify operation Mod: False");
        }

        [Test]
        public void SumOfArray()
        {
            int[] array = {1, 2, 3, 4, 5};
            ScientificCalculator scientific = new ScientificCalculator();
            double actualResult = scientific.sumOfArray(array);
            ToConsole($"Sum of Array = {actualResult}");
            foreach(int element in array)
            {
                ToConsole(array[element-1].ToString());
            }
            Assert.AreEqual(15, actualResult, "Verify operation SumOfArray: False");
        }

        [Test]
        public void MinOfArray()
        {
            int[] array = {3, 1, 2, 4, 5 };
            ScientificCalculator scientific = new ScientificCalculator();
            double actualResult = scientific.minOfArray(array);
            ToConsole($"Min of Array = {actualResult}");
            foreach (int element in array)
            {
                ToConsole(array[element - 1].ToString());
            }
            Assert.AreEqual(1, actualResult, "Verify operation MinOfArray: False");
        }

        [Test]
        public void MaxOfArray()
        {
            int[] array = {3, 1, 5, 4, 2};
            ScientificCalculator scientific = new ScientificCalculator();
            double actualResult = scientific.maxOfArray(array);
            ToConsole($"Max of Array = {actualResult}");
            foreach (int element in array)
            {
                ToConsole(array[element - 1].ToString());
            }
            Assert.AreEqual(5, actualResult, "Verify operation MaxOfArray: False");
        }

        public static void ToConsole(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}