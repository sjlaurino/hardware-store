namespace hardware_store.Models
{
  public class Cat
  {
    public string Name { get; set; }

    public int Age { get; set; }

    public int Id { get; set; }

    public Cat(string name, int age, int id)
    {
      Name = name;
      Age = age;
      Id = id;
    }
  }
}