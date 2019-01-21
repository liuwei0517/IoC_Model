using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFaceCode
{
    public class Convert
    {
        public string ObjectToJson<T>(T t) where T:class
        {
            string json=JsonConvert.SerializeObject(t);
            return json;
        }
    }
}
