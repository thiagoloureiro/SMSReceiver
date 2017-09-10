using System;
using System.Collections.Generic;

namespace SMSReceiver.Sample
{
    internal class Program
    {
        private static List<string> _phoneList;

        private static void Main()
        {
            GetPhoneList();
            GetMessage();
            GetMessageList();
        }

        private static void GetPhoneList()
        {
            var objPhoneList = new PhoneNumber("https://smsreceivefree.com/country/canada");
            _phoneList = objPhoneList.GetPhoneList();

            foreach (var phone in _phoneList)
            {
                Console.WriteLine(phone);
            }

            Console.ReadKey();
        }

        private static void GetMessage()
        {
            if (_phoneList.Count > 0)
            {
                var obj = new RetrieveData(_phoneList[0], "verification code", false);
                Console.WriteLine(obj.ReturnString());
            }
            Console.ReadKey();
        }

        private static void GetMessageList()
        {
            if (_phoneList.Count > 0)
            {
                var obj = new RetrieveData(_phoneList[0], "verification code", false);
                var results = obj.ReturnStringList();

                foreach (var message in results)
                {
                    Console.WriteLine(message);
                }
            }
            Console.ReadKey();
        }
    }
}