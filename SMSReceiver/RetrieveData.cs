namespace SMSReceiver
{
    public class RetrieveData
    {
        private string _phonenumber;
        private string _prefix;
        private bool _clearprefix;

        public RetrieveData(string phonenumber, string prefix, bool clearprefix)
        {
            _phonenumber = phonenumber;
            _clearprefix = clearprefix;
            _prefix = prefix;
        }

        public string ReturnData()
        {
            var result = WebClientReader.GetStringData(_phonenumber, _prefix, _clearprefix);
            return result;
        }
    }
}