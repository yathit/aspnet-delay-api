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
                itemIds = new String[]{"aa", "ab", "ac", "ad", "ae"}
            },  new Contact{
                id = 2,
                name = "Bob",
                itemIds = new String[]{"ba", "bb", "bc", "bd", "be"}
            },  new Contact{
                id = 3,
                name = "Kyaw",
                itemIds = new String[]{"ka", "kb", "kc", "kd", "ke"}
            },  new Contact{
                id = 4,
                name = "Tun",
                itemIds = new String[]{"ta", "tb", "tc", "td", "te"}
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
