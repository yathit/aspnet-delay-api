using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_test_3.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public Item[] items { get; set; }
        public string[] itemIds { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }

}