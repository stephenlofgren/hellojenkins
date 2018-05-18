using System;
using Xunit;
using helloworld;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello World", Program.CreateMessage());
        }
    }
}
