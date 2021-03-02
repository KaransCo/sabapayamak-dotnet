using Newtonsoft.Json;
using SabaPayamak.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SabaPayamak
{
    public class SabaPayamakAPI
    {
        private string _apiUrl = "https://api.sabapayamak.com";

        private const string TOKEN_URL = "/api/v1/user/authenticate";
        private const string CREDIT_URL = "/api/v1/credit";
        private const string CREDIT_DATE_URL = "/api/v1/credit";
        private const string CREDIT_COUNT_URL = "/api/v1/credit";
        private const string CREDIT_SNED_SMS_URL = "/api/v1/credit/send-sms";
        private const string CREDIT_RECIVED_SMS_URL = "/api/v1/credit/recived";
        private const string CREDIT_CHARGE_SMS_URL = "/api/v1/credit/charge";
        private const string CREDIT_MONEY_BACK_SMS_URL = "/api/v1/credit/money-back";
        private const string MESSAGE_DATE_URL = "/api/v1/messages";
        private const string MESSAGE_GET_URL = "/api/v1/messages";
        private const string MESSAGE_NUMBER_URL = "/api/v1/messages/number";
        private const string MESSAGE_SEND_URL = "/api/v1/messages";
        private const string MESSAGE_DELIVERY_URL = "/api/v1/deliveries";
        private const string RECIVED_MESSAGE_DATE_URL = "/api/v1/recived-messages";
        private const string RECIVED_MESSAGE_NUMBER_URL = "/api/v1/recived-messages";
        private const string RECIVED_MESSAGE_NUMBER_UNREAD_URL = "/api/v1/recived-messages";
        private const string RECIVED_MESSAGE_UNREAD_URL = "/api/v1/recived-messages/unread";
        private const string RECIVED_MESSAGE_VNUMBER_URL = "/api/v1/recived-messages/virtaul-number";
        private const string RECIVED_MESSAGE_VNUMBER_UNREAD_URL = "/api/v1/recived-messages/virtaul-number";

        public SabaPayamakAPI(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public string GetToken(string userName,string password,string virtualNumber,int validDay)
        {
            LoginViewModel login = new LoginViewModel()
            {
                Username = userName,
                Password = password,
                VirtualNumber = virtualNumber,
                TokenValidDay = validDay
            };
            var content = JsonConvert.SerializeObject(login);
            return Post(_apiUrl+TOKEN_URL,content);
        }
        public string GetCredit(string token)
        {
            string fullpath = _apiUrl + CREDIT_URL;
            return Get(fullpath, token);
        }
        public string GetCreditByDate(string startDate,string endDate, string token)
        {
            string fullpath = _apiUrl + CREDIT_DATE_URL + $"?StartDate={startDate}&EndDate={endDate}";
            return Get(fullpath, token);
        }
        public string GetCreditByCount(int count, string token)
        {
            string fullpath = _apiUrl + CREDIT_COUNT_URL + "/"+count;
            return Get(fullpath, token);
        }
        public string GetSendSmsCreditByCount(int count, string token)
        {
            string fullpath = _apiUrl + CREDIT_SNED_SMS_URL + "/" + count;
            return Get(fullpath, token);
        }
        public string GetRecivedSmsCreditByCount(int count, string token)
        {
            string fullpath = _apiUrl + CREDIT_RECIVED_SMS_URL + "/" + count;
            return Get(fullpath, token);
        }
        public string GetChargeCreditByCount(int count, string token)
        {
            string fullpath = _apiUrl + CREDIT_CHARGE_SMS_URL + "/" + count;
            return Get(fullpath, token);
        }
        public string GetMoneyBackCreditByCount(int count, string token)
        {
            string fullpath = _apiUrl + CREDIT_MONEY_BACK_SMS_URL + "/" + count;
            return Get(fullpath, token);
        }
        public string GetMessageByDate(string startDate, string endDate, string token)
        {
            string fullpath = _apiUrl + MESSAGE_DATE_URL + $"?StartDate={startDate}&EndDate={endDate}";
            return Get(fullpath, token);
        }
        public string GetMessageById(long id, string token)
        {
            string fullpath = _apiUrl + MESSAGE_GET_URL + "/" + id;
            return Get(fullpath, token);
        }
        public string GetMessageByNumber(string number, string token)
        {
            string fullpath = _apiUrl + MESSAGE_NUMBER_URL + "/" + number;
            return Get(fullpath, token);
        }
        public string SendMessage(string text,string[] numbers,string token)
        {
            SendViewModel sendViewModel = new SendViewModel()
            {
                Text = text,
                Numbers = numbers
            };
            var content = JsonConvert.SerializeObject(sendViewModel);
            return Post(_apiUrl + MESSAGE_SEND_URL, content, token);
        }

        public string GetDelivery(long messageId, string token)
        {
            string fullpath = _apiUrl + MESSAGE_DELIVERY_URL + "/" + messageId;
            return Get(fullpath, token);
        }
        public string GetRecievdMessageByDate(string startDate, string endDate, string token)
        {
            string fullpath = _apiUrl + RECIVED_MESSAGE_DATE_URL + $"?StartDate={startDate}&EndDate={endDate}";
            return Get(fullpath, token);
        }
        public string GetRecievdMessageByNumber(string number, string token)
        {
            string fullpath = _apiUrl + RECIVED_MESSAGE_NUMBER_URL + "/" + number;
            return Get(fullpath, token);
        }
        public string GetUnreadRecievdMessageByNumber(string number, string token)
        {
            string fullpath = _apiUrl + RECIVED_MESSAGE_NUMBER_UNREAD_URL + "/" + number + "/unread";
            return Get(fullpath, token);
        }
        public string GetRecievdMessageByVNumber(string number, string token)
        {
            string fullpath = _apiUrl + RECIVED_MESSAGE_VNUMBER_URL + "/" + number;
            return Get(fullpath, token);
        }
        public string GetUnreadRecievdMessageByVNumber(string number, string token)
        {
            string fullpath = _apiUrl + RECIVED_MESSAGE_VNUMBER_UNREAD_URL + "/" + number + "/unread";
            return Get(fullpath, token);
        }
        public string GetUnreadRecievdMessage(string token)
        {
            string fullpath = _apiUrl + RECIVED_MESSAGE_UNREAD_URL ;
            return Get(fullpath, token);
        }



        private static string Post(string path, string data, string key="")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(path);
                    var buffer = Encoding.UTF8.GetBytes(data);
                    var byteContent = new ByteArrayContent(buffer);
                    if (!string.IsNullOrEmpty(key))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
                    }
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var result = client.PostAsync("", byteContent).Result;
                    var res = result.Content.ReadAsStringAsync().Result;
                    return res;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
               
        }
        private static string Get(string path,string key)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
                    var result = client.GetAsync(path).Result;
                    var res = result.Content.ReadAsStringAsync().Result;
                    return res;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
