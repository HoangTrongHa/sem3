using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace NetWork.Models
{
    public class NetWorks
    {
        public class Content
        {
            public string description { get; set; }
            public string url { get; set; }
        }

        public class Root
        {
            public int id { get; set; }
            public string date { get; set; }
            public string title { get; set; }
            public string image { get; set; }
            public Content content { get; set; }
        }
        public async static Task<Root> getNetWork()
        {
            var http = new HttpClient();
            var url = string.Format("http://api-demo-anhth.herokuapp.com/data.json");
            var response = await http.GetAsync(url); // nhan data tu json
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(Root)); //dong bo 
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)); // format de khong bi loi 
            var data = (Root)serializer.ReadObject(ms); // Doc ra giu lieu data
            return data;
        }

    }
}
