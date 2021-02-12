using Xunit;
using System;
using production;

namespace productionTests
{
    public class TestFail
    {
        [Fact]
        public void TestTryExceptionError()
        { 
            var exercise = new Exercises();
            int result = exercise.Sum(1,2);
            Assert.Equal(3, exercise.InitialValue);
         }
    }
}
