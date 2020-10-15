using System;
using System.Collections.Generic;
using greglistserver.db;
using greglistserver.Models;

namespace greglistserver.Services
{
  public class CarsService
  {
    public IEnumerable<Car> GetCars()
    {
      return REALDB.Cars;
    }
    public Car GetById(string id)
    {
      Car data = REALDB.Cars.Find(c => c.id == id);
      if(data != null)
      {
          return data;
      }
      throw new Exception("No Cars to find! Or Invalid Id.");
    }

    public Car Create(Car newCar)
    {   
      REALDB.Cars.Add(newCar);
      return newCar;
    }

    public Car Edit(Car carEdit, string id)
    {
     Car data = REALDB.Cars.Find(c => c.id == id);
     if(carEdit.Model == null)
     {
       data.Model = data.Model;
     } else if(carEdit.Make == null)
     {
      data.Make = data.Make;
     }
    return data;

    }

    public string Delete(string id)
    {
      int index = REALDB.Cars.FindIndex(c => c.id == id);
      REALDB.Cars.RemoveAt(index);
      return "Deleted!";
    }
  }
}