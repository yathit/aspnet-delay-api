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
                        type = "full name",
                        value = "Alace"
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
                        type = "phone",
                        value = "999-111-3333"
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
            var item = items.FirstOrDefault((p) => id.EndsWith(p.id));
            if (item == null)
            {
                return NotFound();
            }
            if (id == "bob-a")
            {
                item.value = "Bob";
            }
            if (id == "kyaw-a")
            {
                item.value = "Kyaw";
            }
            if (id == "tun-a")
            {
                item.value = "Tun";
            }

            int t = (int) (10000 * rand.NextDouble());
            Thread.Sleep(t);
            return Ok(item);
        }
    }
}
