using Xunit;
using System;
using production;

namespace productionTests
{
    public class TestPass 
    {
        [Fact]
        public void GreaterThanTest()
        {
            var exercise = new Exercises();
            var result = exercise.GreaterThan(5,7);
            Assert.False(result);
        }
    }
}