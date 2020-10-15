using System.Collections.Generic;
using greglistserver.Models;

namespace greglistserver.db
{
  public class REALDB
  {
    public static List<Car> Cars{get; set;} = new List<Car>(){
      new Car("Honda", "Civic")        
    };
  }
}