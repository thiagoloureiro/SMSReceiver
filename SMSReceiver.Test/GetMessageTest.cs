using Xunit;

namespace SMSReceiver.Test
{
    public class GetMessageTest
    {
        [Fact]
        public void GetMessage_Success()
        {
            // Arrange
            string phonenumber = "19028005845";
            string prefix = "Your amico account code is: ";
            bool clearprefix = true;

            // Act
            var objMessage = new RetrieveData(phonenumber, prefix, clearprefix);
            var ret = objMessage.ReturnData();

            // Assert
            Assert.True(ret.Length > 0);
        }
    }
}