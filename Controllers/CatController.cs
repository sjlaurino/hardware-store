using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hardware_store.Models;
using hardware_store.DataBase;

namespace hardware_store.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatController : ControllerBase
  {
    List<Cat> CatInventory = Data.CatInventory;
    // GET ALL api/cat
    [HttpGet]
    public ActionResult<List<Cat>> Get()
    {
      return CatInventory;
    }

    // GET ONE api/cat/5
    [HttpGet("{id}")]
    public ActionResult<Cat> GetById(int id)
    {
      Cat found = CatInventory.Find(C => C.Id == id);

      if (found != null)
      {
        return found;
      }
      return BadRequest("{\"error\": \"not found\"}");
    }

    // POST api/cat
    [HttpPost]
    public ActionResult<List<Cat>> Post([FromBody] Cat newCat)
    {
      CatInventory.Add(newCat);
      return CatInventory;
    }

    // PUT api/cat/:id
    [HttpPut("{id}")]
    public ActionResult<Cat> Put(int id, [FromBody] Cat newCat)
    {
      Cat oldCat = CatInventory.Find(T => T.Id == id);
      if (oldCat != null)
      {
        CatInventory.Remove(oldCat);
        CatInventory.Add(newCat);
        return newCat;
      }
      else { return BadRequest(); }
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Cat oldCat = CatInventory.Find(T => T.Id == id);

      if (oldCat != null)
      {
        CatInventory.Remove(oldCat);
        return Ok();
      }
      else { return BadRequest(); }
    }
  }
}
