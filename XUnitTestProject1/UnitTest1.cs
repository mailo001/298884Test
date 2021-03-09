using ClassLibrary3;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyString()
        {
            StringCalculator calc = new StringCalculator();
            string empty = string.Empty;
            Assert.Equal(0, calc.Add(empty));
        }
        [Fact]
        public void SingleNumber() 
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(1, calc.Add("1"));
        }
        [Fact]
        public void ComaDelim() 
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(3, calc.Add("1,2"));
        }
        [Fact]
        public void NewLine()
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(3, calc.Add("1 \n 2"));
        }
        [Fact]
        public void ThreeNumbers()
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(8, calc.Add("1 \n 2 , 5"));
        }
        [Fact]
        public void NegativeNumber()
        {
            StringCalculator calc = new StringCalculator();
            Assert.Throws<ArgumentException>(() => calc.Add("1 \n -2 , 5"));
        }
        [Fact]
        public void BigNumber()
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(3, calc.Add("1 \n 2 , 5000"));
        }
        [Fact]
        public void SingleDelimiter()
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(3, calc.Add("//# 1 \n 2 , 5000"));
        }
        [Fact]
        public void DelimitersInBrackets()
        {
            StringCalculator calc = new StringCalculator();
            Assert.Equal(3, calc.Add("//[fdf] 1 \n 2 , 5000"));
        }
    }
}
