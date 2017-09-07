using System.Collections.Generic;

namespace SMSReceiver
{
    public class PhoneNumber
    {
        private string _url;

        /// <summary>
        /// Specify the full URL, eg: https://smsreceivefree.com/country/canada
        /// </summary>
        /// <param name="url"></param>
        public PhoneNumber(string url)
        {
            _url = url;
        }

        public List<string> GetPhoneList()
        {
            var result = WebClientReader.GetList(_url);
            return result;
        }
    }
}