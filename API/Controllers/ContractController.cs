using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ContractController : ApiController
    {
        // GET: api/Contract
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Contract/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contract
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Contract/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contract/5
        public void Delete(int id)
        {
        }
    }
}
