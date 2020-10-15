using System;
using System.Collections.Generic;
using greglistserver.Models;
using greglistserver.Services;
using Microsoft.AspNetCore.Mvc;

namespace greglistserver.Controllers
{
      [ApiController]
      [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
      private readonly CarsService _carsService;

    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
          return Ok(_carsService.GetCars());
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Car> GetById(string id)
    {
      try
      {
          return Ok(_carsService.GetById(id));
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
          return Ok(_carsService.Create(newCar));
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Car> Edit([FromBody] Car carEdit, string id)
    {
      try
      {
          return Ok(_carsService.Edit(carEdit, id));
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Car> Delete(string id)
    {
      try
      {
          return Ok(_carsService.Delete(id));
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }

  }
}