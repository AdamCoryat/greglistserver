using System;
using System.ComponentModel.DataAnnotations;

namespace greglistserver.Models
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public string id { get; set; } = Guid.NewGuid().ToString();
    public Car(string make, string model)
    {
      this.Make = make;
      this.Model = model;
    }
    public Car()
    {
    }
  }
}