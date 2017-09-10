using System.Collections.Generic;

namespace SMSReceiver
{
    public class RetrieveData
    {
        private readonly string _phonenumber;
        private readonly string _prefix;
        private readonly bool _clearprefix;

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="phonenumber">PhoneNumber used to receive the Message</param>
        /// <param name="prefix">Prefix used: eg: Your amico account code is: </param>
        /// <param name="clearprefix">Clear the prefix and returns only the code</param>
        public RetrieveData(string phonenumber, string prefix, bool clearprefix)
        {
            _phonenumber = phonenumber;
            _clearprefix = clearprefix;
            _prefix = prefix;
        }

        /// <summary>
        /// Returns the string from PhoneNumber/Prefix provided
        /// </summary>
        /// <returns></returns>
        public string ReturnString()
        {
            var result = WebClientReader.GetStringData(_phonenumber, _prefix, _clearprefix);
            return result.Count > 0 ? result[0] : null;
        }

        /// <summary>
        /// Returns the <list type="string"/> from PhoneNumber/Prefix provided
        /// </summary>
        /// <returns></returns>
        public List<string> ReturnStringList()
        {
            var result = WebClientReader.GetStringData(_phonenumber, _prefix, _clearprefix);
            return result;
        }
    }
}