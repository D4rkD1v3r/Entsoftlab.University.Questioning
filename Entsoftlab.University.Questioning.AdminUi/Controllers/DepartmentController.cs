using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Entsoftlab.University.Questioning.AdminUi.Models;
using Entsoftlab.University.Questioning.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entsoftlab.University.Questioning.AdminUi.Controllers {
  [Produces("application/json")]
  [Route("api/department")]
  public class DepartmentController : Controller {
    private readonly QuestioningContext _context;

    public DepartmentController(QuestioningContext context) {
      _context = context;
    }

    [HttpGet]
    public IEnumerable<Department> Get() {
      return _context.Departments.Select(x => Mapper.Map<Department>(x));
    }

    [HttpGet("item/{id}")]
    public Department Get(Guid id) {
      return Mapper.Map<Department>(_context.Departments.FirstOrDefault());
    }

    [HttpPost]
    public Guid Post([FromBody] Department model) {
      var item = Mapper.Map<Data.Models.Department>(model);
      item.Id = Guid.NewGuid();
      _context.Departments.Add(item);
      _context.SaveChanges();
      return item.Id;
    }

    [HttpPut()]
    public void Put([FromBody] Department model) {
      var item = Mapper.Map<Data.Models.Department>(model);
      var ent = _context.Departments.Attach(item);
      ent.State = EntityState.Modified;
      _context.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id) {
      _context.Departments.Remove(_context.Departments.First(x => x.Id == id));
      _context.SaveChanges();
    }
  }
}
