using Xunit;

namespace CodeChallenges.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Initialization()
        {
            var expected = 1.1;
            var target = new Calculator(1.1);
            Assert.Equal(expected, target.Result, 1);
        }

        [Fact]
        public void BasicAdd()
        {
            var target = new Calculator(1.1);
            target.Add(2.2);
            var expected = 3.3;
            Assert.Equal(expected, target.Result, 1);
        }

        [Fact]
        public void BasicSubtract()
        {
            var target = new Calculator(3.3);
            target.Subtract(2.2);
            var expected = 1.1;
            Assert.Equal(expected, target.Result, 1);
        }

        //[Fact()]
        //public void CalculatorTest()
        //{
        //    Assert.True(false, "This test needs an implementation");
        //}

        //[Fact()]
        //public void AddTest()
        //{
        //    Assert.True(false, "This test needs an implementation");
        //}

        //[Fact()]
        //public void ResultTest()
        //{
        //    Assert.True(false, "This test needs an implementation");
        //}
    }
}