using NUnit.Framework;
using Multiplicacion;

namespace Multiplicacion.Tests
{
    public class Tests
    {
        [Test]
        public void Multiplication_of_positives_2_and_6_returns_12()
        {
            Assert.AreEqual(12, Calculator.Multiply(2,6));
        }

        [Test]
        public void Multiplication_of_negative_6_and_623_returns_negative_3738()
        {
            Assert.AreEqual(-3738, Calculator.Multiply(-6, 623));
        }

        [Test]
        public void Multiplication_of_negatives_5_and_35_returns_positive_175()
        {
            Assert.AreEqual(175, Calculator.Multiply(-5, -35));
        }

         [Test]
        public void Multiplication_of_0_and_MAXValue_returns_0()
        {
            Assert.AreEqual(0, Calculator.Multiply(0, int.MaxValue));
        }

        [Test]
        public void Multiplication_of_5_billion_and_47_Exceeds_MaximumValue_Throws_System_Overflow_Exception()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Multiply(5000000000, 47));
        }

        [Test]
        public void If_Multiplication_of_negative_9999999_and_8363_Is_Under_MinimunValue_Throws_System_Overflow_Exception()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Multiply(-9999999, 8363));
        }

        [Test]
        public void Multiplication_of_MINIMUMVALUE_and_5__Throws_OverflowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Multiply(int.MinValue, 5));
        }
        
        [Test]
        public void Multiplication_of_12_and_MAXIMUMVALUE_Throws_OverflowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Multiply(12, int.MaxValue));
        }

    }
}