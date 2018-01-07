using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Entsoftlab.University.Questioning.AdminUi.Controllers {
  [Route("api/[controller]")]
  public class ValuesController : Controller {
    // GET api/values
    [HttpGet]
    public IEnumerable<dynamic> Get() {
      return new dynamic[] { new { CompanyName="Laptop"}, new { CompanyName = "Smart TV"}, new { CompanyName = "Smart Phone"}, new { CompanyName = "Tablet"} };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id) {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value) {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value) {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id) {
    }
  }
}
