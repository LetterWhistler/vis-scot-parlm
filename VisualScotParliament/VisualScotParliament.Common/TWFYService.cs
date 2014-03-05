using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VisualScotParliament.Common
{
    public class RootMSP
    {
        public string member_id { get; set; }
        public string person_id { get; set; }
        public string name { get; set; }
        public string party { get; set; }
        public string constituency { get; set; }
    }

    /// <summary>
    /// This is a facade for ''They work for you'' API
    /// it is a layer over an API
    /// </summary>
    /// <see cref="http://www.theyworkforyou.com/api/"/>
    public class TWFYService
    {
        //the APIKey for the TWFYService
        public string APIKey { get; set; }
        //template URL for api calls 
        private const string apiURL = "http://www.theyworkforyou.com/api/{0}?key={1}&output=js";

        //the constructor
        public TWFYService(string apiKey)
        {
            APIKey = apiKey;
        }

        public String GetMSPs()
        {
            string url = string.Format(apiURL, "getMSPs", APIKey);
            WebClient wc = new WebClient();
           //download data from url (data stored as json) and store it in a new string
            string json=wc.DownloadString(url);
           
            var data= JsonConvert.DeserializeObject<List<RootMSP>>(json);

            StringBuilder sb = new StringBuilder();

    
            //create a string that will have all MSP info
            foreach (var item in data)
            {
                sb.AppendFormat("{0},{1},{2},{3},{4}\r\n", item.member_id, item.person_id, item.name, item.constituency, item.party);
            }
            return sb.ToString();
        }
    }
}
