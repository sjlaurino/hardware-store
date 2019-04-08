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
  public class ToolController : ControllerBase
  {
    List<Tool> Inventory = Data.Inventory;
    // GET ALL api/tool
    [HttpGet]
    public ActionResult<List<Tool>> Get()
    {
      return Inventory;
    }

    // GET ONE api/tool/5
    [HttpGet("{id}")]
    public ActionResult<Tool> GetById(int id)
    {
      Tool found = Inventory.Find(T => T.Id == id);

      if (found != null)
      {
        return found;
      }
      return BadRequest("{\"error\": \"not found\"}");
    }

    // POST api/tool
    [HttpPost]
    public ActionResult<List<Tool>> Post([FromBody] Tool newTool)
    {
      Inventory.Add(newTool);
      return Inventory;
    }

    // PUT api/tool/:id
    [HttpPut("{id}")]
    public ActionResult<Tool> Put(int id, [FromBody] Tool newTool)
    {
      Tool oldTool = Inventory.Find(T => T.Id == id);
      if (oldTool != null)
      {
        Inventory.Remove(oldTool);
        Inventory.Add(newTool);
        return newTool;
      }
      else { return BadRequest(); }
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Tool oldTool = Inventory.Find(T => T.Id == id);

      if (oldTool != null)
      {
        Inventory.Remove(oldTool);
        return Ok();
      }
      else { return BadRequest(); }
    }
  }
}
