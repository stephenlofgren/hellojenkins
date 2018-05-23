using System;
using Xunit;
using helloworld;

namespace test
{
    public class ProgramShould
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello World", Program.CreateMessage());
        }
    }
}
