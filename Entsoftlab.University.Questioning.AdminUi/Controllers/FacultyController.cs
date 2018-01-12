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
  [Route("api/Faculty")]
  public class FacultyController : Controller {
    private readonly QuestioningContext _context;

    public FacultyController(QuestioningContext context) {
      _context = context;
    }

    [HttpGet]
    public IEnumerable<Faculty> Get() {
      return _context.Faculties.Select(x => Mapper.Map<Faculty>(x));
    }

    [HttpGet("{id}", Name = "Get")]
    public Faculty Get(Guid id) {
      return Mapper.Map<Faculty>(_context.Faculties.FirstOrDefault());
    }

    [HttpPost]
    public Guid Post([FromBody] Faculty model) {
      var item = Mapper.Map<Data.Models.Faculty>(model);
      item.Id = Guid.NewGuid();
      _context.Faculties.Add(item);
      _context.SaveChanges();
      return item.Id;
    }

    [HttpPut()]
    public void Put([FromBody] Faculty model) {
      var item = Mapper.Map<Data.Models.Faculty>(model);
      var ent = _context.Faculties.Attach(item);
      ent.State = EntityState.Modified;
      _context.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id) {
      _context.Faculties.Remove(_context.Faculties.First(x => x.Id == id));
      _context.SaveChanges();
    }
  }
}
