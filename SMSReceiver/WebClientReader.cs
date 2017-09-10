using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SMSReceiver
{
    public static class WebClientReader
    {
        /// <summary>
        /// Return Phone List
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static List<string> GetList(string url)
        {
            const string str = @"button-small numbutton";

            string result;
            using (var client2 = new WebClient())
            {
                result = client2.DownloadString(url);
            }

            var lstPhone = new List<string>();
            using (var reader = new StringReader(result))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains(str))
                        {
                            lstPhone.Add(line.Substring(line.LastIndexOf(str, StringComparison.Ordinal), 36).Replace(str, "").Replace("\">", "").Replace(" ", ""));
                        }
                    }
                } while (line != null);
            }
            return lstPhone;
        }

        public static List<string> GetStringData(string phonenumber, string prefix, bool clearprefix)
        {
            string result;
            var lstResult = new List<string>();

            phonenumber = phonenumber.Replace("+", "");
            using (var client = new WebClient())
            {
                result = client.DownloadString($"https://smsreceivefree.com/info/{phonenumber}/");
            }

            using (var reader = new StringReader(result))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains(prefix))
                        {
                            result = clearprefix ? (line.Replace(prefix, "")) : line;
                            lstResult.Add(result);
                        }
                    }
                } while (line != null);
            }
            return lstResult;
        }
    }
}