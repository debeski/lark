using Xunit;

namespace task.Tests
{
    public class LoginTests
    {
        [Fact]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "admin";
            string password = "password123";

            // Act
            bool result = Program.Login(username, password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Login_InvalidUsername_ReturnsFalse()
        {
            // Arrange
            string username = "invalidUser";
            string password = "password123";

            // Act
            bool result = Program.Login(username, password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Login_InvalidPassword_ReturnsFalse()
        {
            // Arrange
            string username = "admin";
            string password = "wrongPassword";

            // Act
            bool result = Program.Login(username, password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Login_EmptyCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "";
            string password = "";

            // Act
            bool result = Program.Login(username, password);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void Login_AlwaysFailsTest()
        {
            // Arrange
            string username = "";
            string password = "";

            // Act
            bool result = Program.Login(username, password);

            // Assert
            Assert.False(true); // This should deliberately fail
        }
    }
}
