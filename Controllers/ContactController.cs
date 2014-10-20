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
    public class ContactController : ApiController
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
                    }
        };

        Contact[] contacts = new Contact[]{
            new Contact{
                id = 1,
                name = "Alace",
                itemIds = new String[]{"a", "b"}
            },  new Contact{
                id = 2,
                name = "Bob",
                itemIds = new String[]{"c", "d"}
            },  new Contact{
                id = 5,
                name = "Kyaw",
                itemIds = new String[]{"e"}
            }
        };

        public IEnumerable<Contact> GetAllContacts()
        {
            return contacts;
        }

  
        public IHttpActionResult GetContact(int id)
        {
            var contact = contacts.FirstOrDefault((p) => p.id == id);
            if (contact == null)
            {
                return NotFound();
            }
            contact.items = items.Where((p) => contact.itemIds.Contains(p.id)).ToArray();
            
            Thread.Sleep(id * 1000);
            return Ok(contact);
        }
    }
    
}
