using System.Collections.Generic;
using hardware_store.Models;

namespace hardware_store.DataBase
{
  public static class Data
  {
    public static List<Tool> Inventory = new List<Tool>()
    {
      new Tool("Hammer", 1234, 5.98m),
      new Tool("screwdriver", 1235, 1.99m)
    };
  }
}
