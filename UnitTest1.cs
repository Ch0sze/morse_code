using System;
using Xunit;
using morse;

namespace morse.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Zakoduj_TestFunkcnosti()
        {
            string expected = ("-- --- .-. ... . / -.-. --- -.. . ");
            string actuall = Morseovka.Zakoduj("morse code");
            Assert.Equal(expected, actuall);

        }

        [Fact]
        public void Dekoduj_TestFunkcnosti()
        {
            string expected = ("morse code");
            string actuall = Morseovka.Dekoduj("-- --- .-. ... . / -.-. --- -.. .");
            Assert.Equal(expected, actuall);

        }
    }
}
