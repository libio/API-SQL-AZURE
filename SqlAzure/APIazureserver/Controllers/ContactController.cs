using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using APIazureserver.Models;
namespace APIazureserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private ContactsContext contactsContext;
        public ContactController(ContactsContext context){
            contactsContext=context;
        }
         // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> Get()
        {
            return contactsContext.ContactSet.ToList();
        }
         // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Contacts> Get(string id)
        {
            var selectedContact = (from c in contactsContext.ContactSet
                                  where c.dni == id
                                  select c).FirstOrDefault();
            return selectedContact;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Contacts value)
        {
            Contacts newContact = value;
            contactsContext.ContactSet.Add(newContact);
            contactsContext.SaveChanges();

            return Ok("El user se ha agregado correctamente a la base de datos");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        ~ContactController()
        {
            contactsContext.Dispose();
        }
    }
}