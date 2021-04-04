using Xunit;
using SourceMock.Tests.TestInterfaces;

namespace SourceMock.Tests {
    public class ArgumentTests {
        [Fact]
        public void SingleArgument() {
            var mock = Mock.Of<IMockable>().Get();

            mock.Setup.ParseToInt32("1").Returns(1);
            mock.Setup.ParseToInt32("2").Returns(2);

            Assert.Equal(2, mock.ParseToInt32("2"));
        }

        [Fact]
        public void SingleArgument_NullValue() {
            var mock = Mock.Of<IMockable>().Get();

            mock.Setup.ParseToInt32(null).Returns(1);

            Assert.Equal(1, mock.ParseToInt32(null));
        }

        [Fact]
        public void SingleArgument_Interface() {
            var mock = Mock.Of<IMockable>().Get();
            var argument = new EmptyClass();

            mock.Setup.TestInterface(argument).Returns(true);

            Assert.True(mock.TestInterface(argument));
        }

        [Fact]
        public void SingleArgument_Optional() {
            var mock = Mock.Of<IMockable>().Get();

            mock.Setup.ParseToInt32().Returns(1);

            Assert.Equal(1, mock.ParseToInt32("x"));
        }

        [Fact]
        public void MultipleArguments() {
            var mock = Mock.Of<IMockable>().Get();

            mock.Setup.Sum(1, 2).Returns(3);

            Assert.Equal(3, mock.Sum(1, 2));
        }

        private class EmptyClass : IEmptyInterface {}
    }
}