using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_test_3.Models;
using System.Threading;

namespace webapi_test_3.Controllers
{
    public class ItemController : ApiController
    {
        Item[] items = new Item[]{
            new Item{
                        id = "a",
                        type = "phone number",
                        value = "555-123-456"
                    }, new Item{
                        id = "b",
                        type = "email",
                        value = "kyawtun@yathit.com"
                    }, new Item{
                        id = "c",
                        type = "blog",
                        value = "http://www.yathit.com"
                    }, new Item{
                        id = "d",
                        type = "fax",
                        value = "555-999-9999"
                    }, new Item{
                        id = "e",
                        type = "full name",
                        value = "Kyaw Tun"
                    }, new Item{
                        id = "f",
                        type = "phone",
                        value = "555-111-9999"
                    }, new Item{
                        id = "g",
                        type = "Conpany",
                        value = "Yathit"
                    }
        };

        Random rand = new Random();

        public IEnumerable<Item> GetAllItems()
        {
            return items;
        }


        public IHttpActionResult GetItem(String id)
        {
            var contact = items.FirstOrDefault((p) => id.EndsWith(p.id));
            if (contact == null)
            {
                return NotFound();
            }

            int t = (int) (10000 * rand.NextDouble());
            Thread.Sleep(t);
            return Ok(contact);
        }
    }
}
