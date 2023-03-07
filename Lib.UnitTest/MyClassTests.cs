using TestLib;

namespace Lib.UnitTest
{
    public class MyClassTests
    {
        [Fact]
        public void TestAdd()
        {
            // Arrange
            MyClass myClass = new MyClass();

            // Act
            int result = myClass.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestSubtract()
        {
            // Arrange
            MyClass myClass = new MyClass();
        
            // Act
            int result = myClass.Subtract(3, 2);
        
            // Assert
            Assert.Equal(1, result);
        }
    }
}