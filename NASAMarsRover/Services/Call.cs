using System.Net;

namespace NASAMarsRover.Services
{
    public class Call
    {
        private static Call instance;

        private Call() { }

        public static Call Instance
        {
            get
            {
                if (instance == null)
                    instance = new Call();
                return instance;
            }
        }

        public HttpResponseMessage CallThirdPartyAPI(string apiUrl)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;

            return response;

        }

    }
}
