using Xunit;

namespace SMSReceiver.Test
{
    public class PhoneNumberTest
    {
        [Fact]
        public void GetPhoneNumberList_Success()
        {
            // Arrange
            var objCanada = new PhoneNumber("https://smsreceivefree.com/country/canada");
            var objUsa = new PhoneNumber("https://smsreceivefree.com/country/usa");
            var objUk = new PhoneNumber("https://smsreceivefree.com/country/united-kingdom");

            // Act
            var ret1 = objCanada.GetPhoneList();
            var ret2 = objUsa.GetPhoneList();
            var ret3 = objUk.GetPhoneList();

            // Assert
            Assert.True(ret1.Count > 0);
            Assert.True(ret2.Count > 0);
            Assert.True(ret3.Count > 0);
        }
    }
}