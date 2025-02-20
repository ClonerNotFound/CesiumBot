using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesiumBot.config
{
    public class JSONReader
    {
        public string token {  get; set; }
        public string prefix { get; set; }

        public async Task ReadJson()
        {
            using (StreamReader sr = new StreamReader( path: "config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONStructure jsonStructure = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONStructure>(json);

                token = jsonStructure.token;
                prefix = jsonStructure.prefix;
            }
        }
    }

    internal sealed class JSONStructure
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }
}
