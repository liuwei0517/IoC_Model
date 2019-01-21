using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoalaInterFace.Models
{
    public class Result<T> where T:class
    {
        public string error_code { get; set; }
        public string error_massage { get; set; }
        public List<T> data { get; set; }
    }
}