namespace FunctionStubs.Tests
{
    public class FunctionStubsTests
    {
        [Fact]
        public void IntToIntFuncTest()
        {
            Assert.Equal(0, FunctionStubs.IntToIntFunc(0));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-4)]
        [InlineData(0)]
        public void IntToIntFuncParameterizedTest(int input)
        {
            Assert.Equal(0, FunctionStubs.IntToIntFunc(input));
        }

        [Fact]
        public void ListToIntFuncTest()
        {
            Assert.Equal(0, FunctionStubs.ListToIntFunc(new List<int>()));
        }

        public static IEnumerable<object[]> InputLists()
        {
            yield return new object[] { new List<int> { } };
            yield return new object[] { new List<int> { 1 } };
            yield return new object[] { new List<int> { 42, 0 } };
        }

        [Theory]
        [MemberData(nameof(InputLists))]
        public void ListToIntFuncParameterizedTest(List<int> input)
        {
            Assert.Equal(0, FunctionStubs.ListToIntFunc(input));
        }

        [Fact]
        public void ListToListFuncTest()
        {
            Assert.Equal(new List<int>(), FunctionStubs.ListToListFunc(new List<int>()));
        }

        [Theory]
        [MemberData(nameof(InputLists))]
        public void ListToListFuncParameterizedTest(List<int> input)
        {
            Assert.Equal(new List<int>(), FunctionStubs.ListToListFunc(input));
        }
    }
}