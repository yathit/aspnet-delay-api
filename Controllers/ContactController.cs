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
     
        Contact[] contacts = new Contact[]{
            new Contact{
                id = 1,
                name = "Alace",
                itemIds = new String[]{"alace-a", "alace-b", "alace-c", "alace-d", "alace-e"}
            },  new Contact{
                id = 2,
                name = "Bob",
                itemIds = new String[]{"bob-a", "bob-b", "bob-c", "bob-d", "bob-e"}
            },  new Contact{
                id = 3,
                name = "Kyaw",
                itemIds = new String[]{"kyaw-a", "kyaw-b", "kyaw-c", "kyaw-d", "kyaw-e"}
            },  new Contact{
                id = 4,
                name = "Tun",
                itemIds = new String[]{"tun-a", "tun-b", "tun-c", "tun-d", "tun-e"}
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
        
            return Ok(contact);
        }
    }
    
}
